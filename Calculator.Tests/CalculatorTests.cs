using NUnit.Framework;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void DoNothing()
        {
            Assert.Pass();
        }
        
        [Test]
        public void AddingOneAndOneShouldReturnTwo()
        {
            var calculator = new Engine.Calculator();
            Assert.That(calculator.Add(1, 1), Is.EqualTo(2));
        }

        [Test]
        public void AddingMinusOneAndOneShouldReturnZero()
        {
            var calculator = new Engine.Calculator();
            Assert.That(calculator.Add(-1, 1), Is.EqualTo(0));
        }
    }
}