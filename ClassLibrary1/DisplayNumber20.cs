using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayNumber
{
    public class DisplayNumber20
    {
        //Write a program in C# to create a list of numbers and display the numbers greater than 20 in LINQ Query
        public void DisplayNumberGreater20()
        {
            List<int> list = new List<int>()
            {
                1,23,54,12,43,67,53,57,23,14,16,2,5,7,2,5,32,41,17
            };
            Console.WriteLine("Here's the list of numbers: ");
            foreach(int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n\nThe numbers greater than 20 are: ");
            var numberlist = list.Where(x => x > 20);
            foreach(var number in numberlist)
                Console.Write($"{number} ");
            Console.ReadLine();
        }

    }
}
