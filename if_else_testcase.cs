using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using if_else_testcase;

namespace if_else_testcase_16__20
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void vowel_1()
        {
            char x = 'A';
            string act = "Vowel";
            string expected = Program.vowel_const(x);

            Assert.AreEqual(expected, act);

        }
        [TestMethod]
        public void vowel_2()
        {
            char x = 'e';

            string act = "Vowel";
            string expected = Program.vowel_const(x);

            Assert.AreEqual(expected, act);

        }
        [TestMethod]
        public void vowel_3()
        {
            char x = '#';

            string act = "0";
            string expected = Program.vowel_const(x);

            Assert.AreEqual(expected, act);

        }
        [TestMethod]
        public void vowel_4()
        {
            char x = '9';

            string act = "0";
            string expected = Program.vowel_const(x);

            Assert.AreEqual(expected, act);

        }
        [TestMethod]
        public void vowel_5()
        {
            char x = '~';

            string act = "0";
            string expected = Program.vowel_const(x);

            Assert.AreEqual(expected, act);

        }

        [TestMethod]
        public void shapes_1()
        {
            int  x = 20;

            string act ="0";
            string expected = Program.shapes_name(x) ;

            Assert.AreEqual(expected, act);

        }
        [TestMethod]
        public void shapes_2()
        {
            int x = int.MaxValue;

            string act = "0";
            string expected = Program.shapes_name(x);

            Assert.AreEqual(expected, act);

        }
        [TestMethod]
        public void shapes_3()
        {
            int x =-2931;

            string act = "0";
            string expected = Program.shapes_name(x);

            Assert.AreEqual(expected, act);

        }
        [TestMethod]
        public void shapes_4()
        {
            int x = 0;

            string act = "0";
            string expected = Program.shapes_name(x);

            Assert.AreEqual(expected, act);

        }
        [TestMethod]
        public void shapes_5()
        {
            int x = 10;

            string act = "decagon";
            string expected = Program.shapes_name(x);

            Assert.AreEqual(expected, act);

        }
        [TestMethod]
        public void shapes_6()
        {
            int x = 2;

            string act = "0";
            string expected = Program.shapes_name(x);

            Assert.AreEqual(expected, act);

        }

        [TestMethod]
        public void name_of_month_1()
        {
            string x="January";

            int  act = 31;
            int  expected = Program.num_of_days(x);

            Assert.AreEqual(expected, act);

        }
        [TestMethod]
        public void name_of_month_2()
        {
            string x = "andal";

            int act = 0;
            int expected = Program.num_of_days(x);

            Assert.AreEqual(expected, act);

        }

        [TestMethod]
        public void name_of_month_3()
        {
            string x = "1234";

            int act = 0;
            int expected = Program.num_of_days(x);

            Assert.AreEqual(expected, act);

        }

        [TestMethod]
        public void name_of_month_4()
        {
            string x = "February";

            int act = 28;
            int expected = Program.num_of_days(x);

            Assert.AreEqual(expected, act);

        }
        [TestMethod]
        public void name_of_month_5()
        {
            string x = "@wrwdk.";

            int act = 0;
            int expected = Program.num_of_days(x);

            Assert.AreEqual(expected, act);

        }

        [TestMethod]
        public void days_of_week_1()
        {
            int  x = int.MaxValue;

            string act = "0";
            string expected = Program.day_of_week_new(x);

            Assert.AreEqual(expected, act);

        }
        [TestMethod]
        public void days_of_week_2()
        {
            int x = 32;

            string act = "0";
            string expected = Program.day_of_week_new(x);

            Assert.AreEqual(expected, act);

        }
        [TestMethod]
        public void days_of_week_3()
        {
            int x = 30;

            string act = "Tuesday";
            string expected = Program.day_of_week_new(x);

            Assert.AreEqual(expected, act);

        }
        [TestMethod]
        public void days_of_week_4()
        {
            int x = 0;

            string act = "0";
            string expected = Program.day_of_week_new(x);

            Assert.AreEqual(expected, act);

        }
        [TestMethod]
        public void days_of_week_5()
        {
            int x = -1;

            string act = "0";
            string expected = Program.day_of_week_new(x);

            Assert.AreEqual(expected, act);

        }
        [TestMethod]
        public void days_of_week_6()
        {
            int x =int.MinValue;

            string act = "0";
            string expected = Program.day_of_week_new(x);

            Assert.AreEqual(expected, act);

        }
        [TestMethod]
        public void name_of_tri_1()
        {
            double s1 = 90;
            double s2 = 90;
            double s3 = 0;
            string expected = Program.name_of_triangle(s1, s2, s3);
            string actual = "0";
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void name_of_tri_2()
        {
            double s1 = 600000;
            double s2 = int.MaxValue;
            double s3 = 60;
            string expected = Program.name_of_triangle(s1, s2, s3);
            string actual = "0";
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void name_of_tri_3()
        {
            double s1 = 400;
            double s2 = 60;
            double s3 = 80;
            string expected = Program.name_of_triangle(s1, s2, s3);
            string actual = "0";
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void name_of_tri_4()
        {
            double s1 = 59.5;
            double s2 = 100;
            double s3 = 20.5;
            string expected = Program.name_of_triangle(s1, s2, s3);
            string actual = "scalene";
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void name_of_tri_5()
        {
            double s1 = -59.5;
            double s2 = -100;
            double s3 = -20.5;
            string expected = Program.name_of_triangle(s1, s2, s3);
            string actual = "0";
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void name_of_tri_6()
        {
            double s1 = 0.0;
            double s2 = 0.0;
            double s3 = 180;
            string expected = Program.name_of_triangle(s1, s2, s3);
            string actual = "0";
            Assert.AreEqual(expected, actual);

        }









    }
}
