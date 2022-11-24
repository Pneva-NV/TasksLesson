// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Напишите любой день недели числом от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 3)
{
    Console.WriteLine($"День недели - среда");
}

if (day == 5)
{
    Console.WriteLine($"День недели - пятница");
}

if (day == 1)
{
    Console.WriteLine($"День недели - неопознан");
}


if (day == 2)
{
    Console.WriteLine($"День недели - неопознан");
}

if (day == 4)
{
    Console.WriteLine($"День недели - неопознан");
}

if (day == 6)
{
    Console.WriteLine($"День недели - неопознан");
}


if (day == 7)
{
    Console.WriteLine($"День недели - неопознан");
}

if (day > 7)
{
    Console.WriteLine($"Ошибка. Введенное число не входит в указанный диапазон");
}