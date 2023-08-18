using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG3B_ICE_Task_1
{
    class ArrayList
    {
        public static void Main(string[] args)
        {

            // Creating an array list
            List<string> words = new List<string>();
            words.Add("programming");
            words.Add("algorithm");
            words.Add("sorting");
            words.Add("arrays");
            words.Add("ice task");
            words.Add("static void method");

            
        }

        // Creating a method for scrammbling the words
        public string shufflewords(string vocabwords)
        {
            char[] chars = new char[vocabwords.Length];
            Random random = new Random(10000);

            int index = 0;

            // Getting the random number between the number 0 and the length of the word
            while (vocabwords.Length > 0)
            {
                int next = random.Next(0, vocabwords.Length - 1);
                chars[index] = vocabwords[next];
                vocabwords = vocabwords.Substring(0, next) + vocabwords.Substring(next + 1);

                index++;
            }

            // Returning the value
            return new String(chars);

        }

        // Creating a method that will check the words if it is correct or incorrect
        public static void Checkword()
        {


        }

    }
}
