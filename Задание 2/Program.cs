/*Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве*/

double distance3D (double X1, double Y1, double X2, double Y2, double Z1, double Z2)
{
    return Math.Sqrt((X2 - X1) * (X2 - X1) + (Y2 - Y1) * (Y2 - Y1) + (Z2 - Z1) * (Z2 - Z1));
}
Console.Write("Введите координату X первой точки: ");
double X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y первой точки: ");
double Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z первой точки: ");
double Z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату X второй точки: ");
double X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y второй точки: ");
double Y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z второй точки: ");
double Z2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Расстояние между точками в 3D: " + distance3D (X1, Y1, X2, Y2, Z1, Z2));