using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTestAssignments
{
    class Addtext__infixedposition
    {
        public static void Main(string[] args)
        {
            string text = "Hi, My name is Blan";
            int i;
            Console.WriteLine(text);
            string[] textarray = text.Split(' ');

            for (i = 0; i < textarray.Length; i++)
            {
                Console.WriteLine(textarray[i]);
            }
            textarray[textarray.Length - 2] = "Mr";
            string text2 = string.Join(" ", textarray);
            Console.WriteLine(text2);


        }
    }
}
