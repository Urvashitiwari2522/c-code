using System;

namespace RateofInterest
{
    class Bank
    {
        // Mark parent method virtual so child classes can override it
        public virtual int GetRateOfInterest()
        {
            return 0;
        }
    }

    class SBI : Bank
    {
        public override int GetRateOfInterest()
        {
            return 8;
        }
    }

    class ICICI : Bank
    {
        public override int GetRateOfInterest()
        {
            return 7;
        }
    }

    class AXIS : Bank
    {
        public override int GetRateOfInterest()
        {
            return 9;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int num, p = 0, r = 0, t = 0;
            double interest;

            SBI s = new SBI();
            ICICI i = new ICICI();
            AXIS a = new AXIS();

            Console.WriteLine("Select your Bank");
            Console.WriteLine("Enter 1 for SBI");
            Console.WriteLine("Enter 2 for ICICI");
            Console.WriteLine("Enter 3 for AXIS");

            num = Convert.ToInt32(Console.ReadLine());

            if (num == 1)
            {
                Console.WriteLine("SBI Rate of Interest: " + s.GetRateOfInterest());
                Console.WriteLine("Enter Principal: ");
                p = Convert.ToInt32(Console.ReadLine());
                r = s.GetRateOfInterest();
                Console.WriteLine("Enter Time Period: ");
                t = Convert.ToInt32(Console.ReadLine());
            }
            else if (num == 2)
            {
                Console.WriteLine("ICICI Rate of Interest: " + i.GetRateOfInterest());
                Console.WriteLine("Enter Principal: ");
                p = Convert.ToInt32(Console.ReadLine());
                r = i.GetRateOfInterest();
                Console.WriteLine("Enter Time Period: ");
                t = Convert.ToInt32(Console.ReadLine());
            }
            else if (num == 3)
            {
                Console.WriteLine("AXIS Rate of Interest: " + a.GetRateOfInterest());
                Console.WriteLine("Enter Principal: ");
                p = Convert.ToInt32(Console.ReadLine());
                r = a.GetRateOfInterest();
                Console.WriteLine("Enter Time Period: ");
                t = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Wrong Choice Entered");
                return; // stop execution
            }

            // Simple Interest formula: (P × R × T) / 100
            interest = (p * r * t) / 100.0;

            Console.WriteLine("Interest Payable = " + interest);
        }
    }
}
