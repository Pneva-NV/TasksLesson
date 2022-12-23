// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Введите количество строк: ");
int Str = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов (их должно быть больше, чем строк): ");
int Stb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите диапазон: от 0 до ");
int Range = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] TwoArray = RandomArray(Str, Stb);
int[,] RandomArray(int Str, int Stb)
{
    int[,] TwoArray = new int[Str, Stb];
    for (int i = 0; i < TwoArray.GetLength(0); i++)
    {
        for (int j = 0; j < TwoArray.GetLength(1); j++)
        {
            TwoArray[i, j] = new Random().Next(Range);
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

int SumStr(int[,] TwoArray, int i)
{
  int Sum = TwoArray[i,0];
  for (int j = 1; j < TwoArray.GetLength(1); j++)
  {
    Sum += TwoArray[i,j];
  }
  return Sum;
}

int Index = 0;
int Sum = SumStr(TwoArray, 0);
for (int i = 1; i < TwoArray.GetLength(0); i++)
{
  int box = SumStr(TwoArray, i);
  if (Sum > box)
  {
    Sum = box;
    Index = i;
  }
}

Print(TwoArray);

Console.WriteLine($"\n{Index+1} строкa содержит наименьшую сумму  элементов - {Sum}");