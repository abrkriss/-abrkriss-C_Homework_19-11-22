void Zadacha21()
{
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите координато точки 1 по оси x");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координато точки 1 по оси y");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координато точки 1 по оси z");
double z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координато точки 2 по оси x");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координато точки 2 по оси y");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координато точки 2 по оси z");
double z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
Console.WriteLine("Расстояние от точки до точки: " + result);

}
Zadacha21();




