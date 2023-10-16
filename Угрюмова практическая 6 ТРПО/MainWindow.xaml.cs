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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Угрюмова_практическая_6_ТРПО
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ElementsBindingWindow ebw = new ElementsBindingWindow();
        ProductsWindow pw = new ProductsWindow();
        ResourseBindingWindow rbw = new ResourseBindingWindow();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            ebw.ShowDialog();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            rbw.ShowDialog();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            pw.ShowDialog();
        }
    }
}
