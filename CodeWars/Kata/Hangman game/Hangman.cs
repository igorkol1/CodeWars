using System.Linq;

namespace CodeWars.Kata.Hangman_game
{
    public class Hangman
    {
        private string word;
        private char[] guessLetters;
        private string missedLetters = " # ";
        private int mistakes = 0;
        private bool gameEnded = false;

        public Hangman(string word)
        {
            this.word = word;

            InitAndFillEmptyGuessLettersArray();
        }

        public string Guess(char letter)
        {
            if (CheckIfLetterExistInWord(letter))
            {
                AddLetterToGuessLettersArray(letter);
            }else
            {
                AddLetterToMissedLetters(letter);
            }

            return ReturnGameState();
        }

        private void InitAndFillEmptyGuessLettersArray()
        {
            guessLetters = new char[word.Length];

            for(int i=0;i< word.Length; i++)
            {
                guessLetters[i] = '_';
            }
        }

        private string PrintGuessLettersArray()
        {
            string tempToPrint = "";

            foreach(char letter in guessLetters)
            {
                tempToPrint += letter+" ";
            }

            return tempToPrint.Remove(tempToPrint.Length-1,1);
        }

        private bool CheckIfLetterExistInWord(char letter)
        {
            return word.Contains(letter);
        }

        private void AddLetterToGuessLettersArray(char letter)
        {

            for(int i = 0; i < word.Length; i++)
            {
                if(word[i] == letter)
                {
                    guessLetters[i] = letter;
                }
            }

        }        

        private void AddLetterToMissedLetters(char letter)
        {
            if (!missedLetters.Contains(letter))
            {
                missedLetters += letter;
                mistakes++;
            }
        }

        private string GetMissedLetters()
        {
            if (mistakes > 0)
            {
                return missedLetters;
            }
            else
            {
                return null;
            }

        }

        private int CheckGameState()
        {
            int state = -2;

            if (IsWordGuessed())
            {
                if (!gameEnded)
                {
                    state = 1;
                    gameEnded = true;
                }else
                {
                    state = 2;
                }
                
            }
            else if (mistakes < 7)
            {
                state = 0;
            }
            else if(mistakes >=7)
            {
                if (!gameEnded)
                {
                    state = -1;
                    gameEnded = true;
                }
                else
                {
                    state = 2;
                }
            }
            return state;
        }

        private string ReturnGameState()
        {
            int state = CheckGameState();
            switch (state)
            {
                case -1:
                    return "You got hung! The word was " + word + ".";
                case 0:
                    return PrintGuessLettersArray() + GetMissedLetters();
                case 1:
                    return "You found the word! (" + word + ")";
                case 2:
                    return "The game has ended.";
                default:
                    return "Error"; 
            }
        }

        private bool IsWordGuessed()
        {
            bool status = true;

            foreach(char letter in guessLetters)
            {
                if (letter.Equals('_'))
                {
                    status = false;
                    break;
                }
            }
            return status;
        }
    }
}
