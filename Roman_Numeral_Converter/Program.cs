using System;
using System.Linq;

namespace RomanNumeralConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var subject = new RomanNumeral.RomanNumeralConverter();

            var random = new Random();
            const string chars = @"ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789 -+!@?~";
            var length = 9;

            for (var i = 0; i < 100; i++)
            {
                var test_string = new string(Enumerable.Repeat(chars, length)
                  .Select(s => s[random.Next(s.Length)]).ToArray());

                Console.WriteLine(test_string);
            }
        }
    }
}
