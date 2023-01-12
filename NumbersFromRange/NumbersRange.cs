using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersFromRange
{
    public class NumbersRange
    {
        /*Given an array of integers, write a query that returns list of numbers greater than 30 and less than 100.
Expected input and output
[67, 92, 153, 15] → 67, 92*/
        public void NumbersFromRange()
        {
            List<int> numbers = new List<int>()
            {
                67, 92, 153, 15
            };

            var num = numbers.Where(x => x > 30).Where(x => x < 100);
            foreach(var n in num)
            {
                Console.Write($"{n} ");
            }
            Console.ReadLine();
        }
    }
}
