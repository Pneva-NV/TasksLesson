// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.Write("Введите значение x для точки А: ");
int xА = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение y для точки А: ");
int yА = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение x для точки B: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение y для точки B: ");
int yB = Convert.ToInt32(Console.ReadLine());

int Dx = xА - xB;
double Dxs = Math.Pow(Dx, 2);

int Dy = yА - yB;
double Dys = Math.Pow(Dy, 2);

double D = Dxs + Dys;

double AB = Math.Sqrt(D);
double resolt = Math.Round(AB, 2);

Console.WriteLine($"AB = {resolt}");