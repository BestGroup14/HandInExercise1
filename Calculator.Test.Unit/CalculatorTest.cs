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

        [TestCase(15,5,3)]
        [TestCase(100,5,20)]
        [TestCase(30,4,7.5)]
        [TestCase(10,0,0)]
        public void Test_Divide(double a, double b, double c)
        {
            Assert.That(uut.Divide(a, b), Is.EqualTo(c));
        }

        [TestCase(34,3,37)]
        [TestCase(12,7,19)]
        [TestCase(31,67,98)]
        public void Test_Accumulator_Add(double a, double b, double c)
        {
            uut.Add(a, b);

            Assert.That(uut.Accumulator, Is.EqualTo(c));
        }

        [TestCase(2,5,16,3,13)]
        [TestCase(20,41,33,6,27)]
        [TestCase(2,78,17,13,4)]
        public void Test_Accumulator_Add_Subtract(double a, double b, double c, double d, double e)
        {
            uut.Add(a, b);
            uut.Subtract(c, d);

            Assert.That(uut.Accumulator, Is.EqualTo(e));
        }

        [Test]
        public void Test_Accumulator_Add_Clear_zero()
        {
            //Arrange in Setup 

            //Act
            uut.Add(2, 3);
            uut.Clear();

            //Assert
            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }

        [Test]
        public void Test_Clear_Add1_7()
        {
            //Arrange in Setup 

            //Act
            uut.Clear();
            uut.Add1(3);
            uut.Add1(4);

            //Assert
            Assert.That(uut.Accumulator, Is.EqualTo(7));
        }

        [Test]
        public void Test_Clear_Add1_121()
        {
            //Arrange in Setup 

            //Act
            uut.Clear();
            uut.Add1(76);
            uut.Add1(45);

            //Assert
            Assert.That(uut.Accumulator, Is.EqualTo(121));
        }


        [Test]
        public void Test_Clear_Subtract1_12()
        {
            //Arrange in Setup 

            //Act
            uut.Clear();
            uut.Add1(19);
            uut.Subtract1(3);
            uut.Subtract1(4);

            //Assert
            Assert.That(uut.Accumulator, Is.EqualTo(12));
        }

        [Test]
        public void Test_Clear_Multiply1_380()
        {
            //Arrange in Setup 

            //Act
            uut.Clear();
            uut.Add1(19);
            uut.Multiply1(10);
            uut.Multiply1(2);

            //Assert
            Assert.That(uut.Accumulator, Is.EqualTo(380));
        }

        [Test]
        public void Test_Clear_Divide1_5()
        {
            //Arrange in Setup 

            //Act
            uut.Clear();
            uut.Add1(60);
            uut.Divide1(6);
            uut.Divide1(2);

            //Assert
            Assert.That(uut.Accumulator, Is.EqualTo(5));
        }

        [Test]
        public void Test_Clear_Power1_10000()
        {
            //Arrange in Setup 

            //Act
            uut.Clear();
            uut.Add1(10);
            uut.Power1(2);
            uut.Power1(2);

            //Assert
            Assert.That(uut.Accumulator, Is.EqualTo(10000));
        }

        [Test]
        public void Test_Clear_Power1_001()
        {
            //Arrange in Setup 

            //Act
            uut.Clear();
            uut.Add1(10);
            uut.Power1(-2);

            //Assert
            Assert.That(uut.Accumulator, Is.EqualTo(0.01));
        }

        [Test]
        public void Test_Clear_Power1_1()
        {
            //Arrange in Setup 

            //Act
            uut.Clear();
            uut.Add1(10);
            uut.Power1(0);

            //Assert
            Assert.That(uut.Accumulator, Is.EqualTo(1));
        }

        [Test]
        public void Test_Divide1_Exception()
        {
            //Arrange in Setup 

            //Act
            uut.Clear();
            uut.Add1(10);

            //Assert
            Assert.Catch<Exception>(() => uut.Divide1(0));
        }
    }
}
