// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
// 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int S = N % 7;
int T = N % 23;
int i = 0;
if (i < S | i < T)
{
    Console.WriteLine($"не кратно");
}
else
{
     Console.WriteLine($"кратно");
}
