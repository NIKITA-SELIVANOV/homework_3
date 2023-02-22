
Console.WriteLine("введите координаты первой точки ");
Console.Write("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координаты второй точки ");
Console.Write("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());


double distance = Distance (x1, y1, z1, x2, y2, z2);
double distance1 = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками {distance1}");



double Distance (int a1, int b1,int c1, int a2, int b2, int c2)
{
double result = Math.Sqrt(Math.Pow((a2-a1), 2) + Math.Pow((b2-b1), 2)+ Math.Pow((c2-c1), 2));
return result;
}