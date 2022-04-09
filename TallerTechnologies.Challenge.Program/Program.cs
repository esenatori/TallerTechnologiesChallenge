using System;
using TallerTechnologies.Challenge.Core;

namespace TallerTechnologies.Challenge.Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Numbers _numbers = new Numbers(); 

            var number1 = _numbers.ConverToArray(Console.ReadLine());
            var number2 = _numbers.ConverToArray(Console.ReadLine());
             
            var result = _numbers.Sum(number1, _numbers.Reverse(number2));

            Console.WriteLine(_numbers.ArrayToString(result));
        } 
    }
}
