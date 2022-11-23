/*
Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

int GetRowNumberWithMinimumSumOfElements(int[,] array)
{
    int MinSum = 0;
    int rowIndex = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumOfElements = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumOfElements += array[i, j];
        }
        if (i == 0)
        {
            MinSum = sumOfElements;
            rowIndex = i;
        }
        else if (sumOfElements < MinSum)
        {
            MinSum = sumOfElements;
            rowIndex = i;
        }
    }
    return rowIndex;
}

void Execute()
{
    int numberOfRows = Prompt("Укажите количество строк в массиве (целое положительное число): ");
    int numberOfColumns = Prompt("Укажите количество столбцов в массиве (целое положительное число): ");
    int[,] arrayOfNumbwrs = GetArrayOfRandomNumbers(numberOfRows, numberOfColumns);
    PrintArray(arrayOfNumbwrs);
    Console.WriteLine($"\nНомер индекса строки с наименьшей суммой элементов: {GetRowNumberWithMinimumSumOfElements(arrayOfNumbwrs)}");
}
Execute();



