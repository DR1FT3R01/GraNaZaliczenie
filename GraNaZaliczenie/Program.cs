using System;
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
            
            bool parsingResult;
            while (playAgain)
            {       
                Console.WriteLine("Wybierz przedział, zaczynając od minimalnej liczby");
                int min=0;
                        parsingResult = int.TryParse(Console.ReadLine(), out min);
                    if(!parsingResult)
                    {
                        min=1;
                    }
                Console.WriteLine("Teraz podaj maksymalną liczbę przedziału");
                int max=0;
                        parsingResult = int.TryParse(Console.ReadLine(), out max);
                    if(!parsingResult)
                    {
                        max=1;
                    }
                while (max < min)
                {
                    Console.WriteLine("Wybierz liczbę większą od podanej liczby minimalnej");
                    max = int.Parse(Console.ReadLine()??string.Empty);
                }
                
            
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max + 1);


                    while (guess != number)
                    {
                        Console.WriteLine("Zgadnij liczbę pomiędzy " + min + " - " + max + " : ");
                        guess = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Twoja odpowiedź: " + guess);

                        if (guess > number)
                        {
                            Console.WriteLine(guess + " podana liczba jest za wysoka");
                        }
                        else if (guess < number)
                        {
                            Console.WriteLine(guess + " podana liczba jest za niska");
                        }
                        guesses++;
                    
                    }
                    Console.WriteLine("Poprawna liczba: " + number);
                    Console.WriteLine("Gratulacje");
                    Console.WriteLine("Ilość odpowiedzi: " + guesses);

                    Console.WriteLine("Czy chcesz zagrać ponownie? (T/N): ");
                    response = Console.ReadLine()??string.Empty;
                    response = response.ToUpper();

                    if (response == "T")
                    {
                        playAgain = true;
                    }
                    else
                    {
                        playAgain = false;
                    }

                     
            }
            Console.WriteLine("Dzięki za grę :)");

        
            
        }
    }    