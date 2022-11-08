/*
 Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Реализовать через функции.
 Пример:
452 -> 11
82 -> 10
9012 -> 12

*/

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void SumNumbers (int initNum)
{
    int sum = 0;
    while (initNum > 0)
    {
        sum += initNum % 10;
        initNum /= 10;
        
    }
    Console.WriteLine(sum);
 
}
int number = Prompt("Введите целое положительное число: ");
SumNumbers(number);



