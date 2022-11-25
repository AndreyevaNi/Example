/*
Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
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
    return true;
}

int AckermanFunction(int numM, int numN)
{
    if (numM > 0 && numN > 0) return AckermanFunction(numM - 1, AckermanFunction(numM, numN - 1));
    if (numM > 0 && numN == 0) return AckermanFunction(numM - 1, 1);
    return numN + 1;
}

void Execute()
{
    int numberM = Prompt("Введите целое положительное число M: ");
    int numberN = Prompt("Введите целое положительное число N: ");
    if (ValidateNumbers(numberM, numberN))
    {
        Console.Write($"\nВычисления функции Аккермана, заданы числа  M = {numberM} и  N= {numberN}:  {AckermanFunction(numberM, numberN)}");
    }
}
Execute();
