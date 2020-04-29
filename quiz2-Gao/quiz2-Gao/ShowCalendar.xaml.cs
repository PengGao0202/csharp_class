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
    /// Interaction logic for ShowCalendar.xaml
    /// </summary>
    public partial class ShowCalendar : Window
    {
        public ShowCalendar()
        {
            InitializeComponent();
        }

        public void passData(string date)
        {
            lblValue.Content = date;
        }
        public string _textBox
        {
            set { lblValue.Content = value; }
        }
    }
}
