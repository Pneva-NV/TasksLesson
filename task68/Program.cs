// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите значение m (положительное число): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение n (положительное число): ");
int n = Convert.ToInt32(Console.ReadLine());

int FunctionAkker(int m, int n)
{
    if (m==0) return n+1;
    if (m>0 && n==0) return FunctionAkker(m-1, 1);
    if (m>0 && n>0) return  FunctionAkker(m-1, FunctionAkker(m, n-1));
    return  FunctionAkker(m, n);
}

Console.Write($"Функция Аккермана = {FunctionAkker(m, n)}");