using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Calculator.Console.Tests
{
    class CalculatorConsoleTests
    {
        [Test]
        public void CanCreate()
        {
            var unused = new CalculatorConsole(null);
        }

        [Test]
        public void Start_ShouldDisplayTheMenu()
        {
            var console = new FakeConsole();

            new CalculatorConsole(console).Start();

            Assert.That(console.GetDisplay(), Is.EqualTo(
                "Please select operation:+ (Adding)"));
        }

        private class FakeConsole : IConsole
        {
            private readonly List<string> _lines = new List<string>();

            public string GetDisplay()
            {
                string display = string.Empty;
                foreach (var line in _lines)
                {
                    display += line;
                }

                return display;
            }

            public void WriteLine(string line)
            {
                _lines.Add(line);
            }

            public string ReadLine()
            {
                return "x";
            }
        }
    }
}
