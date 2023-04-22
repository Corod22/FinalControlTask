Console.WriteLine("Введите размерность массива");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];
void FillArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        arr[i] = Console.ReadLine();
    }
}
string[] NewFillArray(string[] arr)
{
    int n = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
         n++;
    }
  string [] rez = new string [n];
  int j = 0;
  for (int i = 0;i<arr.Length;i++)
  {
    if(arr[i].Length <=3)
    {
        rez[j] = arr[i];
        j++;
    }
  }
  return rez;
}
void PrintArray(string[] arr)
{
    int count = arr.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]}");
        if (i < count - 1) Console.Write(", ");
    }
    Console.Write("]");
}
FillArray(array);
PrintArray(NewFillArray(array));
Console.ReadKey();