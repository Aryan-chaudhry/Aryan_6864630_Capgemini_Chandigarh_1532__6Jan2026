using System;
using System.Collections.Generic;
using System.Text;
using Calculator;
using NUnit.Framework;

namespace TestProject1.Test
{
    internal class CalculatorTesting
    {
        private Calculators calc;

        [SetUp]

        public void SetUp()
        {
            calc = new Calculators();
        }

        [Test]

        public void Add_Two_Number()
        {
            // Arrange
            int a = 5, b = 3;

            // Act
            int result = calc.Add(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(8));
        }

		public void Sub_Two_Number()
		{
			// Arrange
			int a = 5, b = 3;

			// Act
			int result = calc.Sub(a, b);

			// Assert
			Assert.That(result, Is.EqualTo(2));
		}

		public void Mul_Two_Number()
		{
			// Arrange
			int a = 5, b = 3;

			// Act
			int result = calc.Mul(a, b);

			// Assert
			Assert.That(result, Is.EqualTo(15));
		}

		public void Div_Two_Number()
		{
			// Arrange
			int a = 4, b = 2;

			// Act
			double result = calc.Div(a, b);

			// Assert
			Assert.That(result, Is.EqualTo(2));
		}
	}
}
