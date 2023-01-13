using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterFrequency
{
    public class LetterFrequencyCount
    {
        //Write a query that returns letters and their frequencies in the string.
        //        Expected input and output
        //"gamma" → "Letter g occurs 1 time(s), Letter a occurs 2 time(s), Letter m occurs 2 time(s)"
        //https://csharpexercises.com/linq/exercise/frequency-of-letters
        public void LetterCountFrequency()
        {
            Console.WriteLine("Please input your word: ");
            string word = Console.ReadLine().ToUpper();
            List<char> words = new List<char>();
            var wordchararray = word.ToCharArray();
            foreach (char c in wordchararray)
                words.Add(c);

            List<char> words2 = words.Distinct().ToList();
            foreach(char c in words2)              
                Console.Write($"Letter {c} occurs {CountLetters(word, c)} time(s), ");
            Console.ReadLine();
        }

        public int CountLetters(string sampleword, char lettertofind)
        {
            return sampleword.Count(t => t == lettertofind);
        }

    }
}
