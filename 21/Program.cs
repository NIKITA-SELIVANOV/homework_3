
Console.WriteLine ("Введите х1 для точки 1: ");
 int x1 = Convert.ToInt32(Console.ReadLine() );
 Console.WriteLine("Введите y1 для точки 1: ");
 int y1 = Convert.ToInt32(Console.ReadLine() );
 Console.WriteLine("Введите z1 для точки 1: ");
 int z1 = Convert.ToInt32(Console.ReadLine() );
 Console.WriteLine("Введите х2 для точки 2: ");
 int x2 = Convert.ToInt32(Console.ReadLine() );
 Console.WriteLine("Введите y2 для точки 2: ");
 int y2 = Convert.ToInt32(Console.ReadLine() );
 Console.WriteLine("Введите z2 для точки 2: ");
 int z2= Convert.ToInt32(Console.ReadLine() );

double Distance = Math.Sqrt((x2-x1)*(x2-x1)+(y2 - y1)*(y2 - y1) +(z2-z1)*(z2-z1));
Console.WriteLine ($"Расстояние = {Distance}");