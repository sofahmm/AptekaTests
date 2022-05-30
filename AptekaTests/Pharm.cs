using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AptekaTests
{
    public class Pharm
    {
        public int ID { get; set; }
        public string Address { get; set; }

        public List<Pharm> GetPharms()
        {
            return new List<Pharm>()
            {
                new Pharm { ID = 1, Address = "Зорге 109"},
                new Pharm { ID = 2, Address = "Шевцовой 7"},
                new Pharm { ID = 3, Address = "Галеева 3"}
            };
        }
    }
}
