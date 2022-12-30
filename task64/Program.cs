// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите любое положительное число: ");
int N = Convert.ToInt32(Console.ReadLine());
int A = 1;
string NatNum(int A, int N)
{
    if (A <= N) return NatNum(A + 1, N) + $"{A} ";
    else return String.Empty;
}
string U=NatNum(A, N);
U = U.Replace(" ", ", ");
U = U.Replace($"{A},", $"{A}");
Console.Write($"N = {N} -> \" ");
Console.Write(U);
Console.Write("\"");