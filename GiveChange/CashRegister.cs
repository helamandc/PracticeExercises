using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiveChange
{
    public class CashRegister
    {
        //Create a C# program that simulates a supermarket cash register to return a purchase change. Request the total amount of money you have in the cash register (x) and an integer with the purchase value (y).

        //You must use 100, 50, 20, 10, 5, 2, or 1 bills and return the change using the larger bills first.

        //https://www.exercisescsharp.com/flow-controls-c/give-change

        CalculateChange myCalculateChange = new CalculateChange();

        public void CashRegisterMachine()
        {
            Console.WriteLine("Helaman's Sari-Sari Store!\n");
            Console.WriteLine("Please enter the amount of the item: ");
            myCalculateChange.amount = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your money: ");
            myCalculateChange.money = int.Parse(Console.ReadLine());

            Console.WriteLine($"Here's your total change: {myCalculateChange.CalculateChangeMoney()}");
            Console.Write("Please get your change below with the following bills/coins: ");
            Change();
            Console.ReadLine();
        }


        public void Change()
        {
                int balance = myCalculateChange.CalculateChangeMoney();
            List<int> list = new List<int>()
            {
                100,
                50,
                20,
                10,
                5,
                2,
                1
            };
            List<int> list2 = new List<int>();
            foreach (int item in list)
            {
                while (balance >= item)
                {
                    list2.Add(item);
                    balance -= item;
                }

            }
            foreach (var item in list2)
            {
                Console.Write(item + " ");
            }

        }
    }

    public class CalculateChange
    {
        public int amount { get; set; }
        public int money { get; set; }
        public int CalculateChangeMoney()
        {
            return money - amount;
        }
    }
}
