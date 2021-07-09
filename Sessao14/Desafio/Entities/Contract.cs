using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double Value { get; private set; }
        public List<Installment> Installments { get; set; }

        public Contract(int number, DateTime date, double value)
        {
            Number = number;
            Date = date;
            Value = value;
            Installments = new List<Installment>();
        }
    }
}
