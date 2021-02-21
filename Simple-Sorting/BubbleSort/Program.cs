using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 4, 2, 15, 22, 44, 68, 9 };

            arr = BubbleSort(arr);

            Console.WriteLine(string.Join(' ', arr));
        }

        public static int[] BubbleSort(int[] arr)
        {
            bool swapped = false;
            do
            {
                swapped = false;

                for (int i = 1; i < arr.Length; i++)
                {
                    if(arr[i - 1] > arr[i])
                    {
                        arr = Swap(arr, i - 1, i);
                        swapped = true;
                    }
                }

            } while (swapped);

            return arr;
        }

        public static int[] Swap(int[] arr, int leftIndex, int rightIndex)
        {
            int current = arr[leftIndex];
            arr[leftIndex] = arr[rightIndex];
            arr[rightIndex] = current;

            return arr;
        }
    }
}
