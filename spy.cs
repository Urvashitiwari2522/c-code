using System;

namespace SpyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, product = 1, sum = 0, lastdigit;

            Console.WriteLine("Enter the number to check: ");
            num = Convert.ToInt32(Console.ReadLine());

            int temp = num; // store original number for display

            while (temp > 0)
            {
                lastdigit = temp % 10;  // extract last digit
                sum = sum + lastdigit;  // update sum
                product = product * lastdigit; // update product
                temp = temp / 10; // remove the last digit
            }

            // compare sum and product
            if (sum == product)
            {
                Console.WriteLine($"{num} is a Spy Number.");
            }
            else
            {
                Console.WriteLine($"{num} is NOT a Spy Number.");
            }
        }
    }
}
