using System;
using System.Globalization;

namespace DateModifier
{
    public class DateModifier
    {
        private string firstDate;
        private string secondDate;

        public string FirstDate
        {
            get
            {
                return firstDate;
            }
            set
            {
                firstDate = value;
            }
        }

        public string SecondDate
        {
            get
            {
                return this.secondDate;
            }
            set
            {
                this.secondDate = value;
            }
        }

        public DateModifier(string firstDate, string secondDate)
        {
            FirstDate = firstDate;
            SecondDate = secondDate;
        }

        public void DaysDifference(DateModifier currentDate)
        {
            var first = DateTime.ParseExact(firstDate, "yyyy MM dd", CultureInfo.InvariantCulture);
            var second = DateTime.ParseExact(secondDate, "yyyy MM dd", CultureInfo.InvariantCulture);
            Console.WriteLine(Math.Abs((first - second).TotalDays));
        }
    }
}