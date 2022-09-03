int rows = 3;
int columns = 4;
int index1 = ReadInt("Введите индекс строки: ");
int index2 = ReadInt("Введите индекс стобца: ");
int[,] array = new int[rows, columns];
FillArray(array);
PrintArray(array);

for (int i = 0; i < array.GetLength(0); i++) 
    
    for (int j = 0; j < array.GetLength(1); j++) 
    {
        if (i==index1 && j==index2)
        {
            Console.WriteLine(array.GetValue(index1,index2));
            return;
           
        }
        else 
        {
             Console.WriteLine("Такого элемента в массиве нет");
        
        }
    }
    
    Console.WriteLine(array);

void FillArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++) 
{
for (int j = 0; j < array.GetLength(1); j++) 
{
array[i, j] = new Random().Next(0, 10);


}
}
}

void PrintArray(int[,] array)
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

