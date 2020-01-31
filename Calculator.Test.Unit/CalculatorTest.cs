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

        [Test]
        public void Test_Accumulator_Add_Subtract_0()
        {
            //Arrange in Setup 

            //Act
            uut.Add(2, 3);
            uut.Subtract(5, 7);

            //Assert
            Assert.That(uut.Accumulator, Is.EqualTo(0));
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
    }
}
