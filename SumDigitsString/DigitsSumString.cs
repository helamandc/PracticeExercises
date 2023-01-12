using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigitsString
{
    public class DigitsSumString
    {
        //Given a string, write a method which returns sum of all digits in that string. Assume that string contains only single digits.
        //Expected input and output
        //SumDigitsInString("1q2w3e") → 6
        //SumDigitsInString("L0r3m.1p5um") → 9
        //SumDigitsInString("") → 0
        public void SumOfDigitsString()
        {
            Console.WriteLine("Type your alphanumeric phrase here: ");
            string text = Console.ReadLine();
            SumOfDigits(text);


            Console.ReadLine();

        }

        public void SumOfDigits(string phrase)
        {
            List<double> digits = new List<double>();

            char[] chars = phrase.ToCharArray();
            var cstring = chars.Where(c => char.IsDigit(c));
            foreach (char c in cstring)
            {
                double d = char.GetNumericValue(c);
                digits.Add(d);
            }
                
            double total = digits.Sum();
            Console.WriteLine(total);
        }


    }
}
