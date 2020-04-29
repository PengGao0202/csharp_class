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

namespace quiz2_Gao
{
    /// <summary>
    /// Interaction logic for Q3TabControl.xaml
    /// </summary>
    public partial class Q3TabControl : Window
    {
        public Q3TabControl()
        {
            InitializeComponent();
        }

        private void clickShowTab2_Unchecked(object sender, RoutedEventArgs e)
        {
            tab2.Visibility = Visibility.Hidden;
        }

        private void clickShowTab2_Checked(object sender, RoutedEventArgs e)
        {
            tab2.Visibility = Visibility.Visible;
        }
    }
}
