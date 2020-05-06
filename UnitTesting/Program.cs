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
                try
                {
                    // Initiate user balance as 0
                    decimal userBalance = 0;

                    Console.WriteLine("To check your balance enter 1.\nTo withdraw money enter 2.\nTo deposit money enter 3.\nTo exit enter \"x\".");
                    int selectedTransaction = int.Parse(Console.ReadLine());

                    if (selectedTransaction == 1)
                    {
                        Console.WriteLine($"\nYour balance is: {userBalance}\n");
                        return;
                    }
                    if (selectedTransaction == 2)
                    {
                        Console.WriteLine("\nHow much would you like to withdraw: \n");
                    }
                    if (selectedTransaction == 3)
                    {
                        Console.WriteLine("\nHow much would you like to deposit: \n");
                        decimal depositAmount = decimal.Parse(Console.ReadLine());
                        userBalance = DepositHandler(userBalance, depositAmount);
                        Console.WriteLine($"\nYour balance is now: {userBalance}\n");
                    }

                }
                catch (FormatException fex) // Throw back to main when user chooses exit
                {
                    throw fex;
                }
            
        }

        public static decimal DepositHandler(decimal currentBalance, decimal depositAmount)
        {
            return currentBalance + depositAmount;
        }



    }
}
