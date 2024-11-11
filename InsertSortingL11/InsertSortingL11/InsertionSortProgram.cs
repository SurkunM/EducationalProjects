namespace InsertionSortL11;

internal class InsertionSortProgram
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

    static void Main(string[] args)
    {
        int[] array = { 6, 1, 2, -2, 0, -3, 3, 4, -4, -5, 5, -1, -6 };

        InsertionSort(array);

        Console.WriteLine(string.Join(", ", array));
    }
}