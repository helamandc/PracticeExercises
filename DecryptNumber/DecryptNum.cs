using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecryptNumber
{
    public class DecryptNum
    {
        public void DecryptionCode()
        {

            //            https://csharpexercises.com/linq/exercise/decrypt-number#
            //            Given a non - empty string consisting only of special chars(!, @, # etc.), return a number (as a string) where each digit corresponds to given special char on the keyboard ( 1→ !, 2 → @, 3 → # etc.).
            //Expected input and output
            //"())(" → "9009"
            //"*$(#&" → "84937"
            //"!!!!!!!!!!" → "1111111111"


            //Dictionary<string, string> DecryptionList = new Dictionary<string, string>();
            //DecryptionList.Add("!", "1");
            //DecryptionList.Add("@", "2");
            //DecryptionList.Add("#", "3");

            //Console.WriteLine("Decryption Code Game");
            //Console.WriteLine("We are North Korean spies, what is the passcode? ");
            //string passcode = Console.ReadLine();
            //List<string> PasscodeList = passcode.Select(c => c.ToString()).ToList();

            //Console.Write("The passcode is: ");
            //foreach (string Passcode in PasscodeList)
            //{


            //    if (Passcode == "!")
            //        Console.Write("1");
            //    else if (Passcode == "@")
            //        Console.Write("2");
            //    else
            //        Console.Write("3");
            //}
            char[] code = new char[] { ')', '!', '@', '#', '$', '%', '^', '&', '*', '(' };
            var encrypt = "#(@*%)$(&$*#&";
            var decrypt = string.Join("",encrypt.Select(c => Array.IndexOf(code,c)));
            Console.WriteLine(decrypt);

            Console.ReadLine();
        }
        
       
    }


}
