using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using testcase_challenge;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void sum_test_1()
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
        public void sum_test_2()
        {
            //arrange
            int a = -2147483647;
            int b = -2147483647;
            long expected = -4294967294;

            //act
            long actual = Program.call_sum(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void diff_test_1()
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
        public void diff_test_2()
        {
            //arrange
            int a = int.MinValue;
            int b = int.MaxValue;
            long expected =- 4294967295;

            //act
            long actual = Program.call_diff(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void product_test_1()
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
        public void diff_test_3()
        {
            //arrange
            int a = 0;
            int b = 2147483647;
            long expected =-2147483647 ;

            //act
            long actual = Program.call_diff(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void diff_test_4()
        {
            //arrange
            int a = -2147483648;
            int b = 2147483647;
            long expected = -4294967295;

            //act
            long actual = Program.call_diff(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void power_test_1()
        {
            //arrange
            int a = 2147483647;
            int b = 2;
            double expected = 4.6116860141324206E+18;

            //act
            double actual = Program.call_power1(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void power_test_2()
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
        public void power_test_3()
        {
            //arrange
            int a = 0;
            int b = 1;
            long expected = 0;

            //act
            double actual = Program.call_power1(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void power_test_4()
        {
            //arrange
            int a = 10000;
            int b = 10;
            long expected =0;

            //act
            double actual = Program.call_power_2(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void vol_of_tank_1()
        {
            //arrange
            int a = 10;
            int b = 0;
            int c = 12;
            string expected = "0";

            //act
            string actual = Program.call_volue_of_tank(a, b,c);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void vol_of_tank_2()
        {
            //arrange
            int a = int.MaxValue;
            int b = 100;
            int c = 12;
            string expected ="2576980376400";

            //act
            string actual = Program.call_volue_of_tank(a, b, c);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void vol_of_tank_3()
        {
            //arrange
            int a = -1000;
            int b = 1092;
            int c = 12;
            string expected = "0";

            //act
            string actual = Program.call_volue_of_tank(a, b, c);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void vol_of_tank_4()
        {
            //arrange
            double  a =10.23;
            double  b = 1092;
            double  c = 12.23;
            string expected = "136623.2868";

            //act
            string actual = Program.call_volue_of_tank(a, b, c);
            
            
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void height_1()
        {
            double height = 162.3;
            double act = 5.2626;
           double expected = Program.call_height(height);
           double expect= System.Math.Round(expected, 4);

            Assert.AreEqual(expect,act);
        }
        [TestMethod]
        public void height_2()
        {
            double height = 162.3;
            double act = 63.8976;
            double expected = Program.call_height1(height);
            double expect = (double)System.Math.Round(expected,4);
           
            Assert.AreEqual(expect, act);
        }
        [TestMethod]
        public void height_3()
        {
            double height = 2938;
            double act = 0;
            double expected = Program.call_height1(height);
            

            Assert.AreEqual(expected, act);
        }
        [TestMethod]
        public void bmi_1()
        {
            double height = 0;
            double weight = 0;
            double act = 0;
            double expected = Program.call_BMI(height, weight);
            Assert.AreEqual(expected, act);
        }
        [TestMethod]
        public void bmi_2()
        {
            double height = 1.79;
            double weight = 70;
            double act = 21.8;
            double expected = Program.call_BMI(height, weight);
            double expect = System.Math.Round(expected, 1);
            Assert.AreEqual(expect, act);
        }
        [TestMethod]
        public void bmi_3()
        {
            double height = 3.25893758;
            double weight = 387398;
            double act = 0;
            double expected = Program.call_BMI(height, weight);
            double expect = System.Math.Round(expected, 1);
            Assert.AreEqual(expect, act);
        }
        [TestMethod]
        public void bmi_4()
        {
            double height = 3.25;
            double weight = 10;
            double act = 0.9;
            double expected = Program.call_BMI(height, weight);
            double expect = System.Math.Round(expected, 1);
            Assert.AreEqual(expect, act);
        }
        [TestMethod]
        public void avera_1()
        {
            double n1 = 2536;
            double n2 = 0;
            double n3 = 2928;
            double expect = Program.call_total(n1, n2, n3);
            double act = 5464;
            Assert.AreEqual(expect, act);
        }
       
        [TestMethod]
        public void avera_3()
        {
            double n1 = 0;
            double n2 = 0;
            double n3 = 2928;
            double expect = Program.call_total_1(n1, n2, n3);
            double act = 2928;
            Assert.AreEqual(expect, act);
        }
        [TestMethod]
        public void avera_4()
        {
            double n1 = 0;
            double n2 = 0;
            double n3 = -1;
            double expect = Program.call_total_1(n1, n2, n3);
            double act = 0;
            Assert.AreEqual(expect, act);
        }
        [TestMethod]
        public void total_1()
        {
            double n1 = 100000000;
            double n2 = 1000000000000000;
            double n3 = 125628;
            long expect = Program.call_total(n1, n2, n3);
            long act = 1000000100125628;
            Assert.AreEqual(expect, act);
        }













    }
}
