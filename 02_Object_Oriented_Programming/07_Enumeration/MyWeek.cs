using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_SelfStudy_TourExercise.Self_Study
{
    public enum Days { Mon, Tue, Wed, Thur, Fri, Sat, Sun }
    public class MyWeek
    {
        public static void Main()
        {
            Days currDay;
            for (Days i = Days.Mon; i <= Days.Sun; i++)
            {
                currDay = i;

                if (currDay == Days.Fri)
                    Console.WriteLine("{0}:\tEndure...Weekend is near.", currDay);
                else if (currDay == Days.Sat)
                    Console.WriteLine("{0}:\tHooray! Weekend is here!", currDay);
                else if (currDay == Days.Sun)
                    Console.WriteLine("{0}:\tOh no, the blues are coming...", currDay);
                else
                    Console.WriteLine("{0}:\tWork and work till I drop...", currDay);
            }
        }
    }
}
