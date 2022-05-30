using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AptekaTests
{
    public class DrugInPharm
    {
        public int IDDrug { get; set; }
        public int IDPharm { get; set; }
        public int Count { get; set; }

        public static List<DrugInPharm> GetDrugPharms()
        {
            return new List<DrugInPharm>()
            {
                new DrugInPharm {IDDrug = 3, IDPharm = 3, Count = 5 },
                new DrugInPharm {IDDrug = 2, IDPharm = 2, Count = 15 },
                new DrugInPharm {IDDrug = 1, IDPharm= 1, Count = 25 },
                new DrugInPharm {IDDrug = 2, IDPharm = 1, Count = 10 },
                new DrugInPharm {IDDrug = 3, IDPharm = 2, Count = 45 },
                new DrugInPharm {IDDrug = 1, IDPharm = 2, Count = 2 },
                new DrugInPharm {IDDrug = 3, IDPharm = 2, Count = 5 }
            };
        }

        public static List<Drug> GetDrugInPharms(int ID)
        {
            List<Drug> drug = new List<Drug>();
            foreach (var i in GetDrugPharms().Where(a => a.IDPharm == ID))
            {
                drug.Add(Drug.GetDrug().Where(a => a.ID == i.IDDrug).FirstOrDefault());
            }
            return drug;
        }
    }
}
