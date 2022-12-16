// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите количество строк: ");
int Str = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int Stb = Convert.ToInt32(Console.ReadLine());
double[,] TwoArray = RandomArray(Str, Stb);

double[,] RandomArray(int Str, int Stb)
{
    double[,] TwoArray = new double[Str, Stb];
    Random R = new Random();
    for (int i = 0; i < TwoArray.GetLength(0); i++)
    {
        for (int j = 0; j < TwoArray.GetLength(1); j++)
        { TwoArray[i, j] = Math.Round(R.NextDouble(), 2); }
    }
    return TwoArray;
}
void Print(double[,] TwoArray)
{
    for (int i = 0; i < TwoArray.GetLength(0); i++)
    {
        for (int j = 0; j < TwoArray.GetLength(1); j++)
            Console.Write($"{TwoArray[i, j]} ");
        Console.WriteLine();
    }
}

Print(TwoArray);
