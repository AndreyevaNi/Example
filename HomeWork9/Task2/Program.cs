/*
Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8 -> 30
*/

int Prompt(string strMessage)
{
    System.Console.Write(strMessage);
    int temp = int.Parse(System.Console.ReadLine());
    return temp;
}

bool ValidateNumbers(int numM, int numN)
{
    if (numM < 0 || numN < 0)
    {
        Console.WriteLine("\nЗначения диапазона должны быть положительными числами ");
        return false;
    }
    if (numM > numN)
    {
        Console.WriteLine($"\nНижняя граница диапазона M = {numM} должна быть меньше верхней границы N = {numN}");
        return false;
    }
    return true;
}

void OutputSumOfNumbers(int numM, int numN, int sumNumbers)
{
    if (numM <= numN)
    {
        sumNumbers += numM;
        OutputSumOfNumbers(numM + 1, numN, sumNumbers);
    }
    else
    {
        Console.Write(sumNumbers);
    }
}

void Execute()
{
    int numberM = Prompt("Введите нижнюю границу диапазона (целое положительное число) M: ");
    int numberN = Prompt("Введите верхнюю границу диапазона (целое положительное число) N: ");
    if (ValidateNumbers(numberM, numberN))
    {
        int sumNum = 0;
        Console.Write($"\nСумма натуральных элементов в промежутке от M = {numberM} до N = {numberN}: ");
        OutputSumOfNumbers(numberM, numberN, sumNum);
    }
}
Execute();