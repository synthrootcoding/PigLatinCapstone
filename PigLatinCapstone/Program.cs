using System;

namespace PigLatinCapstone
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueAnswer = true;

            while (continueAnswer == true)
            {
                char[] numbers = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
                char[] symbols = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', };
                char[] vowels = { 'a', 'e', 'i', 'o', 'u', };

                Console.WriteLine("Hello user. Please input a word:\n");
                string userInput = Console.ReadLine().ToLower();
                int index = userInput.IndexOfAny(vowels);
                int symbolsCheck = userInput.IndexOfAny(symbols);
                int numbersCheck = userInput.IndexOfAny(numbers);

                if (String.IsNullOrWhiteSpace(userInput))

                {
                    Console.WriteLine("You entered nothing.\n");
                    continueAnswer = true;
                }

                else if (symbolsCheck >= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Cannot translate with numbers/symbols\n");
                    continueAnswer = true;
                }

                else
                {

                    if (index == 0)
                    {
                        Console.WriteLine();
                        string startsVowel = (userInput.ToLower() + "way\n");
                        Console.WriteLine(startsVowel);
                    }

                    else
                    {
                        Console.WriteLine();
                        string consonants = userInput.Substring(0, index);
                        string consonantVowels = userInput.Substring(index);
                        string newUserInput = (consonantVowels.ToLower() + consonants.ToLower() + "ay\n");
                        Console.WriteLine(newUserInput);
                    }

                    while (continueAnswer == true)
                    {
                        Console.WriteLine("Continue? y/n\n");
                        string answer = Console.ReadLine();

                        if (answer == "y")
                        {
                            Console.WriteLine();
                            break;
                        }

                        else if (answer == "n")
                        {
                            Console.WriteLine();
                            Console.WriteLine("Goodbye\n");
                            continueAnswer = false;
                        }

                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Incorrect input\n");
                            continueAnswer = true;
                        }
                    }
                   
                }
            }
        }
    }
}
