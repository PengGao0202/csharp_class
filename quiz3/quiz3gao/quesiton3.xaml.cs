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

namespace quiz3gao
{
    /// <summary>
    /// Interaction logic for quesiton3.xaml
    /// </summary>
    public partial class quesiton3 : Window
    {
        public quesiton3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //int i = 0;
            List<int> numlist = new List<int>();
            numlist.Add(55);
            numlist.Add(200);
            numlist.Add(740);
            numlist.Add(76);
            numlist.Add(230);
            numlist.Add(482);
            numlist.Add(95);

            List<int> FilterList = numlist.FindAll(x => x > 80 ? true : false);

            String output = "";
            foreach (var num in FilterList)
            {
                output += num;
                output += "\n";
            }
            
            MessageBox.Show(output);
        }
    }
}
