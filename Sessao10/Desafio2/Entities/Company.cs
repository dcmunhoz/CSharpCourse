using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio2.Entities
{
    class Company : Person
    {
        public int Employees { get; set; }

        public Company(string name, double anualIncome, int employees) : base(name, anualIncome)
        {
            Employees = employees;
        }

        public override double Taxes()
        {
            double tax = 0;

            if (Employees >= 10)
            {
                tax = AnualIncome * 0.14; 
            }else
            {
                tax = AnualIncome * 0.16;
            }

            return tax;

        }
    }
}
