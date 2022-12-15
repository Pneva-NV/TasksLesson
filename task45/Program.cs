// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] N = new int[6];
int[] copy = new int[6];
for (int i = 0; i < N.Length; i++)
{
    N[i] = new Random().Next(0, 10);
    N = copy;
    Console.Write($"{N[i]}-");
    
    Console.Write($"{copy[i]}  ");
}



