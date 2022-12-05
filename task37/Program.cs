// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] N = new int[10];
for (int i = 0; i < N.Length; i++)
{
    N[i] = new Random().Next(0, 10);
}

int[] copy = new int[N.Length];
Array.Copy(N, copy, N.Length);
Console.WriteLine(String.Join(", ", copy));

Array.Reverse(copy);
Console.WriteLine(String.Join(", ", copy));

int[] Par = new int[5];
for (int i = 0; i < 5; i++)
{
    Par[i] = N[i] * copy[i];
}
Console.WriteLine(String.Join(", ", Par));