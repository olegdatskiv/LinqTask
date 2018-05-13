using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Client
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public int MonthNumber { get; set; }
        public int DurationClasses { get; set; }

        public Client(int id, int year, int month, int duration)
        {
            Id = id;
            Year = year;
            MonthNumber = month;
            DurationClasses = duration;
        }

        public Client()
        {
            Id = 0;
            Year = 0;
            MonthNumber = 0;
            DurationClasses = 0;
        }

        public override string ToString() => String.Format("{0} {1} {2}", DurationClasses, Year, MonthNumber);
    }
}
