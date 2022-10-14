/* Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Пример:
4 -> да
-3 -> нет
7 -> нет
*/


System.Console.WriteLine("Введите число");
string inputString = Console.ReadLine();
int Number1 = Convert.ToInt32(inputString);

if (Number1 % 2 ==0)
{
      System.Console.WriteLine("Число "+ Number1+ " является четным");
}
else 
{
    System.Console.WriteLine("Число "+ Number1+ " является нечетным");
}
