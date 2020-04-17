using System;
using System.Collections.Generic;
using System.Text;

namespace quiz1gao
{
    //2 - Create a class Name is as Employee(id, name, salary)
    class Employee
    {
        public int id;
        public string name;
        public double salary;

        public Employee()
        {

        }
        public Employee(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
    }
}
