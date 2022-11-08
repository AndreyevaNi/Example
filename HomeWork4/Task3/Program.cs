/*
 Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами. 
 Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах).  
 Реализовать через функции. (* Доп сложность, “введите количество элементов массива”, “Введите минимальный порог случайных значений”, “Введите максимальный порог случайных значений”)
 Пример:
1,2,5,7,19,1,2,8 -> 1,2,5,7,19,1,2,8 -> 8
*/

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void PrintingArrayRandomNumbers(int lenArr, int Min, int Max)
{
    int[] randomArray = new int[lenArr];
    for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = new Random().Next(Min, Max);
        Console.Write(randomArray[i] + " ");
    }

}

int lengthArray = Prompt("Введите количество элементов в масссиве (целое положительное число): ");
int MinRnd = Prompt("Введите минимальный порог случайных значений (целое число): ");
int MaxRnd = Prompt("Введите максимальный порог случайных значений (целое число): ");
Console.Write($"Массив c количеством элементов: {lengthArray}, заполненный случайными числами в диапазоне от {MinRnd} до {MaxRnd} : ");
PrintingArrayRandomNumbers(lengthArray, MinRnd, MaxRnd);