//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//Пример:
//a = 5; b = 7 ->  max = 7, min = 5
//a = -9 b = -3 -> max = -3, min = -9

// *********Начало. Блок ввода двух чисел и преобразование их к вещественному типу*****//
System.Console.WriteLine("Введите первое число");
string inputString = Console.ReadLine();
double Number1 = Convert.ToDouble(inputString);
//inputString = "";
System.Console.WriteLine("Введите первое число");
inputString = Console.ReadLine();
double Number2 = Convert.ToDouble(inputString);
// *********Конец. Блок ввода двух чисел и преобразование их к вещественному типу*****//

if (Number1 > Number2)
{
      System.Console.WriteLine("Число: "+ Number1+ " больше, чем число: " + Number2);

}
else 
{
    System.Console.WriteLine("Число: "+ Number2+ " больше, чем число: " + Number1);
}