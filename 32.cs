using System;
namespace _3._2
{
    internal class Programka
    {
        static void Main()
        {
            int day = 0;
            bool god = false;
            
            Console.WriteLine("Номер года: ");
            int year = int.Parse(Console.ReadLine());

            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                god = true;
            }
            
            
            for (int month=1; month<13; month++)
            {
                
                if ((month == 4) || (month == 6) || (month == 9) || (month == 11))
                {
                    day = 30;
                }
                else if (month != 2)
                {
                    day = 31;
                }
                
                if (month == 2)
                {
                    if (god)
                    {
                        day = 29;
                    }
                    else
                    {
                        day = 28;
                    }
                }
                
                DateTime date = new DateTime(year, month, day);
                var days = Convert.ToInt32(date.DayOfWeek);
                
                int l = 0;
                if (days>4)
                {
                    l = days - 4;
                }
                else if (day<4)
                {
                    l = 3 + days;
                }
                Console.WriteLine($"{day-l}.{month}.{year}");
            }
        }
    }
}