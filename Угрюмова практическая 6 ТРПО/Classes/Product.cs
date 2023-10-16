using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Угрюмова_практическая_6_ТРПО.Classes;
using Угрюмова_практическая_6_ТРПО.Classes.Converters;

namespace Угрюмова_практическая_6_ТРПО.Classes
{
    public class Product
    {
        public string ProductName { get; set; }
        public string ImageFile { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
        public double Discount { get; set; }
        public bool HasDiscount
        {
            get
            {
                return Discount > 0;
            }
        }
        public decimal DiscountPrice
        {
            get
            {
                return Price * (decimal)(1 - Discount);
            }
        }

    }
}
