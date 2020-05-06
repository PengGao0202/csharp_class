﻿using System;
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
    /// Interaction logic for question1.xaml
    /// </summary>
    public partial class question1 : Window
    {
        private List<Student> studentItems;
        public question1()
        {
            InitializeComponent();
            StudentItems = new List<Student>();

            StudentsDataGrid.ItemsSource = StudentItems;
        }
        internal List<Student> StudentItems { get => studentItems; set => studentItems = value; }

        private void OnSave_Click(object sender, RoutedEventArgs e)
        {
            //Add a new the customer
            Student student = new Student(studentItems.Count, FirstNameTextBox.Text, LastNameTextBox.Text, (bool)isRegisteredCheckBox.IsChecked);

            studentItems.Add(student);
            CollectionViewSource.GetDefaultView(StudentsDataGrid.ItemsSource).Refresh();
            MessageBox.Show("Added students: " + studentItems.Count);
        }
    }
}
