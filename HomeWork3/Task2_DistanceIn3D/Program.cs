/*
 Задача 2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/


double Prompt(string message)
{
    System.Console.Write(message);
    return double.Parse(Console.ReadLine());
}

double x1 = Prompt("Введите x1: ");
double y1 = Prompt("Введите y1: ");
double z1 = Prompt("Введите z1: ");

double x2 = Prompt("Введите x2: ");
double y2 = Prompt("Введите y2: ");
double z2 = Prompt("Введите z2: ");

double x = x1 - x2;
double y = y1 - y2;
double z = z1 - z2;
double Lenght = Math.Sqrt(x * x + y * y + z * z);
Console.WriteLine($"{Lenght:f2}");