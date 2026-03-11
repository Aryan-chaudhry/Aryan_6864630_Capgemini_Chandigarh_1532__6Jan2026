using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using NUnit.Framework;

namespace CalculatorTesting
{
    [TestFixture]
    internal class CalculatorTest
    {
        private Calculators calc;

        [SetUp]

        public void SetUp()
        {
            calc = new Calculators();
        }
        
    }
}
