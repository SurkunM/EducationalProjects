namespace HeapSortL11;

internal class PyramidSort
{
    public static void HeapSort(int[] array)
    {
        int lastIndex = array.Length - 1;

        for (int i = array.Length / 2 - 1; i >= 0; i--)
        {
            SiftElement(array, i, lastIndex);
        }

        for (int i = lastIndex; i > 0; i--)
        {
            int temp = array[0];
            array[0] = array[i];
            array[i] = temp;

            SiftElement(array, 0, i - 1);
        }
    }

    public static void SiftElement(int[] array, int parentIndex, int lastIndex)
    {
        while (true)
        {
            int leftChildIndex = 2 * parentIndex + 1;

            if (leftChildIndex > lastIndex)
            {
                return;
            }

            int rightChildIndex = 2 * parentIndex + 2;
            int maxChildIndex;

            if (rightChildIndex > lastIndex || array[leftChildIndex] > array[rightChildIndex])
            {
                maxChildIndex = leftChildIndex;
            }
            else
            {
                maxChildIndex = rightChildIndex;
            }

            if (array[parentIndex] >= array[maxChildIndex])
            {
                return;
            }

            int temp = array[maxChildIndex];
            array[maxChildIndex] = array[parentIndex];
            array[parentIndex] = temp;

            parentIndex = maxChildIndex;
        }
    }

    static void Main(string[] args)
    {
        int[] array = { 10, 2, 3, 6, 8, 1, 7, 12, 10 };

        HeapSort(array);

        Console.WriteLine(string.Join(", ", array));
    }
}