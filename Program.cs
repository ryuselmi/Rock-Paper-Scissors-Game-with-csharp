using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Random class to generate random numbers for the computer's choice
            Random random = new Random();

            // A boolean to control the loop that allows the player to play multiple rounds
            bool playAgain = true;

            // Strings to store the player's choice, the computer's choice, and the player's response to continue playing
            string player;
            string computer;
            string answer;

            // Main loop to allow the player to play the game multiple times
            while (playAgain)
            {
                // Initialize or reset the variables at the start of each round
                player = "";
                computer = "";
                answer = "";

                // Prompt the player to enter their choice, ensuring they only input "ROCK", "PAPER", or "SCISSORS"
                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.WriteLine("Enter ROCK, PAPER, or SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper(); // Convert the player's input to uppercase to standardize input
                }

                // Randomly select the computer's choice using a random number between 1 and 3
                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK"; // If the random number is 1, computer chooses "ROCK"
                        break;
                    case 2:
                        computer = "PAPER"; // If the random number is 2, computer chooses "PAPER"
                        break;
                    case 3:
                        computer = "SCISSORS"; // If the random number is 3, computer chooses "SCISSORS"
                        break;
                }

                // Display the player's and computer's choices
                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);

                // Determine the outcome of the game based on the player's choice and the computer's choice
                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("It's a draw!"); // If both choose ROCK, it's a draw
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You lose!"); // ROCK loses to PAPER
                        }
                        else
                        {
                            Console.WriteLine("You win!"); // ROCK beats SCISSORS
                        }
                        break;
                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You win!"); // PAPER beats ROCK
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("It's a draw!"); // If both choose PAPER, it's a draw
                        }
                        else
                        {
                            Console.WriteLine("You lose!"); // PAPER loses to SCISSORS
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You lose!"); // SCISSORS loses to ROCK
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You win!"); // SCISSORS beats PAPER
                        }
                        else
                        {
                            Console.WriteLine("It's a draw!"); // If both choose SCISSORS, it's a draw
                        }
                        break;
                }

                // Ask the player if they want to play again
                Console.WriteLine("Would you like to play again? (Y/N)");
                answer = Console.ReadLine();
                answer = answer.ToUpper(); // Convert the answer to uppercase for easy comparison

                // Determine whether to continue the game based on the player's answer
                if (answer == "Y")
                {
                    playAgain = true; // If the player says "Y", keep playAgain true to continue the loop
                }
                else
                {
                    playAgain = false; // If the player says anything else, exit the loop
                }
            }

            // Display a farewell message once the player decides to stop playing
            Console.WriteLine("Thanks for playing");

            // Wait for the player to press a key before closing the console window
            Console.ReadKey();
        }
    }
}
