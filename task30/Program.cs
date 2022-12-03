// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.Write($"[");
for (int i = 1; i <= 8; i++)
{
    int M = new Random().Next(0, 2);
    if (i <= 7)
    {
        Console.Write($"{M},");
    }
    if (i > 7)
    {
        Console.Write($"{M}");
    }
}
Console.Write($"]");