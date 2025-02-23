using SortingTask.Files;

namespace SortingTask;

internal class SortingMain
{
    static void Main(string[] args)
    {
        int[] array1 = { 10, 2, 3, 6, 8, 1, 7, 12, 10 };

        QuickSortTask.QuickSort(array1, 0, array1.Length - 1);
        Console.WriteLine("Быстрая сортировка: {0}", string.Join(", ", array1));

        int[] array2 = { 10, 2, 3, 6, 8, 1, 7, 12, 10 };

        PyramidSortTask.HeapSort(array2);
        Console.WriteLine("Сортировка кучей: {0}", string.Join(", ", array2));

        int[] array3 = { 10, 2, 3, 6, 8, 1, 7, 12, 10 };
        SelectionSortTask.SelectionSort(array3);        

        int[] array4 = { 10, 2, 3, 6, 8, 1, 7, 12, 10 };
        BubbleSortTask.BubbleSort(array4);        

        int[] array5 = { 10, 2, 3, 6, 8, 1, 7, 12, 10 };
        InsertionSortTask.InsertionSort(array5);        

        int neededNumber = 2;
        var index = BinarySearchTask.BinarySearch(array4, neededNumber);        
    }
}