// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Введите любое положительное число: ");
int N = Convert.ToInt32(Console.ReadLine());
string N1 = string.Empty;
while (N > 0)
{
    N1 = (N % 2) + N1;
    N = N / 2; 
}
Console.Write(N1);
