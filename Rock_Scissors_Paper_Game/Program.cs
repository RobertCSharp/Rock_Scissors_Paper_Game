using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Scissors_Paper_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayGame();
        }

        static void PlayGame()
        {
            Random rnd = new Random();
            List<char> choiceList = new List<char>() { 'R', 'S', 'P' };
            int computerScore = 0;
            int playerScore = 0;

            while (computerScore < 5 && playerScore < 5)
            {
                char computerChoice = choiceList[rnd.Next(choiceList.Count)];
                Console.WriteLine("\nChoose a letter: R -> Rock / S -> Scissors / P -> Paper");
                char playerChoose = char.Parse(Console.ReadLine());
                playerChoose = char.ToUpper(playerChoose);

                if (computerChoice == 'S' && playerChoose == 'S')
                {
                    Console.WriteLine("You choose Scissors");
                    Console.WriteLine("The computer choice Scissors");
                    Console.WriteLine("draw");
                }
                else if (computerChoice == 'R' && playerChoose == 'R')
                {
                    Console.WriteLine("You choose Rock");
                    Console.WriteLine("The computer choice Rock");
                    Console.WriteLine("draw");
                }
                else if (computerChoice == 'P' && playerChoose == 'P')
                {
                    Console.WriteLine("You choose Paper");
                    Console.WriteLine("The computer choice Paper");
                    Console.WriteLine("draw");
                }
                else if (computerChoice == 'S' && playerChoose == 'R')
                {
                    Console.WriteLine("You choose Rock");
                    Console.WriteLine("The computer choose Scissors");
                    Console.WriteLine("you won");
                    playerScore++;
                    Console.WriteLine($"Computer: {computerScore} - player: {playerScore}");
                }
                else if (computerChoice == 'P' && playerChoose == 'S')
                {
                    Console.WriteLine("You choose Scissors");
                    Console.WriteLine("The computer choose Paper");
                    Console.WriteLine("you won");
                    playerScore++;
                    Console.WriteLine($"Computer: {computerScore} - player: {playerScore}");

                }
                else if (computerChoice == 'S' && playerChoose == 'R')
                {
                    Console.WriteLine("You choose Rock");
                    Console.WriteLine("The computer choose Scissors");
                    Console.WriteLine("you won");
                    playerScore++;
                    Console.WriteLine($"Computer: {computerScore} - player: {playerScore}");

                }
                else if (computerChoice == 'S' && playerChoose == 'P')
                {
                    Console.WriteLine("You choose Paper");
                    Console.WriteLine("The computer choose Scissors");
                    Console.WriteLine("you lose");
                    computerScore++;
                    Console.WriteLine($"Computer: {computerScore} - player: {playerScore}");
                }
                else if (computerChoice == 'P' && playerChoose == 'R')
                {
                    Console.WriteLine("You choose Rock");
                    Console.WriteLine("The computer choose Paper");
                    Console.WriteLine("you lose");
                    computerScore++;
                    Console.WriteLine($"Computer: {computerScore} - player: {playerScore}");
                }
                else if (computerChoice == 'R' && playerChoose == 'S')
                {
                    Console.WriteLine("You choose Scissors");
                    Console.WriteLine("The computer choose Rock");
                    Console.WriteLine("you lose");
                    computerScore++;
                    Console.WriteLine($"Computer: {computerScore} - player: {playerScore}");

                }
            }
        }
    }
}
