using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace temp
{

    internal class Program
    {
        static void Main(string[] args)
        {

            var s = Console.ReadLine();

            foreach (char c in s)
            {
                Console.WriteLine($"Буква {c} = {GetLetterNumber(c)} -я");
            }

            Console.ReadLine();

        }

        static int GetLetterNumber(char letter)
        {
            var bet = new List<char>();


            for (char c = 'а'; c <= 'я'; c++)
                {
                    bet.Add(c);
                }

            return bet.FindIndex(a => a.ToString() == letter.ToString().ToLower()) + 1;
        }
    }
}