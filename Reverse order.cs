using System;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize array
            int[] arr = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Original array:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Array in reverse order:");

            // Loop in reverse order
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
