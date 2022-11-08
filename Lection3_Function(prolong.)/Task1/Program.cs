/*
//a.	Void.Методы ничего не принимают и не возвр.
void Method1()
{
    Console.WriteLine("Author: N");
}
Method1(); //вызов метода
//b.	Void. Метод, кот. принимает арг. и ничего не возвр.

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg:"Any text"); //вызов метода

//c.	Ничего не приним арг. И возвр (например, случ.числа).
int Method3()
{
    
    return DateTime.Now.Year;
}

int year = Method3(); //вызов метода
Console.WriteLine(year);
//d.	Приним.арг. и возвр.

string Method4(int count, string c)
{
    int i=0;

    string result = string.Empty;
    while (i<count)
    {
        result  = result + c;
        i++;
    }
    return result;
}

string res = Method4(10,"sfshdjffjjf");

////d.	Приним.арг. и возвр. + FOR

string Method5(int count, string c)
{
    string result = string.Empty;
    for (int i = 0; i<count;i++)
    {
        result  = result + c;
        i++;
    }
    return result;
}

string res = Method5(10,"sfshdjffjjf");

*/