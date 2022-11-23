/*
Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int Prompt(string strMessage)
{
    System.Console.Write(strMessage);
    int temp = int.Parse(System.Console.ReadLine());
    return temp;
}

int[,] GetArrayOfRandomNumbers(int numRows, int numColumns)
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

int[,] GetMatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return resultMatrix;
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

void Execute()
{
    int numberOfRowsForMatrix1 = Prompt("Укажите количество строк в массиве (целое положительное число): ");
    int numberOfColumnsForMatrix1 = Prompt("Укажите количество столбцов в массиве (целое положительное число): ");
    int[,] arrayOfNumbwrs1 = GetArrayOfRandomNumbers(numberOfRowsForMatrix1, numberOfColumnsForMatrix1);
    PrintArray(arrayOfNumbwrs1);

    int numberOfRowsForMatrix2 = Prompt("Укажите количество строк в массиве (целое положительное число): ");
    int numberOfColumnsForMatrix2 = Prompt("Укажите количество столбцов в массиве (целое положительное число): ");
    int[,] arrayOfNumbwrs2 = GetArrayOfRandomNumbers(numberOfRowsForMatrix2, numberOfColumnsForMatrix2);
    PrintArray(arrayOfNumbwrs2);

    Console.WriteLine();
    if (numberOfColumnsForMatrix1 == numberOfRowsForMatrix2)
    {
        Console.WriteLine();
        PrintArray(
            GetMatrixMultiplication(arrayOfNumbwrs1, arrayOfNumbwrs2));
    }
    else Console.WriteLine("Умножение матриц не будет произведено т.к. число столбцов матрицы 1 не равно числу строк матрицы 2.");
}
Execute();