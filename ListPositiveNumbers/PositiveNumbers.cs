using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListPositiveNumbers
{
    public class PositiveNumbers
    {

        public void DisplayPositiveNumber()
        {
            List<string> numbersArray = new List<string>();
            List<int> numbers = new List<int>();
            int[] array = new int[] { -1, 56, 31, -2, 61, 12, -3, 0 };
            numbers.AddRange(array);

            var num = numbers.Where(x => x > 0).Where(x => x != 0);
            foreach (var item in num)
            {
                numbersArray.Add(item.ToString());
            }

            Console.Write("The positive numbers from the list are: ");

            foreach (var item in numbersArray)
            {
               Console.Write("{0}, ", item);
            }

            Console.ReadLine();
        }


    }
}
