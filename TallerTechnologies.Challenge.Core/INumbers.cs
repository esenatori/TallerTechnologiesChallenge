using System;
using System.Collections.Generic;

namespace TallerTechnologies.Challenge.Core
{
    public interface INumbers
    {
        public char[] ConverToArray(string numbers);
        public char[] Reverse(char[] numbers);
        public char[] Sum(char[] numbers1, char[] numbers2);
    }
}
