/*
Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

bool CheckParameters(int len)
{
    return len > 0;
}

double[] ArrayRandomNumbers(int lenArr)
{
    double[] randomArray = new double[lenArr];
    for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = new Random().Next(-10, 10) + new Random().NextDouble();
    }
    return randomArray;
}

double DiffBetweenMaxAndMinValues(double[] array)
{
    return array.Max() - array.Min();
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]:F2} ");
    }
}

void Execute()
{
    int lengthArray = Prompt("Введите количество элементов в масссиве (целое положительное число больше 0): ");
    Console.WriteLine();
    if (CheckParameters(lengthArray))
    {
        Console.Write($"Массив c количеством элементов: {lengthArray}, заполненный случайными вещественными числами: ");
        Console.WriteLine();

        double[] tempArr = ArrayRandomNumbers(lengthArray);
        PrintArray(tempArr);
        Console.WriteLine();
        Console.WriteLine($"Разница между максимальным и минимальным элементом массива составила:  {DiffBetweenMaxAndMinValues(tempArr):F2}");
    }
    else
    {
        Console.WriteLine("Введенные параметры для создания массива некорректны. Повторите попытку.");
    }
}
Execute();