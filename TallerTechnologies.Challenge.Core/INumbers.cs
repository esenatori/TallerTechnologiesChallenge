using System;
using System.Collections.Generic;

namespace TallerTechnologies.Challenge.Core
{
    public interface INumbers
    {
        public int[] ConverToArray(string numbers);
        public void Reverse(ref int[] numbers);
        public int[] Sum(int[] numbers1, int[] numbers2);
    }
}
