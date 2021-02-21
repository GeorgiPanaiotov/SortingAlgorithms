using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 4, 2, 15, 22, 44, 68, 9 };

            arr = SelectSort(arr);

            Console.WriteLine(string.Join(' ', arr));
        }

        public static int[] Swap(int[] arr, int left, int minIndex)
        {
            int current = arr[left];
            arr[left] = arr[minIndex];
            arr[minIndex] = current;

            return arr;
        }

        public static int[] SelectSort(int[] arr)
        {
            int minIndex = 0;

            for (int left = 0; left < arr.Length - 1; left++)
            {
                minIndex = left;

                for (int i = left + 1; i < arr.Length; i++)
                {
                    if(arr[i] < arr[minIndex])
                    {
                        minIndex = i;
                    }
                }

                if(minIndex != left)
                {
                    arr = Swap(arr, left, minIndex);
                }
            }

            return arr;
        }
    }
}
