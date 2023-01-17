using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransposeAnArray
{
    public class ArrayTranspose
    {

        //        Write a query that transposes square array(switch rows with columns).
        //Expected input and output
        //[1, 1, 1, 1[1, 2, 3, 4
        // 2, 2, 2, 2     1, 2, 3, 4
        // 3, 3, 3, 3   → 1, 2, 3, 4
        // 4, 4, 4, 4]    1, 2, 3, 4]
        //https://csharpexercises.com/linq/exercise/transpose-an-array#
        public void TransposeArray()
        {


            var numberArray = new int[][]
            {
                new int[]{ 1, 1, 1, 1 },
                new int[]{ 2, 2, 2, 2 },
                new int[]{ 3, 3, 3, 3 },
                new int[]{ 4, 4, 4, 4 },
                new int[]{ 5, 5, 5, 5 },
            };

            var transposedArray = Enumerable.Range(0, numberArray.Length).Select(i => numberArray.Select(y => y[i]));

            foreach (var row in transposedArray)
            {
                foreach (var number in row)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
        
            

            Console.ReadLine();
        }

    }
}
