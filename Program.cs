using System;

class Program
{
    static void Main()
    {
        // Исходный массив строк
        string[] inputArray = { "Hello, World", "15", "old", ":-)()" };

        // Определение размера нового массива
        int count = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        // Создание нового массива
        string[] resultArray = new string[count];
        int index = 0;

        // Заполнение нового массива строками длиной <= 3
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                resultArray[index] = str;
                index++;
            }
        }

        // Вывод нового массива в виде массива
        Console.WriteLine($"[{string.Join(", ", resultArray)}]");
    }
}




