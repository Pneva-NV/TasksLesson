// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите количество строк: ");
int Str = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int Stb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите любое целое число: ");
int Item = Convert.ToInt32(Console.ReadLine());

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

void Position(int[,] TwoArray)
{
    int box = 0;
    for (int i = 0; i < TwoArray.GetLength(0); i++)
    {
        for (int j = 0; j < TwoArray.GetLength(1); j++)
        {
            if (TwoArray[i, j] == Item) box = box + 1;
        }
    }
    if (box > 0) Console.Write($"{Item} -> такое число есть в массиве ");
    else Console.Write($"{Item} -> такого числа нет в массиве ");
}

Print(TwoArray);
Position(TwoArray);