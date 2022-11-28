// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Write("Введите значение x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение y: ");
int y = Convert.ToInt32(Console.ReadLine());
int P1 = 1;
if (x > 0 && y > 0)
{
    Console.WriteLine($"плоскость - {P1}");
}
int P2 = 2;
if (x < 0 && y > 0)
{
    Console.WriteLine($"плоскость - {P2}");
}
int P3 = 3;
if (x < 0 && y < 0)
{
    Console.WriteLine($"плоскость - {P3}");
}
int P4 = 4;
if (x > 0 && y < 0)
{
    Console.WriteLine($"плоскость - {P4}");
}