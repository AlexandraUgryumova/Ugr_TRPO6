using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Угрюмова_практическая_6_ТРПО.Classes
{
    class Shop
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public string Name { get; private set; }
        public Shop(string name)
        {
            Name = name;
        }
    }
}
