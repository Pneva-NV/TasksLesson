// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

int N = new Random().Next(10, 99);
Console.WriteLine($"{N}");
int C = N / 10;
int D = C * 10;
int E = N - D;
int max = C;

int resolt = Math.Max(C, E);
Console.WriteLine(resolt);
