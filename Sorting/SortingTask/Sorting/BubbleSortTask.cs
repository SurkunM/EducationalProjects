namespace SortingTask.Sorting;

public class BubbleSortTask
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
}