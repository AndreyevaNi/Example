System.Console.WriteLine("Введите номер дня недели"); //выводим подсказку на экран
string inputString = Console.ReadLine(); //получаем строку с консоли
int dayOfWeek = Convert.ToInt32(inputString ); //конвертируем к целому типу

if (dayOfWeek == 1)
{
      Console.WriteLine("Понедельник" );
}
if (dayOfWeek == 2)
{
      Console.WriteLine("Вторник" );
}
if (dayOfWeek == 3)
{
      Console.WriteLine("Среда" );
}

if (dayOfWeek == 4)
{
      Console.WriteLine("Четверг" );
}
if (dayOfWeek == 5)
{
      Console.WriteLine("Пятница" );
}
if (dayOfWeek == 6)
{
      Console.WriteLine("Суббота" );
}
if (dayOfWeek == 7)
{
      Console.WriteLine("Воскресенье" );
}
else
{
    Console.WriteLine("Неправильно. нет такого дня" );
}