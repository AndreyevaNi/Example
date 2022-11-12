/*
Задача 4 (*) При помощи рекурсии вывести последовательность чисел, с заданым количеством этих чисел по принципу:
Ввожу => 12
1 2 2 3 3 3 4 4 4 4 5 5
*/

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

/** задаем в параметрах:  
     total - заданное кол-во выводимых чисел
     outputDigit - значение выводимого по порядку следования числа(1-выводим 1 раз, 2-выводим 2 раза и тд); 
     counterOutputNumbers - общий счетчик кол-ва цифр (из примера должно быть ровно 12, т.к. одно (кроме единицы) число выводим несколько раз)
 **/
void SequenceOfNumbers(int total, int outputDigit, int counterOutputNumbers)
{
    
        for (int temp = 1; temp <= outputDigit; temp++)
        {
            if (counterOutputNumbers > total) break;
            else counterOutputNumbers++;
            Console.Write(outputDigit + " ");
        }
    if (counterOutputNumbers <= total) SequenceOfNumbers(total, outputDigit + 1, counterOutputNumbers);
    
}

void Execute()
{
    int number = Prompt("Введите целое положительное число, больше 0: ");
    SequenceOfNumbers(number, 1, 1);
}
Execute();