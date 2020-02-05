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

        [TestCase(15, 2, 2, 60)]
        [TestCase(20, 5, 5, 500)]
        [TestCase(50, 1, 5, 250)]
        public void Test_Clear_Multiply1(double a, double b, double c, double d)
        {
            uut.Clear();
            uut.Add1(a);
            uut.Multiply1(b);
            uut.Multiply1(c);

            Assert.That(uut.Accumulator, Is.EqualTo(d));
        }

        [TestCase(20, 2, 2, 5)]
        [TestCase(100, 5, 5, 4)]
        [TestCase(40, 4, 5, 2)]
        public void Test_Clear_Divide1(double a, double b, double c, double d)
        {
            uut.Clear();
            uut.Add1(a);
            uut.Divide1(b);
            uut.Divide1(c);

            Assert.That(uut.Accumulator, Is.EqualTo(d));
        }

        [TestCase(2, 2, 2, 16)]
        [TestCase(5, 3, 2, 15625)]
        [TestCase(4, 4, 1, 256)]
        [TestCase(2,2,-2,0.0625)]
        [TestCase(5,2,0,1)]
        public void Test_Clear_Power1(double a, double b, double c, double d)
        {
            uut.Clear();
            uut.Add1(a);
            uut.Power1(b);
            uut.Power1(c);

            Assert.That(uut.Accumulator, Is.EqualTo(d));
        }


        [Test]
        public void Test_Divide1_Exception()
        {

            uut.Clear();
            uut.Add1(10);

            Assert.Catch<Exception>(() => uut.Divide1(0));
        }
    }
}
