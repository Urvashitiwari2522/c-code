using System;

namespace DampedFrequency
{
    class Program
    {
        private int l, c, r;
        float frequency;

        // Constructor
        Program(int l, int c, int r)
        {
            this.l = l;
            this.c = c;
            this.r = r;
        }

        public float cal()
        {
            // Formula:
            // f = √[ (1 / (L * C)) − (R² / (4 * C²)) ]

            frequency = (float)Math.Sqrt(
                (1.0f / (l * (float)c)) -
                ((r * r) / (4.0f * c * c))
            );

            return frequency;
        }

        static void Main(string[] args)
        {
            float fq;
            int l, c, r;

            Console.WriteLine("Enter the values of L, C and R:");

            l = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            r = Convert.ToInt32(Console.ReadLine());

            Program obj = new Program(l, c, r);

            try
            {
                fq = obj.cal();
                Console.WriteLine("Damped Frequency = " + fq);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
