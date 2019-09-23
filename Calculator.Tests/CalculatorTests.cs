using NUnit.Framework;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        Engine.Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Engine.Calculator();
        }

        [Test]
        public void AddingZeroWithZeroShouldReturnZero()
        {
            Assert.That(calculator.Sum(0, 0), Is.EqualTo(0));
        }

        [Test]
        public void AddingMaxIntWithMaxIntShouldThrowException()
        {
            Assert.Throws<Engine.Calculator.ResultOutOfBound>(
                () => calculator.Sum(int.MaxValue, int.MaxValue));
        }

        [Test]
        public void AddingTwoNubersSumOfWhichExceedsMaxOrMinIntShouldThrowException()
        {
            Assert.Throws<Engine.Calculator.ResultOutOfBound>(
                () => calculator.Sum(1500000000, 1500000000));
        }

        [Test]
        public void AddingMinIntWithMinIntShouldThrowException()
        {
            Assert.Throws<Engine.Calculator.ResultOutOfBound>(
                () => calculator.Sum(int.MinValue, int.MinValue));
        }

        [Test]
        public void AddingOneAndOneShouldReturnTwo()
        {
            Assert.That(calculator.Sum(1, 1), Is.EqualTo(2));
        }

        [Test]
        public void AddingMinusOneAndOneShouldReturnZero()
        {
            Assert.That(calculator.Sum(-1, 1), Is.EqualTo(0));
        }
    }
}