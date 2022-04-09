using NUnit.Framework;
using System;
using TallerTechnologies.Challenge.Core;

namespace TallerTechnologies.Challenge.Test
{
    public class UTNumbers
    {
        private Numbers _numbers;

        [SetUp]
        public void Setup()
        {
            _numbers = new Numbers();
        }
 
        [Test]
        public void ConverToArray()
        {
            var a = _numbers.ConverToArray("1234567"); 
            Assert.AreEqual(typeof(int[]), a.GetType());  
        }

        [Test]
        public void MainExample()
        {
            int[] mockResult = { 7, 7, 7, 7, 7, 7 };

            var number1 = _numbers.ConverToArray("123456");
            var number2 = _numbers.ConverToArray("123456"); 
            var result = _numbers.Sum(number1, _numbers.Reverse(number2));
            
            Assert.AreEqual(result, mockResult);
        }

        [Test]
        public void NullValues()
        {

            try
            {
                int[] number1 = null;
                int[] number2 = null;
                _numbers.Sum(number1, number2);
                Assert.Fail();  
            }
            catch (Exception ex)
            {
                Assert.Pass();
            } 
        }
    }
}
