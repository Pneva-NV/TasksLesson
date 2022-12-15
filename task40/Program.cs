﻿// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.Write("Длина 1-й стороны треугольника: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Длина 2-й стороны треугольника: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write("Длина 3-й стороны треугольника: ");
int C = Convert.ToInt32(Console.ReadLine());
if (A < B + C && B < A + C && C < A + B)
{
    Console.Write($"Возможно нарисовать треугольник со сторонами такой длины");
}
else
{
   Console.Write($"Невозможно нарисовать треугольник со сторонами такой длины"); 
}