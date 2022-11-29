// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите значение x для точки А: ");
int xА = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение y для точки А: ");
int yА = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение z для точки А: ");
int zА = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение x для точки B: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение y для точки B: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение z для точки B: ");
int zB = Convert.ToInt32(Console.ReadLine());

int Dx = xА - xB;
double Dxs = Math.Pow(Dx, 2);

int Dy = yА - yB;
double Dys = Math.Pow(Dy, 2);

int Dz = zА - zB;
double Dzs = Math.Pow(Dz, 2);

double D = Dxs + Dys + Dzs;

double AB = Math.Sqrt(D);
double resolt = Math.Round(AB, 2);

Console.WriteLine($"AB = {resolt}");