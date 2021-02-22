using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 5, 122, 4, 2, 18, 192, 55, 10, 9 };


            Console.WriteLine(string.Join(' ', arr));
            Console.WriteLine();

            arr = QuickSort(arr, 0, arr.Length - 1);

            Console.WriteLine(string.Join(' ', arr));
        }

        public static int Partition(int[] arr, int lo, int hi)
        {
            int pivot = arr[lo];
            int wall = lo + 1;

            for (int i = wall; i <= hi; i++)
            {
                if (arr[i] <= pivot)
                {
                    arr = Swap(arr, i, wall);
                    wall++;
                }
            }

            wall--;
            arr = Swap(arr, lo, wall);
            return wall;
        }

        public static int[] Swap(int[] arr, int first, int second)
        {
            int current = arr[first];
            arr[first] = arr[second];
            arr[second] = current;

            return arr;
        }

        public static int[] QuickSort(int[] arr, int lo, int hi)
        {

            if (lo < hi)
            {
                int p = Partition(arr, lo, hi);
                arr = QuickSort(arr, lo, p);
                arr = QuickSort(arr, p + 1, hi);

            }

            return arr;
        }
    }
}
