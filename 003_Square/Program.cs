void FillArray(int[,] array)
{
    for (int i = 0; i <= array.GetUpperBound(0); i++)
    {
        for (int j = 0; j <= array.GetUpperBound(1); j += 1) array[i,j] = new Random().Next(0,21);
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

void SquareArray(int[,] array)
{
    for (int i = 0; i <= array.GetUpperBound(0); i += 2)
    {
        for (int j = 0; j <= array.GetUpperBound(1); j += 2) array[i,j] = array[i,j]*array[i,j];
    }
}


Console.WriteLine("Введите количество строчек массива");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов массива");
int n = int.Parse(Console.ReadLine() ?? "0");

int[,] massiv = new int[m,n];
FillArray(massiv);
Console.ForegroundColor = ConsoleColor.Red;
PrintArray(massiv);
SquareArray(massiv);
Console.ForegroundColor = ConsoleColor.Green;
PrintArray(massiv);
Console.ResetColor();