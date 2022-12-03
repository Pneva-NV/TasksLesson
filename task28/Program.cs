// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите число любое положительное число: ");
int A = Convert.ToInt32(Console.ReadLine());
int Pr = 1;
for (int i = 1; i <= A; i++)
{
    Pr = Pr * i;
}
Console.WriteLine($"{Pr}");