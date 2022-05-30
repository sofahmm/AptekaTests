using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AptekaTests
{
    public class Pharmacists
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public int Experience { get; set; }

        public List<Pharmacists> GetPharmacists()
        {
            return new List<Pharmacists>()
            {
                new Pharmacists { ID = 1, FullName = "Кумышбаева София Алексеевна", Experience = 3},
                new Pharmacists { ID = 2, FullName = "Кумышбаева Оксана Анваровна", Experience = 4},
                new Pharmacists { ID = 3, FullName = "Аркадьева Оксана Николаевна", Experience = 5}
            };
        }
    }
}
