class Program
{
    static void Main()
    {
        // Исходный массив строк
        string[] inputArray = { "Hello, World", "15", "old", ":-)()" };

        // Определение размера нового массива
        int count = 0;
        int i = 0;
        while (i < inputArray.Length)
        {
            if (inputArray[i].Length <= 3)
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
        while (j < inputArray.Length)
        {
            if (inputArray[j].Length <= 3)
            {
                resultArray[index] = inputArray[j];
                index++;
            }
            j++;
        }

        // Вывод нового массива в виде массива
        Console.WriteLine($"[{string.Join(", ", resultArray)}]");
    }
}




