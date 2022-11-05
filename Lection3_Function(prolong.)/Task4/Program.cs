//сортировка выбором в массиве

int[] arr={1,5,4,3,2,6,7,1,1};

void PrintArr(int[] array)
{
   int count = array.Length;
   for(int i=0; i<count;i++) 
   {
    Console.Write($"{array[i]}");
   }
    Console.WriteLine();
}
// по возрастанию

/*
void SelectionSort(int[] array)
{
 for (int i = 0; i < array.Length - 1; i++)
 {
 int minPosition = i;
 for (int j = i + 1; j < array.Length; j++)
 {
 if (array[j] < array[minPosition])
 {
 minPosition = j;
 }
 }
 int temporary = array[i];
 array[i] = array[minPosition];
 array[minPosition] = temporary;
 }
}
*/
// по убыванию
void SelectionSort(int[] array)
{
 for (int i = 0; i < array.Length - 1; i++)
 {
 int minPosition = i;
 for (int j = i + 1; j < array.Length; j++)
 {
 if (array[j] >array[minPosition])
 {
 minPosition = j;
 }
 }
 int temporary = array[i];
 array[i] = array[minPosition];
 array[minPosition] = temporary;
 }
}

PrintArr(arr);
SelectionSort(arr);
PrintArr(arr);