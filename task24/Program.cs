﻿// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write("Введите число любое число: ");
int A = Convert.ToInt32(Console.ReadLine());
int Sum = 0;
for (int i = 1; i <= A; i++)
{
    Sum = Sum + i;
}
Console.WriteLine($"{Sum}");