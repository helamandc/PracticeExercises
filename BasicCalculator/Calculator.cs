using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    public class Calculator
    {

        //Write C# program to create simple calculator using switch

        public void SimpleCalculator()
        {
            Calculate myCalculator = new Calculate();

            Console.WriteLine("Your Basic Calculator!");
            Console.WriteLine("Input the first number: ");
            myCalculator.firstNumber = float.Parse(Console.ReadLine());
            Console.WriteLine("Please select operand: + , -, *, / ");
            myCalculator.operand = Console.ReadLine();
            Console.WriteLine("Input the second number: ");
            myCalculator.secondNumber = float.Parse(Console.ReadLine());
            float result = myCalculator.TotalNumber(myCalculator.operand, myCalculator.firstNumber, myCalculator.secondNumber);
            Console.WriteLine("The result is {0:F2}.", result);
            Console.ReadLine();
        }


    }

    public class Calculate
    {
        public string operand { get; set; }
        public float firstNumber { get; set; }
        public float secondNumber { get; set; }
        public float TotalNumber(string myoperand, float first, float second)
        {
            float total = 0;

            switch (myoperand)
            {
                case "+":
                    total = first + second;
                    break;
                case "-":
                    total = first - second;
                    break;
                case "*":
                    total = first * second;
                    break;
                case "/":
                    total = first / second;
                    break;
            }

            return total;

        }

    }
}
