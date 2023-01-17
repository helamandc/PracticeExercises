using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddNumbers
{
    public class OddEven
    {
        //check even or odd number using switch case
        //https://techstudy.org/Csharp/Write-Csharp-program-to-check-even-or-odd-number-using-switch-case/
        public void DisplayResult()
        {
            IdentifyOddEven myOddEven = new IdentifyOddEven();
            Console.WriteLine("This code will identify whether the number input is Odd or Even.");
            Console.Write("Input the number here: ");
            myOddEven.number = int.Parse(Console.ReadLine());
            myOddEven.IdentifierOddEven(Result(myOddEven.number));
            Console.ReadLine();
        }

        public string Result(int num)
        {
            if (num % 2 == 0)
                return "Even";
            else
                return "Odd";
        }


    }

    public class IdentifyOddEven
    {
        public int number { get; set; }

        public void IdentifierOddEven(string identfier)
        {
            switch (identfier)
            {
                case "Odd":
                    Console.WriteLine("Your number is Odd!");
                    break;
                case "Even":
                    Console.WriteLine("Your number is Even!");
                    break;
            }
        }
   

}

}
