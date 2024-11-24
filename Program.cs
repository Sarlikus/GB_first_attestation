
class Program
{
    static void Main()
    {
        // Задаем исходный массив
        Console.WriteLine("Введите строки через пробел:");
        string[] inputArray = Console.ReadLine().Split(' ');

        // Вызываем метод для фильтрации массива
        string[] resultArray = FilterArray(inputArray);

        // Выводим результат
        Console.WriteLine("Строки длиной меньше или равной 3 символам:");
        Console.WriteLine($"[{string.Join(", ", resultArray)}]");
    }

    static string[] FilterArray(string[] inputArray)
    {
        // Подсчитываем количество строк, удовлетворяющих условию
        int count = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        // Создаем новый массив для строк, соответствующих условию
        string[] resultArray = new string[count];
        int index = 0;

        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                resultArray[index] = str;
                index++;
            }
        }

        return resultArray;
    }
}

