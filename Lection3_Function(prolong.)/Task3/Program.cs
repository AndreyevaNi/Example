string text_ = "По строке 030 в соответствующих графах отражаются суммы выплат и иных вознаграждений," 
+ "начисленных в пользу физических лиц в соответствии со статьей 420 Кодекса, нарастающим итогом с начала"
+" расчетного периода, а также за первый, второй и третий месяц из последних трех месяцев расчетного (отчетного) периода соответственно.";

string Replace (string text, char oldValue, char newValue)

{

    string result = String.Empty;
    int length = text.Length;

for (int i = 0; i< length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result+ $"{text_[i]}";
      
    }
return result;
}
string newText = Replace(text_,' ','|');

Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text_,'к','К');
