using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysNames
{

    //Write a query that returns names of days.
    // Expected input and output daysNames → "Sunday Monday Tuesday Wednesday Thursday Friday Saturday"
    //https://csharpexercises.com/linq/exercise/days-names#
    public class NameOfDays
    {
     

        public void DayName()
        {

            var daysNames = Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>();
            foreach (var item in daysNames)
            {
                Console.Write($"{item} ");
                
            }
            Console.ReadLine();
        }

        

        


        //public void PrintDayName()
        //{
        //    Console.Write($"Print the name of days: ");
        //    DayNames();
        //    Console.ReadLine();
        //}

        //public void DayNames()
        //{
        //    DateTime myDate = DateTime.Now;


        //    List<string> completedateinfo = new List<string>();
        //    //List<string> daynames = new List<string>();

        //    for (int i = 0; i < 7; i++)
        //    {
        //        DateTime myNewDate = myDate.AddDays(i);
        //        completedateinfo.Add(myNewDate.ToString("D", CultureInfo.CreateSpecificCulture("en-US")));
        //    }

        //    foreach(string date in completedateinfo)
        //    {



        //        for (int i = 0; i < date.Length; i++)
        //        {
        //            while (date[i] != ',')
        //            {
        //                Console.Write(date[i]);
        //            }
        //        }
        //      //Console.Write(date);
        //        //Console.Write(date.Substring(0,7) + " ");
        //    }

        //}


    }
}
