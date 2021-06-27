using System;
using System.Collections.Generic;
using System.Text;

namespace Listas
{
    class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public void increnseSalary(double percent)
        {
            this.Salary *= (percent / 100) + 1;
        }

        public override string ToString()
        {
            return $"{Id}: {Name}, {Salary.ToString("F2")}";
        }

    }
}
