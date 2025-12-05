using System;

namespace RemoveDuplicateinArray
{
    class Program
    {
        public static int removeDuplicateElements(int[] arr, int n)
        {
            if (n == 0 || n == 1)
            {
                return n;  // No duplicates possible
            }

            int[] temp = new int[n];
            int j = 0;

            // Only copy unique elements
            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] != arr[i + 1])
                {
                    temp[j++] = arr[i];
                }
            }

            // Copy last element
            temp[j++] = arr[n - 1];

            // Copy back to original array
            for (int i = 0; i < j; i++)
            {
                arr[i] = temp[i];
            }

            return j;  // new length of array
        }

        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 20, 30, 30, 40, 50, 50 };
            int length = arr.Length;

            length = removeDuplicateElements(arr, length);

            Console.WriteLine("Array after removing duplicates:");

            for (int i = 0; i < length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
