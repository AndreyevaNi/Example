/*
Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. Не использовать строки для расчета.
456 -> 46
782 -> 72
918 -> 98

*/

//Начало. Определние случайного трехзначного числа, которое может быть как отрицательным, так и положительным
int randomNumber = new Random().Next(100, 1000);
int randomNnumber1 = new Random().Next(-1000, -100);
int randomTemp = new Random().Next(0, 2);
int number = -1;
switch (randomTemp)
{
    case 0: number = randomNumber; break;
    case 1: number = randomNnumber1; break;

}
//Конец. Определние случайного трехзначного числа, которое может быть как отрицательным, так и положительным

    int digit3 = number % 10;
    int digit1 = number / 100;
    int number2 = digit1 * 10 + digit3;
Console.WriteLine($"Исходное число: {number} Число после преобразования: {number2}");
