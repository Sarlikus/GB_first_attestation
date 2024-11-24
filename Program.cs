
class Program
{
    static void Main()
    {
        // Исходный массив строк
        string[] inputArray = { "Hello, World!", "15", "old", ":-)()" };
        
        // Создаем временный массив для хранения строк длиной <= 3 символа
        string[] resultArray = new string[inputArray.Length];
        int index = 0;

        // Проходим по всем строкам в исходном массиве
        foreach (string str in inputArray)
        {
            // Если длина строки <= 3, добавляем ее в новый массив
            if (str.Length <= 3)
            {
                resultArray[index] = str;
                index++;
            }
        }

        // Вывод нового массива (обрезаем лишние пустые элементы)
        Console.WriteLine("Результат:");
        for (int i = 0; i < index; i++)
        {
            Console.WriteLine(resultArray[i]);
        }
    }
}


