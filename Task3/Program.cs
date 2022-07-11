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

int FindMax(int[] array)
{
    int i = 0;
    int max = array[i];
    for (i = 0; i < array.Length - 1; i++)
    {
        if (max < array[i + 1]) max = array[i + 1];
    }
    return max;
}

int FindMin(int[] array)
{
    int i = 0;
    int min = array[i];
    for (i = 0; i < array.Length - 1; i++)
    {
        if (min > array[i + 1]) min = array[i + 1];
    }
    return min;
}

int[] arr = new int[7];
FillArray(arr);
PrintArray(arr);
Console.WriteLine();
Console.WriteLine($"Разность максимального и минимального числа массива равна: {FindMax(arr) - FindMin(arr)}");
