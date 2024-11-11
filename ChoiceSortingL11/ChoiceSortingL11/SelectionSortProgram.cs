namespace SelectionSortingL11;

internal class SelectionSortProgram
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

    static void Main(string[] args)
    {
        int[] array = { 9, 7, -4, 2, 0, -3, -1 };

        SelectionSort(array);

        Console.WriteLine(string.Join(", ", array));
    }
}