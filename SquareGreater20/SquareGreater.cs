using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareGreater20
{

    //Write a query that returns list of numbers and their squares only if square is greater than 20
    //Expected input and output
    //[7, 2, 30] → 7 - 49, 30 - 900
    //https://csharpexercises.com/linq/exercise/square-greater-than-20#
    public class SquareGreater
    {
        public void Greater20Square()
        {
            List<int> list = new List<int>()
            {
                7, 2, 30
            };

            List<int> list2 = new List<int>();

            foreach(int item in list)
            {
                int square = item * item;
                list2.Add(square);
            }

            var list3 = list2.Where(x => x > 20);
            foreach(int item in list3)
                Console.Write(item + " ");

            Console.ReadLine();
        }

    }
}
