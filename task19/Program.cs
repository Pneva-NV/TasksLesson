// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int N = Convert.ToInt32(Console.ReadLine());

int N1 = N - N / 10 * 10;
N = N / 10;
int N2 = N - N / 10 * 10;
N = N / 10;
int N3 = N - N / 10 * 10;
N = N / 10;
int N4 = N - N / 10 * 10;
N = N / 10;
int N5 = N;

if (N1 == N5 && N2 == N4)
{
    Console.WriteLine($"да");
}
else
{
    Console.WriteLine($"нет");
}