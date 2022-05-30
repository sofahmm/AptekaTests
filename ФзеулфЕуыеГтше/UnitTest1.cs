using AptekaTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AptekaTestsUnit
{
    [TestClass]
    public class UnitTest1
    {
        static List<Drug> listDr;
        [ClassInitialize]
        public static void GetDr(TestContext testContext)
        {
            listDr = new List<Drug>()
            {
                new Drug { ID = 5, Name = "ТакНадо", IdManufacturer = 3, Price = 56},
                new Drug { ID = 4, Name = "ХорошееЛекарство", IdManufacturer = 2, Price = 155},
                new Drug { ID = 1, Name = "Фенибут", IdManufacturer = 1, Price = 490 },
                new Drug { ID = 2, Name = "Успокоительные", IdManufacturer = 2, Price = 765 },
                new Drug { ID = 3, Name = "ОтМокрота", IdManufacturer = 3, Price = 1056 }
            };
        }

        [TestMethod]
        public void TestDrugName()
        {
            List<string> expectedNameDrug = Drug.GetName();

            List<string> actualNameDrug = new List<string>()
            {
                "Фенибут",
                "Успокоительные",
                "ОтМокрота",
                "ХорошееЛекарство",
                "ТакНадо"
            };

            CollectionAssert.AreEqual(expectedNameDrug, actualNameDrug);
        }

        [TestMethod]
        public void TestNameManufacture()
        {
            List<string> expectedNameManufacturer = Drug.GetNameManufacture();

            List<string> actualNameManufacturer = new List<string>()
            {
                "Привет",
                "Пока",
                "Прощай"
            };

            CollectionAssert.AreEqual(expectedNameManufacturer, actualNameManufacturer);
        }

        [TestMethod]
        public void TestSortByOrder()
        {
            List<Drug> expectedSortOrderByDrug = Drug.SortByOrder();
            List<Drug> actualSortOrderByDrug = Drug.GetDrug().OrderBy(x => x.Price).ToList();

            CollectionAssert.AreEqual(expectedSortOrderByDrug, actualSortOrderByDrug);
        }

        [TestMethod]
        public void TestDescOrder()
        {
            List<Drug> actualSortOrderByDrug = new List<Drug>()
            {
                new Drug { ID = 3, Name = "ОтМокрота", IdManufacturer = 3, Price = 1056},
                new Drug { ID = 2, Name = "Успокоительные", IdManufacturer = 2, Price = 765},
                new Drug { ID = 1, Name = "Фенибут", IdManufacturer = 1, Price = 490},
                new Drug { ID = 4, Name = "ХорошееЛекарство", IdManufacturer = 2, Price = 155},
                new Drug { ID = 5, Name = "ТакНадо", IdManufacturer = 3, Price = 56}
            };
            CollectionAssert.AreEquivalent(listDr, actualSortOrderByDrug);
        }

        [TestMethod]
        public void TestExpensiveDrug()
        {
            string expectedNameDrug = Drug.ExpensiveDrug();
            string actualNameDrug = "ОтМокрота";

            Assert.AreEqual(expectedNameDrug, actualNameDrug);
        }

        [TestMethod]
        public void TestGetDrugInPharm()
        {
            List<Drug> actualDrugInPharm = new List<Drug>()
            {
                new Drug { ID = 1, Name = "Фенибут", IdManufacturer = 1, Price = 490},
                new Drug { ID = 2, Name = "Успокоительные", IdManufacturer = 2, Price = 765}
            };
            Assert.AreEqual(DrugInPharm.GetDrugInPharms(1).Count(), actualDrugInPharm.Count());
        }
    }

}
