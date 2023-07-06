using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTestAssignment3
{



    public class CalculateWeekNumber
    {

        public static int GetDayNumber(DateTime date)
        {
            int DayNumber = date.DayOfYear;
            return DayNumber;
        }

        public static int GetWeekNumber(int DayNumber)
        {
            int WeekNumber = (DayNumber) / 7 + 1;
            return WeekNumber;

        }

        public static void Main(string[] args)
        {
            Console.WriteLine("The date");
/*            DateTime date = new DateTime(2023, 07, 05);*/

            Console.WriteLine("Enter the date");
            int userDate = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Month");
            int userMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Year");
            int userYear = int.Parse(Console.ReadLine());

            DateTime date = new DateTime(userYear, userMonth, userDate);

            Console.WriteLine("The Entered date : " + date.ToString());

            //Getting the day Number
            int daynumber = GetDayNumber(date);
            Console.WriteLine("The day number is : " + daynumber.ToString());

            //Getting the week Number
            int weeknumber = GetWeekNumber(daynumber);
            Console.WriteLine("The week Number is : " + weeknumber.ToString());

        }


    }
}