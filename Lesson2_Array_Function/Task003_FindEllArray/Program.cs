int[] array = { 14, 15, 16, 17, 24,4, 25, 35, 42, 89 };
int n = array.Length;
int find = 4;
int index = 0;

while (index < n)
{

    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }

    index = index++;
}