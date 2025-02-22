namespace SortingTask.Files;

internal class SelectionSortTask
{
    public static void SelectionSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int minNumberIndex = i;

            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minNumberIndex])
                {
                    minNumberIndex = j;
                }
            }

            int temp = array[i];
            array[i] = array[minNumberIndex];
            array[minNumberIndex] = temp;
        }
    }
}
