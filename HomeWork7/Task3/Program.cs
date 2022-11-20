/*
Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int Prompt(string strMessage)
{
    System.Console.Write(strMessage);
    int temp = int.Parse(System.Console.ReadLine());
    return temp;
}

int[,] GetArrayOfRandomIntNumbers(int numRows, int numColumns)
{
    int[,] array = new int[numRows, numColumns];
    for (int i = 0; i < numRows; i++)
    {
        for (int j = 0; j < numColumns; j++)
        {
            array[i, j] = new Random().Next(-10, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

double[] GetArithmeticMeanElementsInColumn(int[,] array)
{
    double[] arithmeticMean = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        arithmeticMean[j] = sum / array.GetLength(0);
    }
    return arithmeticMean;
}

void PrintArithmeticMeanElementsInColumn(double[] array)
{
    Console.WriteLine("Cреднее арифметическое элементов в каждом столбце: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{array[i]:F2}\t");
    }
}

int numberOfRows = Prompt("Укажите количество строк в массиве (целое положительное число): ");
int numberOfColumns = Prompt("Укажите количество столбцов в массиве (целое положительное число): ");

Console.WriteLine();
int[,] arrayOfRandomIntNumbers = GetArrayOfRandomIntNumbers(numberOfRows, numberOfColumns);
PrintArray(arrayOfRandomIntNumbers);

Console.WriteLine();
PrintArithmeticMeanElementsInColumn(
    GetArithmeticMeanElementsInColumn(arrayOfRandomIntNumbers));
