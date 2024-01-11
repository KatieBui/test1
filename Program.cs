using System;

class Program
{
    static void Main()
    {
        // Ввод исходного массива с клавиатуры
        Console.WriteLine("Введите элементы массива через запятую:");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(',');

        // Создание нового массива из строк, длина которых меньше или равна 3
        int newSize = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                newSize++;
            }
        }

        string[] newArray = new string[newSize];
        int index = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                newArray[index] = inputArray[i];
                index++;
            }
        }

        // Вывод нового массива
        Console.WriteLine("Новый массив из строк, длина которых меньше или равна 3 символам:");
        foreach (var item in newArray)
        {
            Console.Write(item + " ");
        }
    }
}
