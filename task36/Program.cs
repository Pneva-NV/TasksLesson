﻿// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] Ar = new int[5];
int C = 0;
for (int i = 0; i < Ar.Length; i++)
{
    Ar[i] = new Random().Next(0, 10);
    Console.Write($"{Ar[i]} ");
    if (Ar[i] % 2 == 0) ;
    else
    {
        C = C + Ar[i];
    }
}
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {C}");