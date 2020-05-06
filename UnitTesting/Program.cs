using System;

namespace UnitTesting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my ATM simulation!");

            AtmTransactionHandler();
        }

        public static int TestingTheTest(int num)
        {
            return num + 1;
        }

        public static void AtmTransactionHandler()
        {
            // Continue to ask for transaction type until exit is chosen
            while (true)
            {
                try
                {
                    // Initiate user balance as 0
                    int userBalance = 0;

                    Console.WriteLine("To check your balance enter 1.\nTo withdraw money enter 2.\nTo deposit money enter 3.\nTo exit enter \"x\".");
                    int selectedTransaction = int.Parse(Console.ReadLine());

                }
                catch (FormatException fex) // Throw back to main when user chooses exit
                {
                    throw fex;

                }
            }
            
        }





    }
}
