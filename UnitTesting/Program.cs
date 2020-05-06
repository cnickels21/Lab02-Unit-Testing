using System;

namespace UnitTesting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my ATM simulation!");

            AtmTransactionHandler(500);
        }

        public static int TestingTheTest(int num)
        {
            return num + 1;
        }

        public static void AtmTransactionHandler(decimal currentBalance)
        {
            // Continue to ask for transaction type until exit is chosen

            // Initiate user balance as 0
            decimal userBalance = currentBalance;

            Console.WriteLine("To check your balance enter 1.\nTo withdraw money enter 2.\nTo deposit money enter 3.\nTo exit enter \"4\".");
            int selectedTransaction = int.Parse(Console.ReadLine());

            if (selectedTransaction == 1)
            {
                Console.WriteLine($"\nYour balance is: {userBalance}\n");
                AtmTransactionHandler(userBalance);
            }
            if (selectedTransaction == 2)
            {
                Console.WriteLine("\nHow much would you like to withdraw: \n");
                decimal withdrawalAmount = decimal.Parse(Console.ReadLine());
                userBalance = WithdrawalHandler(userBalance, withdrawalAmount);
                Console.WriteLine($"\nYour balance is now: {userBalance}\n");
                AtmTransactionHandler(userBalance);
            }
            if (selectedTransaction == 3)
            {
                Console.WriteLine("\nHow much would you like to deposit: \n");
                decimal depositAmount = decimal.Parse(Console.ReadLine());
                userBalance = DepositHandler(userBalance, depositAmount);
                Console.WriteLine($"\nYour balance is now: {userBalance}\n");
                AtmTransactionHandler(userBalance);
            }
            if (selectedTransaction == 4)
            {
                return;
            }




        }

        public static decimal DepositHandler(decimal currentBalance, decimal depositAmount)
        {
            return currentBalance + depositAmount;
        }

        public static decimal WithdrawalHandler(decimal currentBalance, decimal withdrawalAmount)
        {
            return currentBalance - withdrawalAmount;
        }

    }
}
