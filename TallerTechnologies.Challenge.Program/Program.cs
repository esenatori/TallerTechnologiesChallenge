using System;
using TallerTechnologies.Challenge.Core;

namespace TallerTechnologies.Challenge.Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Numbers progress = new Numbers();

            string number1  =  Console.ReadLine();
            string number2 = Console.ReadLine();

            var a = progress.ConverToArray(number1);
            var b = progress.ConverToArray(number2);
            var c = progress.Reverse(b);

            var d = progress.Sum(a, b);

            PrintNumber(d);
        }

        static void PrintNumber(char[] number)
        { 
            Console.WriteLine(number);
        }
    }
}
