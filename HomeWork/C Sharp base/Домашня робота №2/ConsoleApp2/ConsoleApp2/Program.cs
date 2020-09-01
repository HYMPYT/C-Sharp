using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void StatisticOfString(string str)
        {
            int NumberOfSymbols, NumberOfSpaces = 0, NumberOfDigits = 0, PunctuationCharacterCount = 0, NumberOfLettersAndSpaces = 0;
            NumberOfSymbols = str.Length;
            Console.WriteLine("Number of symbols -> " + NumberOfSymbols);
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                    NumberOfSpaces++;
            }
            Console.WriteLine("Number of spaces -> " + NumberOfSpaces);
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] > 47 && str[i] <= 57)
                    NumberOfDigits++;
            }
            Console.WriteLine("Number of digits -> " + NumberOfDigits);
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ',' || str[i] == '.' || str[i] == ':' || str[i] == ';' || str[i] == '!' || str[i] == '?')
                    PunctuationCharacterCount++;
            }
            Console.WriteLine("Punctuation character count -> " + PunctuationCharacterCount);
            for (int i = 0; i < str.Length - 1; i++)
            {
                if ((str[i] > 64 && str[i] <= 90 || str[i] > 96 && str[i] <= 122) && str[i + 1] == ' ')
                    NumberOfLettersAndSpaces++;
            }
            Console.WriteLine("Number of letters and spaces -> " + NumberOfLettersAndSpaces);
        }

        static string RemoveLastSymbol(string source, string symbol, int pos_s)
        {
            int pos = source.LastIndexOf(symbol);

            if (pos == pos_s)
                return source;

            if (pos == -1)
                return source;

            string result = source.Remove(pos, 1);
            return result;
        }
        static void Main(string[] args)
        {
            //1
            //Console.Write("Enter the string -> ");
            //string str = Console.ReadLine();
            //StatisticOfString(str);


            //2
            //Console.Write("Enter the string -> ");
            //string str = Console.ReadLine();
            //Console.Write("Enter the symbol -> ");
            //string symbol = Console.ReadLine();
            //int pos = 0;
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (str[i] == symbol[0])
            //        pos = i;

            //}
            //str = str.Replace(str[pos], Char.Parse(symbol.ToUpper()));
            //Console.WriteLine("String -> " + str);
            //str = str.Remove(pos);
            //Console.WriteLine("String after remove -> " + str);


            //3
            //Console.Write("Enter the string -> ");
            //string str = Console.ReadLine();
            //Console.WriteLine("String -> " + String.Join(" ", str.Split(' ').Distinct()));


            //4
            //Console.Write("Enter the string -> ");
            //string str = Console.ReadLine();
            //string[] strs = str.Split(' ');
            //string first;
            //for (int i = 0; i < strs.Length; i++)
            //{
            //    first = strs[i][0].ToString();
            //    strs[i] = first + strs[i].Replace(first, "");
            //}
            //Console.Write("String -> ");
            //for (int i = 0; i < strs.Length; i++)
            //{
            //    Console.Write(strs[i] + " ");
            //}
            //Console.WriteLine();


            //5
            Console.Write("Enter the string -> ");
            string str = Console.ReadLine();
            string[] strs = str.Split(' ');
            string symbol;
            for (int i = 0; i < strs.Length; i++)
            {
                for (int j = 0; j < strs[i].Length; j++)
                {
                    symbol = strs[i][j].ToString();
                    strs[i] = RemoveLastSymbol(strs[i].ToString(), symbol, j);
                }
            }
            Console.Write("String -> ");
            for (int i = 0; i < strs.Length; i++)
            {
                Console.Write(strs[i] + " ");
            }
            Console.WriteLine();
        }
    }
}