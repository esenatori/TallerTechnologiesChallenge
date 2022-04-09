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
            b= Array.ConvertAll(a, c=> (int)Char.GetNumericValue(c));
            return b; 
        }

        public void Reverse(ref int[] numbers)
        {
            Array.Reverse(numbers); 
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
                _result[i] = int.Parse(numbers1[i].ToString()) + int.Parse(numbers2[i].ToString());
            }    

            return _result;
        }
    }
}
