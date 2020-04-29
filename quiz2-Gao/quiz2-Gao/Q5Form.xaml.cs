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
    /// Interaction logic for Q5Form.xaml
    /// </summary>
    public partial class Q5Form : Window
    {
        int clickTimes;
        public Q5Form()
        {
            InitializeComponent();
            clickTimes = 0;
        }

        private void btnClick_Click(object sender, RoutedEventArgs e)
        {
            clickTimes++;
            TreeViewItem treeViewItem = new TreeViewItem();
            treeViewItem.Header = clickTimes;
            if(clickTimes %2 == 0)
            {
                evenNum.Items.Add(treeViewItem);
            }
            else
            {
                oddNum.Items.Add(treeViewItem);
            }

            if(btnClick.Background == Brushes.Red)
            {
                btnClick.Background = Brushes.Blue;
            } else
            {
                btnClick.Background = Brushes.Red;
            };
        }
    }
}
