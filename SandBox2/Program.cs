using System;

namespace SandBox2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            String gsPlayer;
            String gsComputer;
            String answer;

            while (playAgain)
            {
                gsPlayer = "";
                gsComputer = "";
                answer = "";

                while (gsPlayer != "ROCK" && gsPlayer != "PAPER" && gsPlayer != "SCISSORS")
                {
                    Console.WriteLine("Enter ROCK / PAPER / SCISSORS");
                    gsPlayer = Console.ReadLine();
                    gsPlayer = gsPlayer.ToUpper();
                }


                switch (random.Next(1, 4))
                {
                    case 1:
                        gsComputer = "ROCK";
                        break;
                    case 2:
                        gsComputer = "PAPER";
                        break;
                    case 3:
                        gsComputer = "SCISSORS";
                        break;
                }
                Console.WriteLine("player : " + gsPlayer);
                Console.WriteLine("computer : " + gsComputer);

                switch (gsPlayer)
                {
                    case "ROCK":
                        if (gsComputer == "ROCK")
                        {
                            Console.WriteLine("It's a draw ! ");
                        }else if (gsComputer == "PAPER")
                        {
                            Console.WriteLine("You Lose ! ");
                        } else
                        {
                            Console.WriteLine("You Win !");
                        }
                        break;
                    case "PAPER":
                        if (gsComputer == "PAPER")
                        {
                            Console.WriteLine("It's a draw ! ");
                        }
                        else if (gsComputer == "SCISSORS")
                        {
                            Console.WriteLine("You Lose ! ");
                        }
                        else
                        {
                            Console.WriteLine("You Win !");
                        }
                        break;
                    case "SCISSORS":
                        if (gsComputer == "SCISSORS")
                        {
                            Console.WriteLine("It's a draw ! ");
                        }
                        else if (gsComputer == "ROCK")
                        {
                            Console.WriteLine("You Lose ! ");
                        }
                        else
                        {
                            Console.WriteLine("You Win !");
                        }
                        break;
                }

                Console.Write("Would you like to play again ? Y / N ? ");
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                if ( answer == "Y")
                {
                    playAgain = true;
                } else
                {
                    playAgain = false; 
                }
            }
            Console.WriteLine("Thanks for playing ! ");
            Console.ReadKey();
        }
    }
}
