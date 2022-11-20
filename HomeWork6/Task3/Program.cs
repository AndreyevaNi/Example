/*
Задача 3. (*) Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов. 
Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов. 
Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
1 2 3
3 4 5
3+5=8, 1+2+3=6, 8-6=2
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

int GetMaxElementRowSum(int[,] array)
{
    int sumMaxElement = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int maxElement = array[i, 0];
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] > maxElement) maxElement = array[i, j];
        }
        sumMaxElement += maxElement;
    }
    return sumMaxElement;
}

int GetMinElementColumnSum(int[,] array)
{
    int sumMinElement = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int minElement = array[0, j];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            if (array[i, j] < minElement) minElement = array[i, j];
        }
        sumMinElement += minElement;
    }
    return sumMinElement;
}

void PrintResultOfCalculating(int sumMax, int sumMin)
{
    Console.Write($"Сумма максимальных значений по строкам = {sumMax}; сумма минимальных значений по столбцам = {sumMin}; разница = {sumMax - sumMin}.");
}

int numberOfRows = Prompt("Укажите количество строк в матрице (целое положительное число): ");
int numberOfColumns = Prompt("Укажите количество столбцов в матрице (целое положительное число): ");

Console.WriteLine();
int[,] arrayOfRandomIntNumbers = GetArrayOfRandomIntNumbers(numberOfRows, numberOfColumns);
PrintArray(arrayOfRandomIntNumbers);

Console.WriteLine();
PrintResultOfCalculating(GetMaxElementRowSum(arrayOfRandomIntNumbers), GetMinElementColumnSum(arrayOfRandomIntNumbers));