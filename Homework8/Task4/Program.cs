/*
Задача 4. (*) Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int Prompt(string strMessage)
{
    System.Console.Write(strMessage);
    int temp = int.Parse(System.Console.ReadLine());
    return temp;
}

int[,] GetArrayIsFilledInSpiral(int numRowsEqualToСolumns)
{
    int[,] array = new int[numRowsEqualToСolumns, numRowsEqualToСolumns];
    int element = 1;
    int i = 0;
    int j = 0;
    int sizeArray = numRowsEqualToСolumns * numRowsEqualToСolumns;
    while (element <= sizeArray)
    {
        array[i, j] = element;
        element++;
        if (i <= j + 1 && i + j < array.GetLength(1) - 1) j++;
        else if (i < j && i + j >= array.GetLength(0) - 1) i++;
        else if (i >= j && i + j > array.GetLength(1) - 1) j--;
        else i--;
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

void Execute()
{
    int numberOfRows = Prompt("Укажите количество строк в массиве (целое положительное число): ");
    PrintArray(
     GetArrayIsFilledInSpiral(numberOfRows));
}
Execute();



