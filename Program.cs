using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepPlaying = true;
            Console.WriteLine("Choose Rock, Paper, Scissors");
            while (keepPlaying) {
            string userChoice = Console.ReadLine();
            Random random = new Random();
            int computerChoice = random.Next(3);
            if (computerChoice == 1)
            {
                if (userChoice == "rock")
                 {
                    Console.WriteLine(@"
                        _______
                    ---'   ____)
                         (_____)
                         (_____)
                         (____)
                   ---.__(___)
                    The Computer Chose Rock");
                    Console.WriteLine("Tie!");
                 }
                else if (userChoice == "paper")
                 {
                    Console.WriteLine(@"
                        _______
                    ---'    ____)____
                                ______)
                                _______)
                               _______)
                      ---.__________)
                    The Computer Chose Paper");
                    Console.WriteLine("Tie!");
                 }
                else if (userChoice == "scissors")
                 {
                    Console.WriteLine(@"
                              _______
                          ---'   ____)____
                                    ______)
                                __________)
                               (____)
                        ---.__(___)
                    The Computer Chose Scissors");
                    Console.WriteLine("Tie!");
                    }
                 else
                 {
                        Console.WriteLine("Please Choose Rock, Paper, Scissors");
                    }
                }
                else if (computerChoice == 2)
                {
                    if (userChoice == "rock")
                    {
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine(@"
                        _______
                    ---'   ____)
                         (_____)
                         (_____)
                         (____)
                   ---.__(___)
                        Sorry you lose,paper beat rock");

                    }
                    else if (userChoice == "paper")
                    {
                        Console.WriteLine("The computer chose scissors");
                        Console.WriteLine(@"
                        _______
                    ---'    ____)____
                                ______)
                                _______)
                               _______)
                      ---.__________)
                            Sorry you lose,scissors beat paper ");

                    }
                    else if (userChoice == "scissors")
                    {
                        Console.WriteLine("The computer chose rock");
                        Console.WriteLine(@"
                              _______
                          ---'   ____)____
                                    ______)
                                __________)
                               (____)
                        ---.__(___)
                        Sorry you lose,rock beats scissors");                       
                    }
                    else
                    {
                        Console.WriteLine("You must choose rock,paper or scissors!");        
                    }
                }
            else if (computerChoice == 3)
                {
                    if (userChoice == "rock")
                    {
                        Console.WriteLine("The computer chose scissors");
                        Console.WriteLine(@"
                        _______
                    ---'   ____)
                         (_____)
                         (_____)
                         (____)
                   ---.__(___)
                            You win,rock beats scissors");

                    }
                    else if (userChoice == "paper")
                    {
                        Console.WriteLine("The computer chose rock");
                        Console.WriteLine(@"
                        _______
                    ---'    ____)____
                                ______)
                                _______)
                               _______)
                      ---.__________)
                        You win,paper beats rock");

                    }
                    else if (userChoice == "scissors")
                    {
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine(@"
                              _______
                          ---'   ____)____
                                    ______)
                                __________)
                               (____)
                        ---.__(___)
                        You win,scissors beat paper");

                    }
                    else
                    {
                        Console.WriteLine("You must choose rock,paper or scissors!");

                    }

                }
                 Console.WriteLine("New game? Y/n");
                 var choice = Console.ReadKey();
                 if (choice.Key == ConsoleKey.Y)
                 {
                     keepPlaying = true;
                    //  Console.Clear();
                     Console.WriteLine("Choose Rock, Paper, Scissors");
                 }
                 else
                 {
                     keepPlaying = false;
                     Console.Clear();
                     Console.WriteLine("Goodbye!");
                 }
            }
        }
    }
}