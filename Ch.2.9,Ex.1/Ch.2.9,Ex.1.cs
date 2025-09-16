using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace Ch._2._9_Ex._1
{
    public class GuessTheNumber
    {
        static void Main(string[] args)
        {
            int attempts = 0;
            Random rnd = new Random();
            int number = rnd.Next(1, 11);
            
            while (true)
            {
                int guess = GetGuess(attempts);
                attempts++;
                if (guess == number)
                {
                    MessageBox.Show($"You guessed the number {number} in {attempts} attempts!", "Congratulations!", MessageBoxButtons.OK);
                    break;
                }
                else
                {
                    DialogResult res = MessageBox.Show($"Wrong! Try again.", "Incorrect Guess", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand);
                    if (res == DialogResult.Cancel)
                    {
                        MessageBox.Show($"The number was {number}. You made {attempts} attempts.", "Game Over", MessageBoxButtons.OK);
                        break;
                    }
                }
            }
        }
        static int GetGuess(int attempts)
        {
            return int.Parse(Interaction.InputBox("A number between 1 and 10 was chosen. Guess which it is!", $"Attempts: {attempts}"));
        }
    }
}
