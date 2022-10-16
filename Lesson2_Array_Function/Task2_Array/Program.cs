int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
/*
int a1 = 15;
int b1 = 39;
int c1 = 3;

int a2 = 17;
int b2 = 40;
int c2 = 42;

int a3 = 130;
int b3 = 13;
int c3 = 1;
*/

int [] array ={14,15,16,17,24,25,35,42,89};
array[0] = 12;
Console.WriteLine(array[0]);
/*
int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
*/

int maxM = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]), 
    Max(array[06], array[7], array[8]) 
    );

Console.WriteLine(maxM);


