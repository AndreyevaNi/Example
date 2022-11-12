/*
Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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



int[] ArrayRandomNumbers(int lenArr, int Min, int Max)
{
    int[] randomArray = new int[lenArr];
    for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = new Random().Next(Min, Max);
    }
    return randomArray;
}

int SumOfElementsOnUnevenPos(int[] array)
{
    int sumElements = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) sumElements = sumElements + array[i];
    }
    return sumElements;

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
    int minRnd = Prompt("Введите минимальный порог случайных значений (целое число): ");
    int maxRnd = Prompt("Введите максимальный порог случайных значений (целое число): ");
    Console.WriteLine();

    if (CheckParameters(lengthArray))
    {
        Console.Write($"Массив c количеством элементов: {lengthArray}, заполненный случайными числами в диапазоне от {minRnd} до {maxRnd} : ");
        Console.WriteLine();

        int[] tempArr = ArrayRandomNumbers(lengthArray, minRnd, maxRnd);
        PrintArray(tempArr);
        Console.WriteLine();
        Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях в массиве:  {SumOfElementsOnUnevenPos(tempArr)}");
    }
    else
    {
        Console.WriteLine("Введенные параметры для создания массива некорректны. Повторите попытку.");
    }
}
Execute();