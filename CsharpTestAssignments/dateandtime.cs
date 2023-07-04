/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTestAssignments
{
    class dateandtime
    {

        public static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime.ToString());


            Console.Write("Enter your birth date (dd-MM-yyyy): ");
            string input = Console.ReadLine();

            // Splitting input string by '-' separator
            string[] dateComponents = input.Split('-');

            int day, month, year;

            if (dateComponents.Length == 3 &&
                int.TryParse(dateComponents[0], out day) &&
                int.TryParse(dateComponents[1], out month) &&
                int.TryParse(dateComponents[2], out year))
            {
                DateTime birthDate = new DateTime(year, month, day);


                Console.WriteLine(birthDate.ToString());
                Console.WriteLine(dateTime);

                TimeSpan daysSinceBirth = DateTime.Now - birthDate;
                Console.WriteLine(daysSinceBirth.ToString());
                int numberOfDays = (int)daysSinceBirth.TotalDays;

                int age = numberOfDays / 365;

                Console.WriteLine("The age of a person is :" + age);

            }
        }

    }
}*/
