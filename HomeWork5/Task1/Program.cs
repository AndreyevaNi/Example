/*
Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

bool CheckParameters(int len, int min, int max)
{
    return (len > 0) && (min > 0) && (max > 0) && (min > 99 && min < 1000) && (max > 99 && max < 1000) && (min <= max);
}

int[] ArrayRandomNumbers(int lenArr, int Min, int Max)
{
    int[] randomArray = new int[lenArr];
    for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = new Random().Next(Min, Max);
    }
    return randomArray;
}

int CountEvenDigits(int[] array)
{
    int even = 0; 
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) even++;
    }
    return even;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void Execute()
{
    int lengthArray = Prompt("Введите количество элементов в масссиве (целое положительное число больше 0): ");
    int minRnd = Prompt("Введите минимальный порог случайных значений (целое положительное трёхзначное число): ");
    int maxRnd = Prompt("Введите максимальный порог случайных значений (целое положительное трёхзначное число): ");
    Console.WriteLine();
    if (CheckParameters(lengthArray, minRnd, maxRnd))
    {
        Console.Write($"Массив c количеством элементов: {lengthArray}, заполненный случайными числами в диапазоне от {minRnd} до {maxRnd} : ");
        Console.WriteLine();

        int[] tempArr = ArrayRandomNumbers(lengthArray, minRnd, maxRnd);
        PrintArray(tempArr);
        Console.WriteLine();
        Console.WriteLine($"Количество четных чисел {CountEvenDigits(tempArr)}");
    }
    else
    {
        Console.WriteLine("Введенные параметры для создания массива некорректны. Повторите попытку.");
    }
}
Execute();