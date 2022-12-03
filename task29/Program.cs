// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write($"[");
for (int i = 1; i <= 8; i++)
{
    int M = new Random().Next(0, 100);
    if (i <= 7)
    {
        Console.Write($"{M}, ");
    }
    if (i > 7)
    {
        Console.Write($"{M}");
    }
}
Console.Write($"]");
