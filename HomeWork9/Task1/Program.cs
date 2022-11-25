/*
Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"
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

void OutputOfEvenNumbersBetweenMN(int numM, int numN)
{
    if (numM <= numN)
    {
        if (numM % 2 != 0)
        {
            OutputOfEvenNumbersBetweenMN(numM + 1, numN);
        }
        else
        {
            Console.Write($"{numM} ");
            OutputOfEvenNumbersBetweenMN(numM + 2, numN);
        }

    }
}

void Execute()
{
    int numberM = Prompt("Введите нижнюю границу диапазона (целое положительное число) M: ");
    int numberN = Prompt("Введите верхнюю границу диапазона (целое положительное число) N: ");
    if (ValidateNumbers(numberM, numberN))
    {
        Console.WriteLine($"\nЧетными числами в дапазоне от M = {numberM} до N = {numberN} являются:");
        OutputOfEvenNumbersBetweenMN(numberM, numberN);
    }
}
Execute();