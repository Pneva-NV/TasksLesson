// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// int[,] TwoArray = new int[3, 4];
// for (int i = 0; i < TwoArray.GetLength(0); i++)
// {
//     for (int j = 0; j < TwoArray.GetLength(1); j++)
//     {
//         TwoArray[i, j] = i + j;
//         Console.Write($"{TwoArray[i, j]} ");
//     }
//     Console.WriteLine();
// }

Console.Write("Введите количество строк: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int post = Convert.ToInt32(Console.ReadLine());
int[,] TwoArray = SumEl(line, post);
PrintSumEl(TwoArray);

int[,] SumEl(int line, int post)
{
    int[,] TwoArray = new int[line, post];
    for (int i = 0; i < TwoArray.GetLength(0); i++)
    {
        for (int j = 0; j < TwoArray.GetLength(1); j++)
        {
            TwoArray[i, j] = i + j;
        }
    }
    return TwoArray;
}
void PrintSumEl(int[,]TwoArray)
{
    for (int i=0; i < TwoArray.GetLength(0); i++)
    {
       for (int j = 0; j < TwoArray.GetLength(1); j++) 
       Console.Write($"{TwoArray[i, j]} ");
       Console.WriteLine();
    }
}