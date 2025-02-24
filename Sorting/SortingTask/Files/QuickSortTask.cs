namespace SortingTask.Files;

public class QuickSortTask
{
    public static void QuickSort(int[] array)
    {
        QuickSortRecursion(array, 0, array.Length - 1);
    }

    private static void QuickSortRecursion(int[] array, int left, int right)
    {
        if (right <= left)
        {
            return;
        }

        if (right - left == 1)
        {
            if (array[left] > array[right])
            {
                int temp = array[left];
                array[left] = array[right];
                array[right] = temp;
            }

            return;
        }

        int supportElement = array[left];
        int i = left;
        int j = right;

        while (i <= j)
        {
            while (array[i] < supportElement)
            {
                i++;
            }

            while (array[j] > supportElement)
            {
                j--;
            }

            if (i <= j)
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;

                i++;
                j--;
            }
        }

        if (i < right)
        {
            QuickSortRecursion(array, i, right);
        }

        if (j > left)
        {
            QuickSortRecursion(array, left, j);
        }
    }
}