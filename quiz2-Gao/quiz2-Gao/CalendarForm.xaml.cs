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
    /// Interaction logic for CalendarForm.xaml
    /// </summary>
    public partial class CalendarForm : Window
    {
        public delegate void delPassDate(string date);
        public CalendarForm()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //using delegate
            ShowCalendar frm = new ShowCalendar();
            delPassDate delPassDate = new delPassDate(frm.passData);
            delPassDate(this.cldSample.SelectedDate.ToString());
            frm.Show();

        }
        public string _date
        {
            get { return cldSample.SelectedDate.ToString(); }
        }
    }
}
