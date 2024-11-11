namespace BinarySearchL10;

internal class BinarySearchProgram
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

    static void Main(string[] args)
    {
        int[] array = [2, 3, 5, 6, 7, 8, 9];

        int neededNumber = 4;

        Console.WriteLine();
        Console.WriteLine($"(Метод через рекурсию). Индекс числа {neededNumber} = {BinarySearch(array, neededNumber, 0, array.Length - 1)}");
        Console.WriteLine($"(Метод без рекурсии). Индекс числа {neededNumber} = {BinarySearch(array, neededNumber)}");
    }
}