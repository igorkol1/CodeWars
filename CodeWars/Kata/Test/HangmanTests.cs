using CodeWars.Kata.Hangman_game;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata.Test
{
    [TestFixture]
    class HangmanTests
    {
        [Test]
        public void HangmanTest1()
        {
            Hangman hangman = new Hangman("codet");

            Assert.AreEqual("_ _ _ _ _ # w", hangman.Guess('w'));
            Assert.AreEqual("_ _ _ _ _ # wa", hangman.Guess('a'));
            Assert.AreEqual("_ _ _ _ _ # war", hangman.Guess('r'));
            Assert.AreEqual("_ _ _ _ _ # wars", hangman.Guess('s'));
            Assert.AreEqual("_ _ _ e _ # wars", hangman.Guess('e'));
            Assert.AreEqual("_ _ d e _ # wars", hangman.Guess('d'));
            Assert.AreEqual("_ o d e _ # wars", hangman.Guess('o'));
            Assert.AreEqual("c o d e _ # wars", hangman.Guess('c'));
            Assert.AreEqual("c o d e _ # warsx", hangman.Guess('x'));
            Assert.AreEqual("c o d e _ # warsxy", hangman.Guess('y'));
            Assert.AreEqual("You got hung! The word was codet.", hangman.Guess('z'));
        }

        [Test]
        public void HangmanTest2()
        {
            Hangman hangman = new Hangman("wars");

            Assert.AreEqual("w _ _ _", hangman.Guess('w'));
            Assert.AreEqual("w _ _ _ # u", hangman.Guess('u'));
            Assert.AreEqual("w _ _ s # u", hangman.Guess('s'));
            Assert.AreEqual("w a _ s # u", hangman.Guess('a'));
            Assert.AreEqual("You found the word! (wars)", hangman.Guess('r'));
            Assert.AreEqual("The game has ended.", hangman.Guess('g'));
        }

        [Test]
        public void HangmanTest3()
        {
            Hangman hangman = new Hangman("ababab");
       
            Assert.AreEqual("a _ a _ a _", hangman.Guess('a'));
            Assert.AreEqual("a _ a _ a _ # c", hangman.Guess('c'));
            Assert.AreEqual("You found the word! (ababab)", hangman.Guess('b'));
        }
        

    }
}
