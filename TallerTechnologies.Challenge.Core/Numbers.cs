using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerTechnologies.Challenge.Core
{
    public class Numbers : INumbers
    {
        public int[] ConverToArray(string numbers)
        {
            var a = numbers.ToCharArray();
            int[] b = new int[a.Length];
            b = Array.ConvertAll(a, c => (int)Char.GetNumericValue(c));
            return b;
        }

        public int[] Reverse(int[] numbers)
        {
            Array.Reverse(numbers); 
            return numbers;
        }

        public int[] Sum(int[] numbers1, int[] numbers2)
        {
            int lenght = numbers2.Length;
            if (numbers1.Length > numbers2.Length)
            {
                lenght = numbers1.Length;
            }

            int[] _result = new int[lenght];

            for (int i = 0; i < lenght; i++)
            {
                var firstnumber = 0;
                var secondnumber = 0;

                if (numbers1.Length > i)
                    firstnumber = int.Parse(numbers1[i].ToString());

                if (numbers2.Length > i)
                    secondnumber = int.Parse(numbers2[i].ToString());

                _result[i] = firstnumber + secondnumber;
            }

            return _result;
        }
    }
}
