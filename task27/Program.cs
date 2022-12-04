// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите любое положительное число: ");
int N = Convert.ToInt32(Console.ReadLine());
int Sum = 0;
for (int i = 0; i <= 10; i++)
{
    int U = N % 10;
    N = N / 10;
    Sum = Sum + U;
}
Console.WriteLine($"{Sum}");