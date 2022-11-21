// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int DecToBin(int num)
{
   int binNumber=0;
   int d10=1;
   while (num>0)
   {
    binNumber = binNumber+ num % 2 * d10;
    num/=2;
    d10*=10;
   }
   return binNumber;
}

int ReverseNum(int num)
{
    int count=0;
    int res= 0;
    while (num>0)
    {
        count= number%10;
        res= res*10+count;
        num/=10;
    }
    return res;
}

string decToBin = DecToBin(number);

Console.WriteLine(decToBin);

