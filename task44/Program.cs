// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Введите любое положительное число: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] Fib = new int[N+2];
Fib[0] = 0;
Fib[1] = 1;
for (int i = 0; i < N; i++)
{
    Fib[i + 2] = Fib[i] + Fib[i + 1];
    Console.Write($"{Fib[i]} ");
}
