﻿// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.Write("Введите число а: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int resolt = num2 * num2;

if (resolt == num1)
{
    Console.WriteLine($"Ответ: Да");
}

 else
{
         Console.WriteLine($"Ответ: Нет");
}
