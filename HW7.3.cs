int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
double[,] array = new double[rows, columns];
double average = 0;
double meaning = 0;
FillArray(array);
PrintArray(array);

for (int i = 0; i < array.GetLength(0); i++)
            {
                double sum = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[j, i];
                    meaning++;
                    average=sum/meaning;
                }
                Console.WriteLine("Сумма в {0} столбце: {1}", i, sum);
                Console.WriteLine("Среднее арифметическое в {0} : {1}", i, average);
            }


void FillArray(double[,] array)
{
for (int i = 0; i < array.GetLength(0); i++) 
{
for (int j = 0; j < array.GetLength(1); j++) 
{
array[i,j] = new Random().Next(1,10);
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
