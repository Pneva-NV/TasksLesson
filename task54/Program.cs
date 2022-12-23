// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Введите количество строк: ");
int Str = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int Stb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите нижнее значение диапазона: ");
int Range1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите верхнее значение диапазона: ");
int Range2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] TwoArray = RandomArray(Str, Stb);
int[,] RandomArray(int Str, int Stb)
{
    int[,] TwoArray = new int[Str, Stb];
    for (int i = 0; i < TwoArray.GetLength(0); i++)
    {
        for (int j = 0; j < TwoArray.GetLength(1); j++)
        {
            TwoArray[i, j] = new Random().Next(Range1, Range2);
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

Print(TwoArray);
Console.WriteLine($"\nРезультат: ");


for (int i = 0; i < TwoArray.GetLength(0); i++)
{
    int box = 0;

    for (int k = 0; k < TwoArray.GetLength(1); k++)
        for (int j = 0; j < TwoArray.GetLength(1)-1; j++)

            if ((TwoArray[i, j]) < (TwoArray[i, j + 1]))
            {
                box = TwoArray[i, j];
                TwoArray[i, j] = TwoArray[i, j + 1];
                TwoArray[i, j + 1] = box;
            }
}

Print(TwoArray);