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
    /// Interaction logic for _1_registration_form.xaml
    /// </summary>
    public partial class _1_registration_form : Window
    {
        public _1_registration_form()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhoneNumber.Clear();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string txtFN = txtFirstName.Text;
            string txtLN = txtLastName.Text;
            string txtPN = txtPhoneNumber.Text;
            MessageBox.Show($"First Name is: {txtFN}, Last Name is: {txtLN}, Phone Number is: {txtPN} ." );
        }

       
    }
}
