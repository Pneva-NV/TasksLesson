// // Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк: ");
int Str = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int Stb = Convert.ToInt32(Console.ReadLine());

int[,] TwoArray = RandomArray(Str, Stb);
int[,] RandomArray(int Str, int Stb)
{
    int[,] TwoArray = new int[Str, Stb];
    for (int i = 0; i < TwoArray.GetLength(0); i++)
    {
        for (int j = 0; j < TwoArray.GetLength(1); j++)
        {
            TwoArray[i, j] = new Random().Next(0, 10);
        }
    }
    return TwoArray;
}

void Print(int[,] TwoArray)
{
    for (int i = 0; i < TwoArray.GetLength(0); i++)
    {
        for (int j = 0; j < TwoArray.GetLength(1); j++)
            Console.Write($"{TwoArray[i, j]} ");
        Console.WriteLine();
    }
}

void ArithmeticMean(int[,] TwoArray)
{
    for (int j = 0; j < TwoArray.GetLength(1); j++)
    {
        double box = 0;
        for (int i = 0; i < TwoArray.GetLength(0); i++)
        {
            box = box + TwoArray[i, j]; 
                     }
        box = box / TwoArray.GetLength(0);
              Console.Write($"{box}  ");
    }
}

Print(TwoArray);
Console.WriteLine($"Среднее арифметическое каждого столбца: ");
ArithmeticMean(TwoArray);