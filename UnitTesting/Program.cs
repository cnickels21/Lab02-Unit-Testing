using System;

namespace UnitTesting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my ATM simulation!");

            try
            {
                AtmTransactionHandler(500);
                Console.WriteLine("Thank you for your time!");
            }
            finally
            {
                Environment.Exit(0);
            }
            
        }

        public static int TestingTheTest(int num)
        {
            return num + 1;
        }

        public static void AtmTransactionHandler(decimal currentBalance)
        {
            // Initiate user balance
            decimal userBalance = currentBalance;

            try
            {
                // Initial prompt for user transaction
                Console.WriteLine("To check your balance enter 1.\nTo withdraw money enter 2.\nTo deposit money enter 3.\nTo exit enter \"4\".");
                int selectedTransaction = int.Parse(Console.ReadLine());

            
                if (selectedTransaction == 1)
                {
                    Console.WriteLine($"\nYour balance is: {userBalance}\n");
                    AtmTransactionHandler(userBalance); // Keep atm open
                }
                if (selectedTransaction == 2) // Handler for withdrawals
                {
                    userBalance = WithdrawalHandler(userBalance);
                    AtmTransactionHandler(userBalance); // Keep atm open with updated balance
                }
                if (selectedTransaction == 3)  // Handler for deposits
                {
                    userBalance = DepositHandler(userBalance);
                    AtmTransactionHandler(userBalance); // Keep atm open with updated balance
                }
                if (selectedTransaction == 4) // Close when prompted
                {
                    return;
                }
            }
            catch (FormatException) // Asks the user for a valid input
            {
                Console.WriteLine("\nInvalid response. Please enter a number!\n");
                AtmTransactionHandler(userBalance);
            }
            

        }

        public static decimal DepositHandler(decimal currentBalance)
        {
            // Get deposit amount
            Console.WriteLine("\nHow much would you like to deposit: \n");
            decimal depositAmount = decimal.Parse(Console.ReadLine());

            // Set new balance
            decimal newBalance = currentBalance + depositAmount;

            // Display new balance
            Console.WriteLine($"\nYour balance is now: {newBalance}\n");

            // Return to atm hanlder to update balance
            return newBalance;
        }

        public static decimal WithdrawalHandler(decimal currentBalance)
        {
            // Get withdrawal amount
            Console.WriteLine("\nHow much would you like to withdraw: \n");
            decimal withdrawalAmount = decimal.Parse(Console.ReadLine());

            // Set new balance
            decimal newBalance = currentBalance - withdrawalAmount;

            // Display new balance
            Console.WriteLine($"\nYour balance is now: {newBalance}\n");

            // Return to atm handler to update balance
            return newBalance;
        }

    }
}
