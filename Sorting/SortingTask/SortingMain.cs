using SortingTask.Files;

namespace SortingTask;

internal class SortingMain
{
    static void Main(string[] args)
    {
        int[] array = { 5, 10, 3, 2, 6, 8, 14, 7 };

        QuickSortTask.QuickSort(array, 0, array.Length - 1);
        Console.WriteLine("Быстрая сортировка: {0}", string.Join(", ", array));

        int[] arrayHeap = { 10, 2, 3, 6, 8, 1, 7, 12, 10 };

        PyramidSortTask.HeapSort(arrayHeap);
        Console.WriteLine("Сортировка кучей: {0}", string.Join(", ", arrayHeap));
    }
}