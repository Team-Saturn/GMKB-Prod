using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GMKB.Models;
using System.ComponentModel.DataAnnotations;
using PagedList;
using PagedList.Mvc;
using GMKB;
using GMKB.Abstract;
using GMKB.Concrete;


namespace GMKB.Controllers
{
    public class CasesController : Controller
    {
        //saturn entities is ou contex file
       //replace his line IcaseRepository, make new sub folder and stick the Respository folder
       // private SaturnEntities db = new SaturnEntities();
        private ICaseRepository repository;


        public CasesController(ICaseRepository caseRepository)
        {
            this.repository = caseRepository;
        }

        public List<string> GetProductList(IEnumerable<Case> cases)
        {
            //product
            var ProductList = new List<string>();
            var ProductQry = from d in cases
                             orderby d.McMProduct
                             select d.McMProduct;
            ProductList.AddRange(ProductQry.Distinct());
            return ProductList;
        }

        public List<string> GetTypeList(IEnumerable<Case> cases)
        {
            //Type
            var TypeList = new List<string>();

            var TypeQry = from t in cases
                          orderby t.CaseType
                          select t.CaseType;

            TypeList.AddRange(TypeQry.Distinct());
            return TypeList;
        }

        public List<string> GetCategoryList(IEnumerable<Case> cases)
        {
            //Category
            var CategoryList = new List<string>();
            var CategoryQry = from a in cases
                              orderby a.Category
                              select a.Category;

            CategoryList.AddRange(CategoryQry.Distinct());
            return CategoryList;
        }


        // GET: Cases
        public ActionResult Index(string searchString, string caseProduct, string caseType, string caseCategory, int? page)
        {   
           

            ViewBag.caseProduct = new SelectList(GetProductList(repository.Cases));

            ViewBag.caseType = new SelectList(GetTypeList(repository.Cases));

            ViewBag.caseCategory = new SelectList(GetCategoryList(repository.Cases));


            //var Cases = db.Cases.AsQueryable();
            var Cases = repository.Cases.AsQueryable();

            if (!string.IsNullOrEmpty(caseProduct))
            {
                Cases = Cases.Where(x => x.McMProduct == caseProduct);

                if (!string.IsNullOrEmpty(caseType))
                {
                    Cases = Cases.Where(y => y.CaseType == caseType);

                    if (!string.IsNullOrEmpty(caseCategory))
                    {
                        Cases = Cases.Where(b => b.Category == caseCategory);
                        return View("FilterResults", Cases.ToList().ToPagedList(page ?? 1, 10));
                    }

                    return View("FilterResults", Cases.ToList().ToPagedList(page ?? 1, 10));
                }



                return View("FilterResults", Cases.ToList().ToPagedList(page ?? 1, 10));
            }


            //keword search 
            if (!String.IsNullOrEmpty(searchString))
            {
               
                ViewData["searchterm"] = searchString;
                ViewData["color"] = "yellow";

                Cases = Cases.Where(s => s.Resolution.Contains(searchString)
                               || s.Description.Contains(searchString));

                return View("KeywordResults", Cases.OrderByDescending(s => s.McM_DateTime_Resolved).ToList().ToPagedList(page ?? 1, 10));
            

            }
            else
            {
                return View(Cases.OrderByDescending(s => s.McM_DateTime_Resolved).ToList().ToPagedList(page ?? 1, 10));
            }
  
        }

      

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
