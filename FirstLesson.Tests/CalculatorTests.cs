using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FluentAssertions; 


namespace FirstLesson.Tests
{
   [TestFixture]
    public class CalculatorTests
    {
       [TestCase(1, 6, 7)]
       [TestCase(2, 2, 4)]
       [TestCase(5, 1, 6)]
        public void Add_ReturnsSum(double x, double y, double expected)
       {
            Calculator calculator = new Calculator();
            
            double actual = calculator.Add(x, y);

            actual.Should().Be(expected);
       }

    }

}
