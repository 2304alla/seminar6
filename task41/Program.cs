// Задача 41: Пользователь вводит с клавиатуры M чисел
// . Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int CounterNumber(int[] array)

{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

int[] FillingArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите число");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

Console.WriteLine("Задвйте колличество элементов массива");
int sizeNum = Convert.ToInt32(Console.ReadLine());

int[] arr = FillingArray(sizeNum);
PrintArray(arr);

int counter = CounterNumber(arr);
Console.WriteLine($"Чисел больше 0 --> {counter} ");


