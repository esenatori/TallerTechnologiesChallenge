using System;
using TallerTechnologies.Challenge.Core;

namespace TallerTechnologies.Challenge.Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Numbers progress = new Numbers(); 

            var number1 = progress.ConverToArray(Console.ReadLine());
            var number2 = progress.ConverToArray(Console.ReadLine());
             
            var d = progress.Sum(number1, progress.Reverse(number2));

            PrintNumber(d);
        }

        static void PrintNumber(int[] number)
        {
            string ToPrint = ""; 
            foreach (var item in number)
            {
                ToPrint = ToPrint + item;
            } 
            Console.WriteLine(ToPrint);
        }
    }
}
