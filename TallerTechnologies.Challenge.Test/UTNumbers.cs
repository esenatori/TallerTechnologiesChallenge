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
        public void ConverToArray()
        {
            var a = _numbers.ConverToArray("1234567");
            Assert.AreEqual(typeof(int[]), a.GetType());
        }
    }
}
