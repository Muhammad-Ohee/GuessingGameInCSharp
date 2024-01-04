//Console.WriteLine("Hello, OS");

namespace WhileIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to our Guessing Game!");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Print Number");
            Console.WriteLine("2) Guessing Game");
            Console.WriteLine("3) Exit");

            string result = Console.ReadLine();

            if (result == "1")
            {
                PrintNumbers();
                return true;
            }
            else if (result == "2")
            {
                GuessingGame();
                return true;
            }
            else if (result == "3")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static void PrintNumbers()
        {
            Console.Clear();
            Console.WriteLine("Print a number!");
            Console.Write("Type a number: ");

            int result = int.Parse(Console.ReadLine());

            int counter = 1;

            while (counter <= result)
            {
                Console.Write(counter);
                Console.WriteLine(" :) ");
                counter++;
            }

            Console.ReadLine();
        }

        private static void GuessingGame()
        {
            Console.Clear();
            Console.WriteLine("Guessing Game");

            Random rand = new Random();
            int randomNumber = rand.Next(1, 11);

            int guess = 0;
            bool incorrect = true;

            do
            {
                Console.WriteLine("Pick a number between 1 and 10");
                string result = Console.ReadLine();
                guess++;

                if (result == randomNumber.ToString())
                    incorrect = false;
                else
                    Console.WriteLine("Wrong");
            } while (incorrect);

            Console.WriteLine("You are Correct. You took {0} guesses", guess);

            Console.ReadLine();
        }
    }
}