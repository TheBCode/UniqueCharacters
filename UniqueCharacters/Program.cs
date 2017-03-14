using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace UniqueCharacters
{
    class Program
    {
        static IDictionary<char, int> charDict = new Dictionary<char, int>();
        private static int _outInt = 0;
        static void Main(string[] args)
        {
            WriteLine("Enter a string: ");
            string _charStr = ReadLine();
            foreach (var ch in _charStr)
            {
                if (!charDict.TryGetValue(ch, out _outInt))
                {
                    charDict.Add(new KeyValuePair<char, int>(ch, 1));
                }
                else
                {
                    charDict[ch]++;
                }
            }
            Console.WriteLine("Distinct Characters: ");
            Console.WriteLine('\n');
            foreach (var i in charDict)
            {
                Console.Write(i.Key);
            }
            Console.WriteLine('\n');
            foreach (var i in charDict)
            {
                Console.WriteLine("Char: " + i.Key + " Count: " + i.Value);
            }
            Console.ReadKey();
        }
    }
}

