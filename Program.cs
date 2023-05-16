namespace BubbleSortV2
{
    internal class Program
    {
        static int bubbleSort(int[] arr)
        {
            int temporary, counter = 0;
            for (int i = arr.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temporary = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temporary;
                    }
                counter++;
                }
            }
            return counter;
        }

        static void printArray(int[] arr)
        {
            foreach (int n in arr)
            {
                Console.Write($"{n} ");
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            int[] array = { 3, 10, 8, 1, 2, 5, 4, 6, 9, 7 };    //1-10

            Console.WriteLine("Original array:");
            printArray(array);

            int n = bubbleSort(array);

            Console.WriteLine("Sorted array:");
            printArray(array);
            Console.WriteLine($"Inner loop through {n} times.");
        }
    }
}
