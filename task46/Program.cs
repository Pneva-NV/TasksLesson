// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

int[,] TwoArray = new int[3, 4];
for (int i = 0; i < TwoArray.GetLength(0); i++)
{
       for (int j = 0; j < TwoArray.GetLength(1); j++)
    {
        TwoArray[i, j] = new Random().Next(0, 10);
        Console.Write($"{TwoArray[i, j]} ");
    }
Console.WriteLine();
}


