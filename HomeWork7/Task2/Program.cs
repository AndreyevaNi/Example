/*
Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1,7 -> такого числа в массиве нет
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

void PrintElementOfArray(int rowIndex, int columnIndex, double[,] array)
{
    if (rowIndex >= array.GetLength(0) || columnIndex >= array.GetLength(1))
    {
        Console.WriteLine("Элемент отсутствует в заданном массиве");
    }
    else
    {
        Console.WriteLine($"По заданным условиям найден элемент в массиве: {array[rowIndex, columnIndex]:F2}");
    }
}

int numberOfRows = Prompt("Укажите количество строк в массиве (целое положительное число): ");
int numberOfColumns = Prompt("Укажите количество столбцов в массиве (столбцы, целое положительное число): ");
Console.WriteLine();

double[,] arrayOfRandomRealNumbers = GetArrayOfRandomRealNumbers(numberOfRows, numberOfColumns);
PrintArray(arrayOfRandomRealNumbers);
Console.WriteLine();

int rowNumber = Prompt("Введите индекс элемента по строке (целое положительное число): ");
int columnNumber = Prompt("Введите индекс элемента по столбцу (целое положительное число): ");
Console.WriteLine();

PrintElementOfArray(rowNumber, columnNumber, arrayOfRandomRealNumbers);