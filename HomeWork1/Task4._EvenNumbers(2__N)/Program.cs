/* Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Пример:
5 -> 2, 4
8 -> 2, 4, 6, 8
*/


System.Console.Write("Введите число больше 0: ");
string inputString = Console.ReadLine();
int Number1 = Convert.ToInt32(inputString);

int EvenNum = 1;
while (EvenNum <= Number1)
{
    if (EvenNum % 2 == 0)
    {
        System.Console.Write(EvenNum);
        if (EvenNum < Number1 - 1)
        {
            System.Console.Write(", "); //Вывод разделителя, если значение не последнее
        }
    }

    EvenNum++;

}