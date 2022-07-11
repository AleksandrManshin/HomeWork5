void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-99, 100);
    }
}

int SumNumbers(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
        else sum = sum + 0;
    }
    return sum;
}

int[] arr = new int[4];
FillArray(arr);
PrintArray(arr);
Console.WriteLine();
Console.WriteLine("Сумма чисел нечетных индексов равна : " + SumNumbers(arr));