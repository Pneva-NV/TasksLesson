// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер честверти плоскости (от 1 до 4): ");
int P = Convert.ToInt32(Console.ReadLine());

if (P == 1)
{
        Console.WriteLine($"диапазон возможных координат точек на плоскости: х и У > 0");
}

if (P == 2)
{
        Console.WriteLine($"диапазон возможных координат точек на плоскости: х < 0, а У > 0");
}

if (P == 3)
{
        Console.WriteLine($"диапазон возможных координат точек на плоскости: х и У < 0");
}

if (P == 4)
{
        Console.WriteLine($"диапазон возможных координат точек на плоскости:  х > 0, а У < 0");
}