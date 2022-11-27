// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int N = new Random().Next(100, 1000);
Console.WriteLine($"{N}");
int C = N / 100;
int C1 = C * 100;
int D = N - C1;
int D1 = D / 10;
int D2 = D1 * 10;
int E = D - D2;

Console.WriteLine($"{C}{E}");