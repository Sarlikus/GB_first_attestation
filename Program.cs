class Program
{
    static void Main()
    {
        // Исходный массив строк
        string[] startArray = { "Hello, World", "15", "old", ":-)()" };

        // Определение размера нового массива
        int count = 0;
        int i = 0;
        while (i < startArray.Length)
        {
            if (startArray[i].Length <= 3)
            {
                count++;
            }
            i++;
        }

        // Создание нового массива
        string[] resultArray = new string[count];
        int index = 0;
        int j = 0;

        // Заполнение нового массива строками длиной <= 3
        while (j <= count)
        {
            if (startArray[j].Length <= 3)
            {
                resultArray[index] = startArray[j];
                index++;
            }
            j++;
        }

        // Вывод нового массива в виде массива
        Console.WriteLine($"[{string.Join(", ", resultArray)}]");
    }
}




