using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    class HourContract
    {

        public DateTime Date { get; set; }

        public double valuePerHour { get; set; }

        public int Hours { get; set; }

        public HourContract()
        {

        }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            this.valuePerHour = valuePerHour;
            Hours = hours;
        }
        public double totalValue() {
            return valuePerHour*Hours;

        }
    }
}
