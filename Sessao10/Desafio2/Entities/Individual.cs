using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio2.Entities
{
    class Individual : Person
    {

        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Taxes()
        {

            double tax = 0;

            if (AnualIncome < 20000.00)
            {
                tax =  AnualIncome * 0.15;
            }
            else
            {
                tax = AnualIncome * 0.25;
            }

            if (HealthExpenditures > 0)
            {
                tax = tax - (HealthExpenditures * 0.5);
            }

            return tax;

        }

    }
}
