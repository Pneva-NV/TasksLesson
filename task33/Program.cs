// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 19; массив [6, 7, 19, 345, 3] -> да

Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
int[] array = { 6, 7, 19, 345, 3 };
bool Num = false;
foreach (var N in array)
{
    if (N == A)
    {
        Num = true;
    }
}
if (Num) Console.Write($"В массиве присутствует введенное число");
else Console.Write($"В массиве отсутствует введенное число");