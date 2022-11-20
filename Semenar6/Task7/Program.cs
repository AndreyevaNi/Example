/*
Используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/
// Написать последовательность 1,...n
int Prompt(string msg)
{
    Console.WriteLine(msg);
    int length = Convert.ToInt32(Console.ReadLine());
    return length;
}
void Seq (int n)
{
    if (n <=0)
    {
        return;
    }
    Seq(n-1);
    Console.Write($" {n} ");
}
Seq(5);
