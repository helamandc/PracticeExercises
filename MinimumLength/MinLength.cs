using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumLength
{
    public class MinLength
    {
        /*Write a query that returns words at least 5 characters long and make them uppercase.
Expected input and output
"computer", "usb" → "COMPUTER"*/

        public void MinimumLength()
        {

            List<string> wordArray = new List<string>()
            {
                "computer", "usb"
            };

            var wordlist = wordArray.Where(x => x.Count() > 5);

            foreach(string word in wordlist)
            {
               string text = word.ToUpper();
               Console.WriteLine(text);
            }
            Console.ReadLine();

        }
    }
}
