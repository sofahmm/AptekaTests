using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AptekaTests
{
    public class Manufacture
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static List<Manufacture> GetManufacture()
        {
            return new List<Manufacture>()
            {
                new Manufacture { Id = 1, Name = "Привет"},
                new Manufacture { Id = 2, Name = "Пока"},
                new Manufacture { Id = 3, Name = "Прощай"}
            };
        }
    }
}
