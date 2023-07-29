// Задача 21
// Напишите программу, которая
// 1. принимает на вход координаты двух точек и 
// 2.находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты первой точки: ");
Console.Write("X: ");
int x1Coordinat = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y1Coordinat = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int z1Coordinat = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки: ");
Console.Write("X: ");
int x2Coordinat = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y2Coordinat = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int z2Coordinat = Convert.ToInt32(Console.ReadLine());

double result = Math.Round(DistanceThree(x1Coordinat, x2Coordinat, y1Coordinat, y2Coordinat, z1Coordinat, z2Coordinat), 2);
Console.WriteLine(result);

double DistanceThree(int x1, int x2, int y1, int y2,int z1, int z2)
{
    int coord1 = x1 - x2 ;
    int coord2 = y1 - y2 ;
    int coord3 = z1 - z2 ;
    double result = Math.Sqrt(coord1*coord1 + coord2* coord2 + coord3* coord3);
    return result;
}