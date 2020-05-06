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
    /// Interaction logic for question2.xaml
    /// </summary>
    public partial class question2 : Window
    {
        public question2()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(1, "Peng1", "Gao1", true));
            students.Add(new Student(2, "Peng2", "Gao2", true));
            students.Add(new Student(3, "Peng3", "Gao3", false));

            MyDataGrid.ItemsSource = students;
        }
    }
}
