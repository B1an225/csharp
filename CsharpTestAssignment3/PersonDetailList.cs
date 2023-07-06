using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTestAssignment3
{
    class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    class PersonDetailList
    {
        public static void Main(string[] args)
        {
            List<Person> list = new List<Person>();

            //For first person
            Person person1 = new Person() { PersonId = 1, FirstName = "A", LastName = "B" };

            //For second person
            Person person2 = new Person();
            person2.PersonId = 2;
            person2.FirstName = "C";
            person2.LastName = "D";

            //For third person
            Person person3 = new Person();
            person3.PersonId = 3;
            person3.FirstName = "E";
            person3.LastName = "D";
            list.Add(new Person { PersonId = 1, FirstName = "A", LastName = "B" });


            //Adding person detals to the list

            list.Add(person1);
            list.Add(person2);
            list.Add(person3);



            foreach (Person person in list)
            {
                Console.WriteLine($"ID : {person.PersonId} ,FistName: {person.FirstName}, LastName: {person.LastName}");
            }


            ///Now Formatting the Person date into CSV file format.


            // Construct the CSV content
            StringBuilder csvContent = new StringBuilder();
            csvContent.AppendLine("PersonId,FirstName,LastName"); // Add header row

            Console.WriteLine(csvContent);

            foreach (Person person in list)
            {
                csvContent.AppendLine($"{person.PersonId},{person.FirstName},{person.LastName}");
            }
            Console.WriteLine(csvContent);



        }
    }
}
