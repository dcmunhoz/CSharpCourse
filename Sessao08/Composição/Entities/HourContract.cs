using System;
using System.Collections.Generic;
using System.Text;

namespace Composition.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public Double ValuePerHour { get; set; }
        public Int32 Hours { get; set; }

        public HourContract()
        {

        }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public Double TotalValue()
        {
            return ValuePerHour * Hours;
        }

    }
}
