/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/
Console.Clear();

double[] array = new double[8];

void RandomArray(double[] arr)
{
    int size = arr.Length; ;
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(1, 10);
        Console.Write($"{arr[i]} ");
    }
}

void DiffElements(double[] arr2)
{
    int size = arr2.Length;
    int i = 0;
    double max = arr2[i];
    double min = arr2[i];
    while(i < size)
    {
        if (arr2[i] > max) max = arr2[i];
        if (arr2[i] <= min) min = arr2[i];
        i++;
    }
    double diff = max - min;
    Console.WriteLine($"Разница между максимальным и минимальным элементов массива равна {diff}");
}
RandomArray(array);
Console.WriteLine();
DiffElements(array);