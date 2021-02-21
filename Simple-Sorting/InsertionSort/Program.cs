using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 4, 2, 15, 22, 44, 68, 9 };

            arr = InsertionSort(arr);

            Console.WriteLine(string.Join(' ', arr));
        }

        public static int[] InsertionSort(int[] arr)
        {
            int i = 0;
            for (int firstUnsortedIndex = 1; firstUnsortedIndex < arr.Length; firstUnsortedIndex++)
            {
                i = firstUnsortedIndex;

                while(i > 0 && arr[i - 1] > arr[i])
                {
                    arr = Swap(arr, i, i - 1);
                    i--;
                }
            }

            return arr;
        }

        public static int[] Swap(int[] arr, int firstIndex, int secondIndex)
        {
            int current = arr[firstIndex];
            arr[firstIndex] = arr[secondIndex];
            arr[secondIndex] = current;

            return arr;
        }
    }
}
