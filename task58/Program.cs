// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите количество строк: ");
int Str = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int Stb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите нижнее значение диапазона: ");
int Range1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите верхнее значение диапазона: ");
int Range2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] OneArray = RandomOneArray(Str, Stb);
int[,] TwoArray = RandomOneArray(Str, Stb);
int[,] RandomOneArray(int Str, int Stb)
{
    int[,] Array = new int[Str, Stb];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(Range1, Range2);
        }
    }
    return Array;
}

void Print(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
            Console.Write($"{Array[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] ThreeArray = new int[Str, Stb];
for (int i = 0; i < ThreeArray.GetLength(0); i++)
{
    for (int j = 0; j < ThreeArray.GetLength(1); j++)
    {int box = 0;
        for (int k = 0; k < OneArray.GetLength(1); k++)
        {
           box += OneArray[i, k] * TwoArray[k, j];
        }
        ThreeArray[i, j] = box;
    }
}

Print(OneArray);
Print(TwoArray);
Print(ThreeArray);