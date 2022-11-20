/*
Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

int Prompt(string strMessage)
{
    System.Console.Write(strMessage);
    int temp = int.Parse(System.Console.ReadLine());
    return temp;
}

void PrintPointIntersection(double b1, double k1, double b2, double k2)
{
    if (k1 != k2)
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Прямые пересекаются в точке: ({x:F2}; {y:F2}).");
    }
    else
    {
        if (k1 == k2 && b1 == b2)
        {
            Console.WriteLine($"Прямые совпадают (множество точек пересечения).");
        }
        else if (k1 == k2)
        {
            Console.WriteLine($"Прямые параллельны (не имеют точек пересечения).");
        }
    }
}

double inputK1 = Prompt("Введите значение k1: ");
double inputB1 = Prompt("Введите значение b1: ");
double inputK2 = Prompt("Введите значение k2: ");
double inputB2 = Prompt("Введите значение b2: ");

PrintPointIntersection(inputB1, inputK1, inputB2, inputK2);

