// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 99;

if (i >= N)
{
    Console.WriteLine($"третьей цифры нет");
}

while (i < N)
{
    int S = N / 10;
    if (i >= S)
    {
        int C = N - S * 10;
        Console.WriteLine($"{C}");
        break;
    }
    if (i < S)
    {
        N = S;
    }
    i++;
}
