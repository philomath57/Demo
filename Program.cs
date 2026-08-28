using System;

namespace G7Bank;

class Program
{
    static void Main(string[] args)
    {
        Bank myG7Bank = new Bank();
        bool keepProgramOpen = true;

        while (keepProgramOpen)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("        Welcome to G7Bank");
            Console.WriteLine();
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Signup");
            Console.WriteLine("3. Quit");
            Console.Write("Please choose an option: ");

            string mainMenuChoice = Console.ReadLine()?? "";

            switch (mainMenuChoice)
            {
                case "1":
                    myG7Bank.StartLogin();
                    break;

                case "2":
                    myG7Bank.Signup();
                    break;

                case "3":
                    keepProgramOpen = false;
                    Console.WriteLine("Thank you for using G7Bank.");
                    break;

                default:
                    Console.WriteLine("Please choose valid number:1,2,3");
                    
                    break;
            }
        }
    }
}