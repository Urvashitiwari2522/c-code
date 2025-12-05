using System;

namespace AtmMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            int balance = 100000;
            int withdraw;
            int deposit;

            while (true)
            {
                Console.WriteLine("Automated Teller Machine");
                Console.WriteLine("Choose 1 for Withdraw");
                Console.WriteLine("Choose 2 for Deposit");
                Console.WriteLine("Choose 3 for Check Balance");
                Console.WriteLine("Choose 4 for EXIT");
                Console.WriteLine("Choose the operation you want to perform:");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter money to be withdrawn:");
                        withdraw = Convert.ToInt32(Console.ReadLine());

                        if (balance >= withdraw)
                        {
                            balance = balance - withdraw;   // <-- FIXED
                            Console.WriteLine("Please collect your money");
                        }
                        else
                        {
                            Console.WriteLine("Insufficient Balance");
                        }
                        Console.WriteLine("");
                        break;

                    case 2:
                        Console.WriteLine("Enter money to be deposited:");
                        deposit = Convert.ToInt32(Console.ReadLine());

                        balance = balance + deposit;
                        Console.WriteLine("Your Money has been successfully deposited");
                        Console.WriteLine("");
                        break;

                    case 3:
                        Console.WriteLine("Balance : " + balance);
                        Console.WriteLine("");
                        break;

                    case 4:
                        return; // exit the program

                    default:
                        Console.WriteLine("Invalid Choice! Please try again.");
                        Console.WriteLine("");
                        break;
                }
            }
        }
    }
}
