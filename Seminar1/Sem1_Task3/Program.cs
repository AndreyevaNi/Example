System.Console.WriteLine("Введите число");
string inputString = Console.ReadLine();
int Number = Convert.ToInt32(inputString);
int count = Number * -1;

while (count < Number)
{
    System.Console.Write(count + " ");
    count++;

}

