// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

Console.Write("Введите количество строк: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int post = Convert.ToInt32(Console.ReadLine());
int[,] TwoArray = RandomArray(line, post);

int[,] RandomArray(int line, int post)
{
    int[,] TwoArray = new int[line, post];
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

int Diagonal(int[,] TwoArray)
{
    int resolt = 0;
    for (int i = 0; i < TwoArray.GetLength(0); i++)
    {
        for (int j = 0; j < TwoArray.GetLength(1); j++)
            if (i == j)
            {
                resolt = resolt + TwoArray[i, j];
            }
    }
    return resolt;
}

Print(TwoArray);

//Console.WriteLine();
Console.WriteLine($"Сумма элементов главной диагонали = {Diagonal(TwoArray)}");