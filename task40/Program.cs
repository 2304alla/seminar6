// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите число А: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число C: ");
int num3 = Convert.ToInt32(Console.ReadLine());

bool TriangleSide(int a, int b, int c)
{
   
    return a < b + c && b < a + c && c < a + b;
}

bool res = TriangleSide(num1, num2, num3);
Console.WriteLine(res ? "Да" : "Нет");
