// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа:
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Write("Введите трехзначное число: ");
int N = Convert.ToInt32(Console.ReadLine());

int s = N / 100;
int Ns = s * 100;
int N1 = N - Ns;

int d = N1 / 10;
int Nd = d * 10;
int N2 = N1 - Nd;

Console.WriteLine($"{N2}");