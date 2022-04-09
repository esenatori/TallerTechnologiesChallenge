using NUnit.Framework;
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
        public void FirstExample()
        {
            int[] mockResult = { 7, 7, 7, 7, 7, 7 };

            var number1 = _numbers.ConverToArray("123456");
            var number2 = _numbers.ConverToArray("123456"); 
            var result = _numbers.Sum(number1, _numbers.Reverse(number2));
            
            Assert.AreEqual(result, mockResult);
        }
    }
}
