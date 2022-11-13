/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/
Console.Clear();

int[] array = new int[8];

void RandomArray(int[] arr)
{
    int size = arr.Length; ;
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(1, 10);
        Console.Write($"{arr[i]} ");
    }
}

void SumOddPos(int[] arr2)
{
    int sum = 0;
    int size = arr2.Length;
    for (int i = 0; i < size; i++)
    {
        if(i % 2 != 0) sum = sum + arr2[i];
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {sum}");
}
RandomArray(array);
Console.WriteLine();
SumOddPos(array);
