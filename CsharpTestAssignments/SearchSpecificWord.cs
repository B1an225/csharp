using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTestAssignments
{
    class SearchSpecificWord
    {
        public static void Main(string[] args)
        {
            string word;
            word = "Hi bro, how you doing";

            Console.WriteLine(word);

            String search = ", how y";

            if (word.Contains(search))
            {
                Console.WriteLine("found");
            }
            else
            {
                Console.WriteLine("not found");
            }

            string[] wordarray = word.Split(' ');
            Console.WriteLine(wordarray[0]);

            foreach (string individualword in wordarray)
            {
                Console.WriteLine(individualword);
                if (individualword == "doing")
                {
                    Console.WriteLine("Found");

                }

            }

        }
    }
}
