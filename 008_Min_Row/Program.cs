void FillArray(int[,] array)
{
    for (int i = 0; i <= array.GetUpperBound(0); i++)
    {
        for (int j = 0; j <= array.GetUpperBound(1); j += 1) array[i,j] = new Random().Next(0,10);
}
}
void PrintArray(int[,] collection)
{
    for (int i = 0; i <= collection.GetUpperBound(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j <= collection.GetUpperBound(1); j += 1) Console.Write(collection[i,j] + "    ");
    }
}
int IndexMin(int[,] array)
{
    int sum = 0;
    int result = 0;
    int min = 0;
    for (int i = 0; i < array.GetUpperBound(0); i += 1)
    {
        sum = 0;
        for (int j = 0; j < array.GetUpperBound(1); j += 1) sum += array[i,j];
        if (i == 0) min = sum;    
        if (sum < min)
        {
            min = sum;
            result = i;
        }
    }
    return result;
}

Console.WriteLine("Введите количество строчек массива");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов массива");
int n = int.Parse(Console.ReadLine() ?? "0");

int[,] massiv = new int[m,n];
FillArray(massiv);
PrintArray(massiv);
Console.WriteLine();


Console.WriteLine($"Строчка с минимальной суммой элементов - {IndexMin(massiv)}");