// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] TwoArray = new int[4, 4];
int box = 1;
int i = 0;
int j = 0;

while (box <= TwoArray.GetLength(0) * TwoArray.GetLength(1))
{
    TwoArray[i, j] = box;
    box++;
    if (i <= j + 1 && i + j < TwoArray.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= TwoArray.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > TwoArray.GetLength(1) - 1)
        j--;
    else
        i--;
}

void Print(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            if (Array[i, j] / 10 <= 0)
                Console.Write($"{"0"+ Array[i, j]}  ");
            else Console.Write($"{Array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

Print(TwoArray);