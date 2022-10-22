/*
Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать строки для расчета.
645 -> 5
78 -> третьей цифры нет
326792 -> 6
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
        if (number < 100)
        {

            Console.WriteLine("Третьей цифры нет.");
            return false;
        }
        return true;
    }
    else
    {
        if (number > -100)
        {

            Console.WriteLine("Третьей цифры нет.");
            return false;
        }
        return true;
    }
}

int number = Prompt("Введите целое трехзначное число: ");


if (CheckNumber(number))
{
    int tempNumber = number;
    int thirdDigit = 0;

    if (number < 0) //Если введено отрицательное число, то при выводе третьей цифры знак минус убираем
    {

        while (tempNumber < -1000)
        {
            tempNumber = tempNumber / 10;
        }
        thirdDigit = tempNumber % 10 * -1;
    }
    else
    {
        while (tempNumber > 1000) // 
        {
            tempNumber = tempNumber / 10;
        }
        thirdDigit = tempNumber % 10;
    }
    Console.WriteLine($"Третья цифра числа {number} равна {thirdDigit}");
}

