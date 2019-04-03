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

namespace LabSheet8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public NORTHWNDEntities db = new NORTHWNDEntities();
        private void btnQueryEx1_Click(object sender, RoutedEventArgs e)
        {
            var query = from c in db.Customers
                        group c by c.Country into g
                        orderby g.Count() descending
                        select new
                        {
                            Country = g.Key,
                            Count = g.Count()
                        };

            dgCustomersEx1.ItemsSource = query.ToList();
        }

        private void btnQueryEx2_Click(object sender, RoutedEventArgs e)
        {
            var query = from C in db.Customers
                        where C.
        }
    }
}
