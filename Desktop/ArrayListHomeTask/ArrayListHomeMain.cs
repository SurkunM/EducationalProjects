﻿namespace ArrayListHomeTask;

internal class ArrayListHomeMain
{
    public static List<string> GetLinesListFromFile(string inputFilePath)
    {
        using StreamReader reader = new StreamReader(inputFilePath);

        List<string> linesList = new List<string>();

        string? currentLine;

        while ((currentLine = reader.ReadLine()) != null)
        {
            linesList.Add(currentLine);
        }

        return linesList;
    }

    public static void RemoveEvenNumbers(List<int> list)
    {
        for (int i = list.Count - 1; i >= 0; i--)
        {
            if (list[i] % 2 == 0)
            {
                list.RemoveAt(i);
            }
        }
    }

    public static List<T> GetUniqueElementsList<T>(List<T> list)
    {
        List<T> uniqueElementsList = new List<T>(list.Count);

        foreach (T element in list)
        {
            if (!uniqueElementsList.Contains(element))
            {
                uniqueElementsList.Add(element);
            }
        }

        return uniqueElementsList;
    }

    static void Main(string[] args)
    {
        try
        {
            List<string> linesList = GetLinesListFromFile("..\\..\\..\\TextFile\\text.txt");

            Console.WriteLine(string.Join(Environment.NewLine, linesList));
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Файл не найден");
        }
        catch (Exception)
        {
            Console.WriteLine("Не найден путь к файлу");
        }

        List<int> numbers = new List<int> { 5, 1, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1 };
        RemoveEvenNumbers(numbers);

        Console.WriteLine(string.Join(", ", numbers));

        List<int> uniqueNumbers = GetUniqueElementsList(numbers);
        Console.WriteLine(string.Join(", ", uniqueNumbers));
    }
}