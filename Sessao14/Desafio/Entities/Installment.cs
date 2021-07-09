using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Entities
{
    class Installment
    {
        public DateTime Date { get; set; }
        public double Value { get; set; }

        public Installment(DateTime date, double value)
        {
            Date = date;
            Value = value;
        }
    }
}
