using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindUpper
{
    //Write a program in C# to find the uppercase words in a string in LINQ Query
    //https://techstudy.org/csharp/Write-a-program-in-C-Sharp-to-find-the-uppercase-words-in-a-string/
    public class FindUpperWord
    {
        public void FindUpperText()
        {
            Console.Write("Write your favorite quote in here: ");
            string phrase = Console.ReadLine();

            List<string> words = new List<string>();

            string[] phraseArray = phrase.Split();

            foreach (var item in phraseArray)
            {
                if (char.IsUpper(item[0]))
                {
                    words.Add(item);
                }
            }
            foreach (var item in words)
            {
                Console.WriteLine(item + " ");

            }
            Console.ReadLine();
        }
    }
}
