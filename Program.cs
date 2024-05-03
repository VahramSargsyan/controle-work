using System;

class Program
{
    static string[] FilterShortStrings(string[] arr)
    {
        // Создание нового массива для хранения отфильтрованных строк
        string[] result = new string[arr.Length];
        int count = 0; // Переменная для отслеживания индекса в новом массиве

        // Проход по каждой строке в исходном массиве
        foreach (string str in arr)
        {
            // Проверка длины текущей строки
            if (str.Length <= 3)
            {
                // Если длина строки меньше или равна 3, добавление её в новый массив
                result[count] = str;
                count++;
            }
        }

        // Создание нового массива нужного размера и копирование в него отфильтрованных строк
        string[] filteredResult = new string[count];
        Array.Copy(result, filteredResult, count);
        
        return filteredResult;
    }

    static void Main(string[] args)
    {
        // Ввод массива строк
        Console.WriteLine("Введите массив строк через запятую и пробел:");
        string input = Console.ReadLine();
        string[] arr = input.Split(new string[] { ", " }, StringSplitOptions.None);

        // Фильтрация строк
        string[] filteredArr = FilterShortStrings(arr);

        // Вывод результата
        Console.WriteLine("Отфильтрованный массив:");
        foreach (string str in filteredArr)
        {
            Console.WriteLine(str);
        }
    }
}
