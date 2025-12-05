using System;

namespace DistanceTravelled
{
    class Program
    {
        float u, t, a, s;

        float distance(float u1, float t1, float a1)
        {
            u = u1;
            t = t1;
            a = a1;

            s = u * t + (a * t * t) / 2;
            return s;
        }

        static void Main(string[] args)
        {
            float result, u1, t1, a1;
            int choice;

            do
            {
                Console.WriteLine("Enter the values of u, t and a respectively:");
                u1 = Convert.ToSingle(Console.ReadLine());
                t1 = Convert.ToSingle(Console.ReadLine());
                a1 = Convert.ToSingle(Console.ReadLine());

                Program obj = new Program();
                result = obj.distance(u1, t1, a1);

                Console.WriteLine("Distance Travelled = " + result);

                Console.WriteLine("If you want to continue press 1, else 0:");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice != 1)
                {
                    Console.WriteLine("Thanks");
                    break;
                }

            } while (choice == 1);
        }
    }
}
