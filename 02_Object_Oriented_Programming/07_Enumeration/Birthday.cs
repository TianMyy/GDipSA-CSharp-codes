using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_SelfStudy_TourExercise.Self_Study
{
    public enum Day { Mon, Tue, Wed, Thur, Fri, Sat, Sun }
    public struct Birthday
    {
        private Day day;
        private string month;
        public string BMonth
        {
            get { return month; }
            set { month = value; }
        }
        public Day BDayOfWk
        {
            get { return day; }
            set { day = value; }
        }
        public static void Main()
        {
            Birthday myBDay = new Birthday();
            myBDay.BMonth = "Sep"; myBDay.BDayOfWk = Day.Fri;
            Console.WriteLine("My birthday falls on a {0} in {1}.", myBDay.BDayOfWk, myBDay.BMonth);
        }
    }
}
