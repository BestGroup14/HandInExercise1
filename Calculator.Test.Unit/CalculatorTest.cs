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

        [TestCase(10,5,15)]
        [TestCase(30,2,32)]
        [TestCase(200,43,243)]
        public void Test_Add(double a, double b, double c)
        {
            Assert.That(uut.Add(a,b),Is.EqualTo(c));
        }

        [TestCase(100,99,1)]
        [TestCase(20,3,17)]
        [TestCase(40,6,34)]
        public void Test_Subtract(double a,double b,double c)
        {
            Assert.That(uut.Subtract(a,b), Is.EqualTo(c));
        }

        [TestCase(2,10,20)]
        [TestCase(3,7,21)]
        [TestCase(4,3,12)]
        public void Test_Multiply(double a, double b, double c)
        {
            Assert.That(uut.Multiply(a, b), Is.EqualTo(c));
        }

        [TestCase(3,3,27)]
        [TestCase(2,2,4)]
        [TestCase(100,2,10000)]
        public void Test_Power(double a, double b, double c)
        {
            Assert.That(uut.Power(a, b), Is.EqualTo(c));
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
