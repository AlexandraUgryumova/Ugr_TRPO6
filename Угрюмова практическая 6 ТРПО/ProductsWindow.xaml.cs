using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Угрюмова_практическая_6_ТРПО.Classes;
using Угрюмова_практическая_6_ТРПО.Classes.Converters;

namespace Угрюмова_практическая_6_ТРПО
{
    /// <summary>
    /// Логика взаимодействия для ProductsWindow.xaml
    /// </summary>
    public partial class ProductsWindow : Window
    {
        private Shop shop;
        public ProductsWindow()
        {
            InitializeComponent();
            DataContext = shop = new Shop("Мечи & топоры");
            shop.Products.AddRange(new Product[]
            {
                new Product { ImageFile = "C:\\Users\\alexa\\Desktop\\саша\\программы\\c#\\3 курс\\трпо\\угрюмова трпо №6\\Угрюмова практическая 6 ТРПО\\Images\\1.jpg", ProductName = "Топорик", Count = 2, Discount = 0, Price = 6000},
                new Product { ImageFile = "C:\\Users\\alexa\\Desktop\\саша\\программы\\c#\\3 курс\\трпо\\угрюмова трпо №6\\Угрюмова практическая 6 ТРПО\\Images\\2.jpg", ProductName = "Томагавк", Count = 3, Discount = 0.5, Price = 4000}
            });
            ProductsCount.Content = "Количество наименований = " + shop.Products.Count.ToString();
        }
    }
}
