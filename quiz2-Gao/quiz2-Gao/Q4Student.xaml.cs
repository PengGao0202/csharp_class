using System;
using System.Collections;
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
    /// Interaction logic for Q4Student.xaml
    /// </summary>
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Student(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
    }

    public partial class Q4Student : Window
    {
       
        ArrayList studentList = new ArrayList();
        public Q4Student()
        {
            InitializeComponent();
            studentList.Add(new Student(1, "Peng1"));
            studentList.Add(new Student(2, "Peng2"));
            studentList.Add(new Student(3, "Peng3"));
            studentList.Add(new Student(4, "Peng4"));
            studentList.Add(new Student(5, "Peng5"));
        }




        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            int i = 0;
            int.TryParse(tbNewStudent.Text, out i);
            if (i > 5 || i < 1)
            {
                MessageBox.Show("Student ID is not in the list");

            }
            if (tbNewStudent.Text == "")
            {
                MessageBox.Show("Please enter student ID to see student's name!");
            }
            else
            {
                foreach (Student stu in studentList)
                {
                    if ((stu.ID.ToString() == tbNewStudent.Text))
                    {
                        if (!lbStudents.Items.Contains(stu.Name))
                            lbStudents.Items.Add(stu.Name);
                        else
                            MessageBox.Show("This student already exists!");
                    }
                }
            }
        }
    }
}
