//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] Ar = new double[5];
for (int i = 0; i < Ar.Length; i++)
{
    Ar[i] = new Random().NextDouble() / 1;
    Ar[i] = Math.Round(Ar[i], 2);
    Console.Write($"{Ar[i]}  ");
}
Console.WriteLine();

double[] Sort = Ar;
Array.Sort(Sort);
foreach (double n in Sort) 
Console.Write( n  + " ");  
Console.WriteLine();
Console.Write( $"{Sort[4] - Sort[0]} "); 

