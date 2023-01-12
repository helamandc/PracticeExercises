using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainingLetter
{
    public class LastContainingLetter
    {
//        Given a non-empty list of words, sort it alphabetically and return a word that contains letter 'e'.
//Expected input and output
//["plane", "ferry", "car", "bike"]→ "plane"

        public void PrintlastContainingLetter()
        {

            List<string> list = new List<string>()
            {
                "plane",
                "ferry",
                "car",
                "bike",
                "mike"
            };
            var wlist = list.OrderBy(x => x).ToList();
            Console.WriteLine("Word list in alphabetical order:");
            foreach(string s in wlist)
                Console.WriteLine(s);

            var wlist2 = wlist.Where(x => x.Contains("e"));
            Console.WriteLine("\nWords ending in letter \"e\":");
            foreach (string s in wlist2)
            {
                if(s.Contains("e") && s[s.Length - 1] == 'e')
                {
                    Console.WriteLine(s);
                }
            }
            //list.Sort();
            //var wlist = list.Where(x => x.Contains("e"));

            //foreach (var item in wlist)
            //{
            //   int size = item.Length;
            //    if(item[size-1] == 'e')
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            Console.ReadLine(); 

        }


    }
}
