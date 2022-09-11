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

double SrArifmeth(int[,] collection,int i)
{
    double result = 0;
    for (int j = 0; j <= collection.GetUpperBound(0); j++) result += collection[j,i];
    result = result / (collection.GetUpperBound(0) + 1);
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
for (int i = 0; i <= massiv.GetUpperBound(1); i += 1)
{
    Console.WriteLine($"Среднее арифметическое {i+1}ой коллоны = {SrArifmeth(massiv,i)}");
}