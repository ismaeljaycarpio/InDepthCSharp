using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = @"Do you like green eggs and ham?
                            I do not like them, Sam-I-am.
                            I do not like green eggs and ham.";

            Dictionary<string, int> list = CountWords(text);
            foreach(KeyValuePair<string,int> entry in list)
            {
                string word = entry.Key;
                int frequency = entry.Value;
                Console.WriteLine("{0} : {1}", word, frequency);
            }

            Console.ReadLine();
        }

        static Dictionary<string, int> CountWords(string text)
        {
            Dictionary<string, int> frequencies = new Dictionary<string, int>();

            string[] words = Regex.Split(text, @"\W+");

            foreach(string word in words)
            {
                if(frequencies.ContainsKey(word))
                {
                    frequencies[word]++;
                }
                else
                {
                    frequencies[word] = 1;
                }
            }

            return frequencies;
        }
    }
}
