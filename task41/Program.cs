// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.Write("Введите количество элементов массива: ");
int Len = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[Len];
int S = 0;
for (int i = 0; i < Array.Length; i++)
{
    Console.Write("Введите элемент массива: ");
    Array[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i] > 0)
        S = S + 1;
    Console.Write($"{Array[i]} ");
}

Console.Write($"-> {S} ");