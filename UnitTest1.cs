using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using rock_S;

namespace rpstestcase
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void winner_msg_1()
        {
            choice user =choice.Rock;
            choice  ai = choice.Rock;
            string expected = "same choice.what a coincidence.";
            string actual = Program.getwinningmessage(user, ai);
            Assert.AreEqual(expected, actual);


        }
        [TestMethod]
        public void winner_msg_2()
        {
            choice user = choice.Rock;
            choice ai = choice.paper;
            string expected = "paper cover Rock.sopaper wins.";
            string actual = Program.getwinningmessage(user, ai);
            Assert.AreEqual(expected, actual);


        }
        [TestMethod]
        public void winner_msg_3()
        {
            choice user = choice.paper;
            choice ai = choice.Rock;
            string expected = "paper covers Rock.so paper wins.";
            string actual = Program.getwinningmessage(user, ai);
            Assert.AreEqual(expected, actual);


        }
        [TestMethod]
        public void winner_msg_4()
        {
            choice user = choice.Rock;
            choice ai = choice.Scissors;
            string expected = "Rock breaks Scissors.so Rock wins.";
            string actual = Program.getwinningmessage(user, ai);
            Assert.AreEqual(expected, actual);


        }
        [TestMethod]
        public void winner_msg_5()
        {
            choice user = choice.Scissors;
            choice ai = choice.paper;
            string expected = "paper cuts Scissors.so paper wins.";
            string actual = Program.getwinningmessage(user,ai);
            Assert.AreEqual(expected, actual);


        }
        [TestMethod]
        public void winner_msg_6()
        {
            choice user = choice.Scissors;
            choice ai = choice.Scissors;
            string expected = "same choice.what a coincidence.";
            string actual = Program.getwinningmessage(user, ai);
            Assert.AreEqual(expected, actual);


        }
        [TestMethod]
        public void winner_msg_7()
        {
            choice user = choice.paper;
            choice ai = choice.Scissors;
            string expected = "Scissors cuts paper.soScissors wins.";
            string actual = Program.getwinningmessage(user, ai);
            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void Ai_input()
        {
            int i = 0;
            while (i != 1000)
            {

                choice a = (choice)Program.getAIinput();
                if (a != choice.paper || a != choice.Rock || a != choice.Scissors)
                {
                    Console.WriteLine("Worng choice other than rps");
                }
                else
                {
                    Console.WriteLine("ok");
                }
                i++;
            }







        }

        [TestMethod]
        public void get_winner_1()
        {
            choice a = choice.paper;
            choice b = choice.paper;
            winningstate actual = Program.getwinner(a,b);
            winningstate expected = winningstate.draw;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void get_winner_2()
        {
            choice a = choice.Rock;
            choice b = choice.paper;
            winningstate actual = Program.getwinner(a, b);
            winningstate expected = winningstate.AIwins;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void get_winner_3()
        {
            choice a = choice.Scissors;
            choice b = choice.paper;
            winningstate actual = Program.getwinner(a, b);
            winningstate expected = winningstate.userwins;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void get_winner_4()
        {
            choice a = choice.paper;
            choice b = choice.Scissors;
            winningstate actual = Program.getwinner(a, b);
            winningstate expected = winningstate.AIwins;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void get_winner_5()
        {
            choice a = choice.Rock;
            choice b = choice.Scissors;
            winningstate actual = Program.getwinner(a, b);
            winningstate expected = winningstate.userwins;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void get_winner_6()
        {
            choice a = choice.Scissors;
            choice b = choice.Rock;
            winningstate actual = Program.getwinner(a, b);
            winningstate expected = winningstate.AIwins;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void get_winner_7()
        {
            choice a = choice.paper;
            choice b = choice.Rock;
            winningstate actual = Program.getwinner(a, b);
            winningstate expected = winningstate.userwins;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void get_winner_8()
        {
            choice a = choice.Rock;
            choice b = choice.Rock;
            winningstate actual = Program.getwinner(a, b);
            winningstate expected = winningstate.draw;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void get_winner_9()
        {
            choice a = choice.Scissors;
            choice b = choice.Scissors;
            winningstate actual = Program.getwinner(a, b);
            winningstate expected = winningstate.draw;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void game_result_display_1()
        {

        }




          
        
       
    }
  
}
