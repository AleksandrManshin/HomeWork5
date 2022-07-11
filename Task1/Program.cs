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
        array[i] = new Random().Next(100, 1000);
    }
}

int EvenNumbers(int[] array)
{
    int n = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) n++;
        else n = n + 0;
    }
    return n;
}

int[] arr = new int[4];
FillArray(arr);
PrintArray(arr);
Console.WriteLine();
Console.WriteLine("Количество четных чисел равно: " + EvenNumbers(arr));