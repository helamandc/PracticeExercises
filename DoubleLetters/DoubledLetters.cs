using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLetters
{
    public class DoubledLetters
    {
        //Write a query that returns double letters sequence in format: AA AB AC ... ZX ZY ZZ
        //Expected input and output
        //(no input) → "AA AB AC ... AZ BA BB ... ZX ZY ZZ"
        //https://csharpexercises.com/linq/exercise/double-letters#
        public void DoubledLettersDisplay()
        {
            List<string> letters = new List<string>();
            letters.Add(MainLetters.A.ToString());
            letters.Add(MainLetters.B.ToString());
            letters.Add(MainLetters.C.ToString());

            foreach (var item in letters)
            {
                for (int i = 0; i < letters.Count; i++)
                {
                    Console.Write($"{item}{letters[i]} ");
                }
            }
            Console.ReadLine();
        }
        enum MainLetters
        {
            A,
            B,
            C
        }
    }
}
