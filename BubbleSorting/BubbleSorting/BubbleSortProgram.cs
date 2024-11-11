namespace BubbleSortL11;

internal class BubbleSortProgram
{
    public static void BubbleSort(int[] array)
    {
        bool isArraySorted = false;
        int unsortedLength = array.Length;

        while (!isArraySorted)
        {
            isArraySorted = true;
            unsortedLength--;

            for (int j = 0; j < unsortedLength; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;

                    isArraySorted = false;
                }
            }
        }
    }

    static void Main(string[] args)
    {
        int[] array = { 9, 2, 3, -4, -5, 6, 0, 9 };

        BubbleSort(array);

        Console.WriteLine(string.Join(", ", array));
    }
}