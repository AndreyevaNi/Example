/*
Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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

int[,] SortRowDescendingOrder(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int position = j;
            for (int m = j + 1; m < array.GetLength(1); m++)
            {
                if (array[i, m] > array[i, position]) position = m;
            }
            if (j != position)
            {
                int temp = array[i, j];
                array[i, j] = array[i, position];
                array[i, position] = temp;
            }
        }
    }
    return array;
}

void Execute()
{
    int numberOfRows = Prompt("Укажите количество строк в массиве (целое положительное число): ");
    int numberOfColumns = Prompt("Укажите количество столбцов в массиве (целое положительное число): ");

    int[,] arrayOfNumbwrs = GetArrayOfRandomNumbers(numberOfRows, numberOfColumns);
    PrintArray(arrayOfNumbwrs);

    System.Console.WriteLine();
    PrintArray(
       SortRowDescendingOrder(arrayOfNumbwrs));
}
Execute();
