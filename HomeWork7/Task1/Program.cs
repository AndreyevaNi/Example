/*
Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

int Prompt(string strMessage)
{
    System.Console.Write(strMessage);
    int temp = int.Parse(System.Console.ReadLine());
    return temp;
}

double[,] GetArrayOfRandomRealNumbers(int row, int column)
{
    double[,] array = new double[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(-1000, 1000) + new Random().NextDouble();
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:F2}\t");
        }
        Console.WriteLine();
    }
}

int inputRow = Prompt("Введите размерность m (строки, целое положительное число): ");
int inputColumn = Prompt("Введите размерность n (столбцы, целое положительное число): ");
Console.WriteLine();
PrintArray(
    GetArrayOfRandomRealNumbers(inputRow, inputColumn));