using System;

namespace SalvagePrg
{
    class Program
    {
        double dep, purchase, salv;
        int year;

        double salvage(double d, double p, int y)
        {
            dep = d;
            purchase = p;
            year = y;

            // Formula used: salvage = dep * year - purchase
            salv = dep * year - purchase;

            return salv;
        }

        static void Main(string[] args)
        {
            double result, d, p;
            int y;

            Console.WriteLine("Enter depreciation, purchase price, and year respectively:");

            d = Convert.ToDouble(Console.ReadLine());
            p = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());

            Program obj = new Program();
            result = obj.salvage(d, p, y);

            Console.WriteLine("Salvage Value = " + result);
        }
    }
}
