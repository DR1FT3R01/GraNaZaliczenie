﻿using System;
using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
          
            Random random = new Random();
            bool playAgain = true;
            int guess;
            int number;
            int guesses;
            String response;
            
            while (playAgain)
            {       
                Console.WriteLine("Choose the min number");
                int min = int.Parse(Console.ReadLine());
                Console.WriteLine("Choose the max number");
                int max = int.Parse(Console.ReadLine());
                while (max < min)
                {
                    Console.WriteLine("Choose the number higher than min number");
                    max = int.Parse(Console.ReadLine());
                }
                
            
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max + 1);


                    while (guess != number)
                    {
                        Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
                        guess = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Guess: " + guess);

                        if (guess > number)
                        {
                            Console.WriteLine(guess + " is to high!");
                        }
                        else if (guess < number)
                        {
                            Console.WriteLine(guess + " is to low!");
                        }
                        guesses++;
                    
                    }
                    Console.WriteLine("Number: " + number);
                    Console.WriteLine("YOU WIN!");
                    Console.WriteLine("Guesses: " + guesses);

                    Console.WriteLine("Would you like to play again (Y/N): ");
                    response = Console.ReadLine();
                    response = response.ToUpper();

                    if (response == "Y")
                    {
                        playAgain = true;
                    }
                    else
                    {
                        playAgain = false;
                    }

                     
            }
            Console.WriteLine("Thanks for playing!");

            Console.ReadKey();
            
        }
    }    