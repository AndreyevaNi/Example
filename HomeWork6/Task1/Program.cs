/*
Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
int Prompt(string strMessage)
{
    System.Console.Write(strMessage);
    int temp = int.Parse(System.Console.ReadLine());
    return temp;
}

int[] GetArray(int countNumber)
{
    int[] tempArray = new int[countNumber];
    for (int i = 0; i < countNumber; i++)
    {
        tempArray[i] = Prompt("Введите целое число: ");
    }
    return tempArray;
}

int GetCountOfPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count += 1;
    }
    return count;
}

int inputCountOfNumber = Prompt("Задайте общее количество чисел, которое хотите ввести (целое положительное число): ");
int[] arrayOfInputNumbers = GetArray(inputCountOfNumber);
Console.WriteLine();
Console.WriteLine($"Количество чисел больше 0: {GetCountOfPositiveNumbers(arrayOfInputNumbers)}");
