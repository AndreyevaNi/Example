/*
 Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/
int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void PalindromeNumber(int number)
{
    number = Math.Abs(number); //Число может быть не только положительным, поэтому берем модуль числа.
    if (number >= 10000 && number < 100000)
    {
        int digitFirst = number / 10000; 
        int digitLast = number % 10;

        if (digitFirst == digitLast)
        {
            number = number / 10;
            int digitFirst2 = (number / 100) % 10;
            int digitLast2 = number % 10;

            if (digitFirst2 == digitLast2)
            {
                System.Console.WriteLine("Да. Число является палиндромом.");
            }
            else
            {
                System.Console.WriteLine("Нет. Число не является палиндромом.");
            }
        }
        else
        {
            System.Console.WriteLine("Нет. Число не является палиндромом.");
        }
    }
    else
    {
        System.Console.WriteLine("Число введено некорректно");
    }
}
PalindromeNumber(Prompt("Введите пятизначное число: "));
