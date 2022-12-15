// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

Console.Write("Введите количество строк: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int post = Convert.ToInt32(Console.ReadLine());
int[,] TwoArray = Index(line, post);

int[,] Index(int line, int post)
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

void EvenSquare(int[,] TwoArray)
{
    for (int i = 0; i < TwoArray.GetLength(0); i++)
    {
        for (int j = 0; j < TwoArray.GetLength(1); j++)
            if (i % 2 == 0 && j % 2 == 0)
            {
                TwoArray[i, j] *= TwoArray[i, j];
            }
    }
}

Print(TwoArray);
EvenSquare(TwoArray);
Console.WriteLine();
Print(TwoArray);