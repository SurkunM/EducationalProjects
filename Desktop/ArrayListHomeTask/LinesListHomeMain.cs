namespace LinesListHomeTask;

internal class LinesListHomeMain
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
    }
}