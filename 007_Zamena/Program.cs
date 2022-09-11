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
void Zamena(int[,] array)
{
    int x = 0;
    for (int i = 0; i <= array.GetUpperBound(0); i++)
    {
        for (int j = i+1; j <= array.GetUpperBound(0); j++)
        {
            x = array[i,j];
            array[i,j] = array[j,i];
            array[j,i] = x;
        }
    }
}

Console.WriteLine("Введите количество строчек массива");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов массива");
int n = int.Parse(Console.ReadLine() ?? "0");

int[,] massiv = new int[m,n];
FillArray(massiv);
PrintArray(massiv);
Console.WriteLine();

if (m == n)
{
    Zamena(massiv);
}
else Console.WriteLine("Замена невозможна, массив не квадратный, получайте его обратно:");
PrintArray(massiv);