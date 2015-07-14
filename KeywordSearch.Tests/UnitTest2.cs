using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GMKB.Models;
using GMKB.Abstract;
using GMKB.Concrete;
using GMKB.Controllers;

namespace KeywordSearch.Tests
{
    [TestClass]
    public class UnitTest2
    {
        //added new model folder and included edmx file
        //test2 passed
        private ICaseRepository repo = new EFSaturnCaseRepository();

        public UnitTest2()
        {
            repo = new EFSaturnCaseRepository();
        }

        [TestMethod]
        public void AbleToRetreiveTypeList()
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
            List<String> types = casesController.GetTypeList(cases);

             //assert
            Assert.IsNotNull(types);
        }
    }
}
