using BasicCalculator;
using ContainingLetter;
using DaysNames;
using DecryptNumber;
using DisplayNumber;
using GiveChange;
using LetterFrequency;
using MinimumLength;
using NumbersFromRange;
using SquareGreater20;
using SumDigitsString;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while(displayMenu)
            displayMenu = MainMenu();
        }

        public static bool MainMenu()
        {
            //NumbersRange myclass = new NumbersRange();
            //myclass.NumbersFromRange();

            //MinLength myClass = new MinLength();
            //myClass.MinimumLength();

            //Calculator myCalculator = new Calculator();
            //myCalculator.SimpleCalculator();

            //DecryptNum myDecrypt = new DecryptNum();
            //myDecrypt.DecryptionCode();

            //LastContainingLetter myletter = new LastContainingLetter();
            //myletter.PrintlastContainingLetter();

            //CashRegister myCashRegister = new CashRegister();
            //myCashRegister.CashRegisterMachine();

            //NameOfDays myDaysNames = new NameOfDays();
            //myDaysNames.PrintDayName();
            //myDaysNames.DayName();

            //DisplayNumber20 myDisplay = new DisplayNumber20();
            //myDisplay.DisplayNumberGreater20();

            //SquareGreater mySquare = new SquareGreater();
            //mySquare.Greater20Square();

            //DigitsSumString myDigit = new DigitsSumString();
            //myDigit.SumOfDigitsString();

            LetterFrequencyCount myLetterCount = new LetterFrequencyCount();
            myLetterCount.LetterCountFrequency();

            return true;
        }

    }
}
