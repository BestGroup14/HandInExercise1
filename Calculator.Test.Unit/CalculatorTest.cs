using System;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorTest
    {
        private Calc uut;

        [SetUp]
        public void SetUp()
        {
            uut = new Calc();
        }

        [Test]
        public void Test_Add_91()
        {
            //Arrange in Setup 

            //Act + Assert
            Assert.That(uut.Add(24,67),Is.EqualTo(91));
        }

        [Test]
        public void Test_Subtract_55()
        {
            //Arrange in Setup 

            //Act + Assert
            Assert.That(uut.Subtract(100,45), Is.EqualTo(55));
        }

        [Test]
        public void Test_Multiply_120()
        {
            //Arrange in Setup 

            //Act + Assert
            Assert.That(uut.Multiply(20, 6), Is.EqualTo(120));
        }

        [Test]
        public void Test_Power_27()
        {
            //Arrange in Setup 

            //Act + Assert
            Assert.That(uut.Power(3, 3), Is.EqualTo(27));
        }
    }
}
