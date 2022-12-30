// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.Write("Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());

int SumNum(int N)
{
    if (N < M) return 0;
    return N + SumNum(N - 1);
}

Console.Write($"Сумма элементов =  {SumNum(N)}");