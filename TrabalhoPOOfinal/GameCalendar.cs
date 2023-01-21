using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPOOfinal
{
    class Calendar
    {
        public List<int> RaceDay { get; set; }
        public int CurrentDay { get; set; }

        public Calendar(List<int> raceDay, int currentDay)
        {
            RaceDay = raceDay;
            CurrentDay = currentDay;
        }

        public void AdvanceDay()
        {
            CurrentDay++;
        }


        public void DisplayCalendar()
        {
            Console.WriteLine("  Sun Mon Tue Wed Thu Fri Sat");
            int dayOfWeek = (int)DateTime.Now.DayOfWeek;
            for (int i = 1; i <= dayOfWeek; i++)
            {
                Console.Write("    ");
            }
            for (int i = 1; i <= 31; i++)
            {
                if (i == CurrentDay)
                {
                    Console.Write("[{0}]", i.ToString().PadLeft(2));
                }
                else if (RaceDay.Contains(i))
                {
                    Console.Write("({0})", i.ToString().PadLeft(2));
                }
                else
                {
                    Console.Write(" {0} ", i.ToString().PadLeft(2));
                }
                dayOfWeek++;
                if (dayOfWeek == 7)
                {
                    Console.WriteLine();
                    dayOfWeek = 0;
                }
            }
            Console.WriteLine();
        }
    }
}
