/*
Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да 
7 -> да 
1 -> нет
*/


int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool CheckNumber(int number)
{
    if (number < 1 || number > 7)
    {

        Console.WriteLine("Некорректно введен номер дня недели.");
        return false;
    }
    return true;

}

int number = Prompt("Введите  номер дня недели (значение в диапазоне от 1 до 7): ");

if (CheckNumber(number))
{
    if (number > 5)
    {
        Console.WriteLine($"Является ли день с номером  {number} выходным днем? Ответ: Да, является.");
    }
    else
    {
        Console.WriteLine($"Является ли день с номером  {number} выходным днем? Ответ: Нет, не является.");
    }
}
