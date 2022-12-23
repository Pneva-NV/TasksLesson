// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] ThreeDArray = new int[2, 2, 2];

void CreateArray(int[,,] ThreeDArray)
{
    int[] box = new int[ThreeDArray.GetLength(0) * ThreeDArray.GetLength(1) * ThreeDArray.GetLength(2)];
    int number;
    for (int i = 0; i < box.GetLength(0); i++)
    {
        box[i] = new Random().Next(10, 100);
        number = box[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (box[i] == box[j])
                {
                    box[i] = new Random().Next(10, 100);
                    j = 0;
                    number = box[i];
                }
                number = box[i];
            }
        }
    }
    int count = 0;
    for (int i = 0; i < ThreeDArray.GetLength(0); i++)
    {
        for (int j = 0; j < ThreeDArray.GetLength(1); j++)
        {
            for (int k = 0; k < ThreeDArray.GetLength(2); k++)
            {
                ThreeDArray[i, j, k] = box[count];
                count++;
            }
        }
    }
}

void Print(int[,,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            for (int k = 0; k < Array.GetLength(2); k++)
            {
                Console.Write($"{Array[i, j, k]} ({i}, {j}, {k})     ");
            }
            Console.WriteLine();
        }
    }
}

CreateArray(ThreeDArray);
Print(ThreeDArray);