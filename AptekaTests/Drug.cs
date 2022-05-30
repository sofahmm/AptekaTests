using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AptekaTests
{
    public class Drug
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int IdManufacturer { get; set; }
        public double Price { get; set; }

        public static List<Drug> GetDrug()
        {
            return new List<Drug>()
            {
                new Drug { ID = 1, Name = "Фенибут", IdManufacturer = 1, Price = 490},
                new Drug { ID = 2, Name = "Успокительные", IdManufacturer = 2, Price = 765},
                new Drug { ID = 3, Name = "ОтМокрота", IdManufacturer = 3, Price = 1056},
                new Drug { ID = 4, Name = "ХорошееЛекарство", IdManufacturer = 2, Price = 155},
                new Drug { ID = 5, Name = "ТакНадо", IdManufacturer = 3, Price = 56}
            };
        }

        public static List<string> GetName()
        {
            List<string> DrugName = new List<string>();
            foreach (var i in GetDrug())
                DrugName.Add(i.Name);
            return DrugName;
        }

        public static List<string> GetNameManufacture()
        {
            List<string> ManufactureName = new List<string>();
            foreach (var i in Manufacture.GetManufacture())
                ManufactureName.Add(i.Name);
            return ManufactureName;
        }

        public static List<Drug> SortByOrder()
        {
            return GetDrug().OrderBy(a => a.Price).ToList();
        }

        public static List<Drug> SortDescOrder()
        {
            return GetDrug().OrderByDescending(a => a.Price).ToList();
        }

        public static string ExpensiveDrug()
        {
            var expensive = GetDrug().OrderByDescending(a => a.Price).ToList();
            return expensive[0].Name;
        }
    }
}
