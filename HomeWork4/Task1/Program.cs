/*
 Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Реализовать через функции.
 Пример:
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void RaiseToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}

while (true)  //цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
{
int numA = Prompt("Введите целое положительное число A: ");
int numB = Prompt("Введите целое положительное число B: ");
RaiseToDegree(numA, numB);
}
