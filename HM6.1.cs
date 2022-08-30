int size = 5;
int[] numbers = new int[size];
int sum = 0;
FillArray(numbers);
PrintArray(numbers);

void FillArray(int[] numbers)
{
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"Введите элемент с индексом {i}:\t");
    numbers [i] =Convert.ToInt32(Console.ReadLine());

    if (numbers[i]>0)
    {
        sum++;
        
    }
    
}
}

Console.WriteLine("Количество чисел больше 0 = " + sum);

void PrintArray(int[] numbers)
{
for(int i = 0; i < numbers.Length; i++)
{
Console.Write(numbers[i] + " ");
}
Console.WriteLine();
}
