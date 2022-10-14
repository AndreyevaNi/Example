// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//Пример:
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22


// *********Начало. Блок ввода чисел и преобразование их к вещественному типу*****//
System.Console.WriteLine("Введите первое число");
string inputString = Console.ReadLine();
double Number1 = Convert.ToDouble(inputString);

System.Console.WriteLine("Введите второе число");
inputString = Console.ReadLine();
double Number2 = Convert.ToDouble(inputString);

System.Console.WriteLine("Введите третье число");
inputString = Console.ReadLine();
double Number3 = Convert.ToDouble(inputString);
// *********Конец. Блок ввода  чисел и преобразование их к вещественному типу*****//

double MaxNum = Number1;

if (Number1 > Number2)
{
    MaxNum = Number1;
}
else
{
    MaxNum = Number2;
}

if (MaxNum < Number3)
{
    MaxNum = Number3;
}


System.Console.WriteLine("Введены числа: " + Number1 + ";" + Number2 + ";" + Number3 + ". Наибольшим является: " + MaxNum);