using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationerySales
{
    class Date
    {
        private int month;
        private int day;

        public int Year { get; private set; }

        public Date(int theMonth, int theDay, int theYear)
        {
            Month = theMonth;
            Year = theYear;
            Day = theDay;
            Console.WriteLine("Date object constructor for date {0}", this);
        }

        public int Month
        {
            get
            {
                return month;
            }
            private set
            {
                if (value >= 0 && value <= 12)
                    month = value;
                else
                    throw new ArgumentOutOfRangeException("Month", value, "Month must be 1-12");
            }
        }

        public int Day
        {
            get
            {
                return day;
            }
            private set
            {
                int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30,
                                        31, 31, 30, 31, 30, 31};

                if (value >= 0 && value <= daysPerMonth[Month])
                    day = value;
                else if (Month == 2 && value == 29 && (Year % 400 == 0 || (Year % 4 == 0 && Year % 100 != 0)))
                    day = value;
                else
                    throw new ArgumentOutOfRangeException("Day", value, "Day out of range for current month/year");
            }
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}/{2}", Month, Day, Year);
        }
    }
}
