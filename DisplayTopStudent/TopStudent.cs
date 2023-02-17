using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayTopStudent
{
    public class TopStudent
    {

        //Display the top student with highest grade
        public void DisplayTopStudents()
        {
            Dictionary<string, int> students = new Dictionary<string, int>();
            students.Add("Helaman", 79);
            students.Add("Farra", 98);
            students.Add("Dodong", 81);

            List<int> grade = new List<int>();

            foreach (var item in students)
            {
                grade.Add(item.Value);
            }

            var topGrade = grade.Max();
            foreach (var item in students)
            {
                if(topGrade == item.Value)
                Console.WriteLine($"The top student is {item.Key} with the grade of {item.Value}." );
            }
            
            Console.ReadLine();

        }

    }
}
