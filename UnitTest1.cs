using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using testcase_challenge;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            int a= 2147483647;
            int b = 2147483647;
            long  expected =4294967294;

            //act
            long actual = Program.call_sum(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //arrange
            int a = 2147483647;
            int b = 2147483647;
            long expected = 0;

            //act
            long actual = Program.call_diff(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //arrange
            int a = 2147483647;
            int b = 2;
            long expected =4294967294;

            //act
            long actual = Program.call_product(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //arrange
            int a = 0;
            int b = 2147483647;
            long expected =2147483647 ;

            //act
            long actual = Program.call_diff(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Testmethod6()
        {
            //arrange
            int a = 2147483647;
            int b = 2;
            double expected = 4.611686E18;

            //act
            double actual = Program.call_power1(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Testmethod7()
        {
            //arrange
            int a = 0;
            int b = 0;
            long expected = 1;

            //act
            double actual = Program.call_power1(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Testmethod8()
        {
            //arrange
            int a = 10000;
            int b = 100;
            long expected =0;

            //act
            long actual = Program.call_power_2(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Testmethod9()
        {
            //arrange
            int a = 10;
            int b = 0;
            int c = 12;
            string expected = "Cant be negative value or zero";

            //act
            string actual = Program.call_volue_of_tank(a, b,c);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Testmethod10()
        {
            //arrange
            int a = 1000;
            int b = 1092;
            int c = 12;
            string expected = "13104000";

            //act
            string actual = Program.call_volue_of_tank(a, b, c);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Testmethod11()
        {
            //arrange
            int a = -1000;
            int b = 1092;
            int c = 12;
            string expected = "Cant be negative value or zero";

            //act
            string actual = Program.call_volue_of_tank(a, b, c);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Testmethod12()
        {
            //arrange
            double  a = 1000.23;
            double  b = 1092;
            double  c = 12.23;
            string expected = "13358231.6868";

            //act
            string actual = Program.call_volue_of_tank(a, b, c);
            //assert
            Assert.AreEqual(expected, actual);
        }





    }
}
