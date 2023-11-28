using System;

class Program
{
    static void FilterStrings(string[] original, out string[] result)
    {
        result = new string[original.Length];
        int resultSize = 0;

        foreach (var str in original)
        {
            if (str.Length <= 3)
            {
                result[resultSize++] = str;
            }
        }

        Array.Resize(ref result, resultSize);
    }

    static void Main()
    {
        // Ввод строки
        Console.Write("Введите строки через пробелы: ");
        string inputString = Console.ReadLine();

        // Разделение строки на массив строк
        string[] inputStrings = inputString.Split(' ');

        // Выходной массив строк
        string[] outputStrings;

        // Фильтрация строк
        FilterStrings(inputStrings, out outputStrings);

        // Вывод результата
        Console.WriteLine("Результат:");
        foreach (var str in outputStrings)
        {
            Console.WriteLine(str);
        }
    }
}