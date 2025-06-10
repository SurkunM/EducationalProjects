namespace SortingTask.Sorting;

public class BinarySearchTask
{
    public static int BinarySearch(int[] array, int number, int left, int right)
    {
        if (left > right)
        {
            return -1;
        }

        int middle = left + (right - left) / 2;

        if (number == array[middle])
        {
            return middle;
        }

        if (number > array[middle])
        {
            return BinarySearch(array, number, middle + 1, right);
        }

        return BinarySearch(array, number, left, middle - 1);
    }

    public static int BinarySearch(int[] array, int number)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int middle = left + (right - left) / 2;

            if (number == array[middle])
            {
                return middle;
            }

            if (number > array[middle])
            {
                left = middle + 1;
            }
            else
            {
                right = middle - 1;
            }
        }

        return -1;
    }
}
