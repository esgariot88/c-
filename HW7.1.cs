int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
double[,] array = new double[rows, columns];
FillArray(array);
PrintArray(array);


void FillArray(double[,] array)
{
for (int i = 0; i < array.GetLength(0); i++) 
{
for (int j = 0; j < array.GetLength(1); j++) 
{
array[i,j] = new Random().NextDouble() * 20 - 10;
}
}
}

void PrintArray(double[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write(array[i, j] + " ");
}
Console.WriteLine();
}
Console.WriteLine();
}

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}
