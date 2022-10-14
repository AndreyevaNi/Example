//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//Пример:
//a = 5; b = 7 ->  max = 7, min = 5
//a = -9 b = -3 -> max = -3, min = -9

// *********Начало. Блок ввода двух чисел и преобразование их к вещественному типу*****//
System.Console.WriteLine("Введите первое число");
string inputString = Console.ReadLine();
double Number1 = Convert.ToDouble(inputString);

System.Console.WriteLine("Введите второе число");
inputString = Console.ReadLine();
double Number2 = Convert.ToDouble(inputString);

// *********Конец. Блок ввода двух чисел и преобразование их к вещественному типу*****//

if (Number1 > Number2)
{
    System.Console.WriteLine("Max: " + Number1 + " Min: " + Number2);

}
else
{
    System.Console.WriteLine("Max: " + Number2 + " Min: " + Number1);
}