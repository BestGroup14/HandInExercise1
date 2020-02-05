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

        [Test]
        public void Test_Divide_3()
        {
            //Arrange in Setup 

            //Act + Assert
            Assert.That(uut.Divide(15, 5), Is.EqualTo(3));
        }

        [Test]
        public void Test_Divider_0()
        {
            //Arrange in Setup 

            //Act + Assert
            Assert.That(uut.Divide(3, 0), Is.EqualTo(0));
        }

        [Test]
        public void Test_Accumulator_Add_5()
        {
            //Arrange in Setup 

            //Act
            uut.Add(2, 3);

            //Assert
            Assert.That(uut.Accumulator, Is.EqualTo(5));
        }

        [Test]
        public void Test_Accumulator_Add_Subtract_13()
        {
            //Arrange in Setup 

            //Act
            uut.Add(2, 3);
            uut.Subtract(20, 7);

            //Assert
            Assert.That(uut.Accumulator, Is.EqualTo(13));
        }

        [TestCase(2,3,0)]
        [TestCase(4,7,0)]
        [TestCase(10, 20, 0)]
        public void Test_Accumulator_Add_Clear_zero(double a, double b, double c)
        {
            //Arrange in Setup 

            //Act
            uut.Add(a, b);
            uut.Clear();

            //Assert
            Assert.That(uut.Accumulator, Is.EqualTo(c));
        }

        [TestCase(2, 3, 5)]
        [TestCase(7, 10, 17)]
        [TestCase(4, 2, 6)]
        public void Test_Clear_Add1(double a, double b, double c)
        {
            //Arrange in Setup 

            //Act
            uut.Clear();
            uut.Add1(a);
            uut.Add1(b);

            //Assert
            Assert.That(uut.Accumulator, Is.EqualTo(c));
        }


        [TestCase(15, 2, 2,11)]
        [TestCase(20, 5, 5,10)]
        [TestCase(50, 10, 5,35)]
        public void Test_Clear_Subtract1(double a, double b, double c, double d)
        {
            //Arrange in Setup 

            //Act
            uut.Clear();
            uut.Add1(a);
            uut.Subtract1(b);
            uut.Subtract1(c);

            //Assert
            Assert.That(uut.Accumulator, Is.EqualTo(d));
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
