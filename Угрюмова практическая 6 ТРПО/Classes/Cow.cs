using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows;

namespace Угрюмова_практическая_6_ТРПО.Classes
{
    public class Cow
    {
        public string Name { get; set; }
        public string Voice { get; set; }
        public string Image { get; set; }
        public int Age { get; set; }
        public string FullAgeString
        {
            get
            {
                return $"{DateTime.Now.ToShortDateString()} {Name} {Age} лет";
            }
        }
    }
}
