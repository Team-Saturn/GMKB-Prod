﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GMKB.Models;
using GMKB.Abstract;
using GMKB.Concrete;
using GMKB.Controllers;

namespace KeywordSearch.Tests
{
    [TestClass]
    public class UnitTest1
    {
        //added new model folder and included edmx file
        //test1 passed
        private ICaseRepository repo = new EFSaturnCaseRepository();

        public UnitTest1()
        {
            repo = new EFSaturnCaseRepository();
        }

        [TestMethod]
        public void AbleToRetreiveProductList()
        {

          //  ICaseRepository repo;

             //arrange
            IEnumerable<Case> cases = new List<Case>
            {
                new Case {},
                new Case {}
            };
            CasesController casesController = new CasesController(repo);


             //act
            List<String> products = casesController.GetProductList(cases);

             //assert
            Assert.IsNotNull(products);
        }
    }
}
