// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] N = new int[6];
int box = 0;
for (int i = 0; i < N.Length; i++)
{
    N[i] = new Random().Next(0, 10);
    Console.Write($"{N[i]} ");
}
Console.WriteLine();
for (int i = 0; i < N.Length / 2; i++)
{
    box = N[N.Length - i - 1];
    N[N.Length - i - 1] = N[i];
    N[i] = box;
    Console.Write($"{N[i]} ");
}
Console.WriteLine();
for (int i = 0; i < N.Length; i++)
{
    Console.Write($"{N[i]} ");
}

// Console.WriteLine();
// Array.Reverse(N);
// Console.Write(String.Join(',', N));
