/*
Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Не использовать строки для расчета.
456 -> 5
782 -> 8
918 -> 1
*/

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool CheckNumber(int number)
{
    if (number >= 0)  // Введенное число может быть и отрицательным и положительным.
    {
        if (number < 100 || number >= 1000)
        {

            Console.WriteLine("Введенное число не трехзначное. Введите корректно число.");
            return false;
        }
        return true;
    }
    else
    {
        if (number > -100 || number <= -1000)
        {

            Console.WriteLine("Введенное число не трехзначное. Введите корректно число.");
            return false;
        }
        return true;
    }
}

int number = Prompt("Введите целое трехзначное число: ");

if (CheckNumber(number))
{

    int temp = number / 10;
    int secondDigit = temp % 10;
    if (secondDigit < 0) //Если введено отрицательное число, то при выводе второй цифры знак минус убираем
    {
        secondDigit = secondDigit * -1;
    }
    Console.WriteLine($"Вторая цифра числа {number} равна {secondDigit}");
}
