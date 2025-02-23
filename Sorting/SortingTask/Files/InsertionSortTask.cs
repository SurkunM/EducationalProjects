namespace SortingTask.Files;

internal class InsertionSortTask
{
    public static void InsertionSort(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            int temp = array[i];
            int j = i - 1;

            while (true)
            {
                if (j < 0 || temp >= array[j])
                {
                    array[j + 1] = temp;
                    break;
                }

                array[j + 1] = array[j];
                j--;
            }
        }
    }
}