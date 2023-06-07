// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i= i+1)
        array[i] = new Random().Next(-9, 100);
}
void SumNonEvenPos(int[] array)
{
    int sum =0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2!=0) sum += array[i];
    }
    System.Console.WriteLine(sum);
}
void PrintArray(int[] array)
{
    foreach (var item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}


int[] num = new int[5];
FillArray(num);
PrintArray(num);
SumNonEvenPos(num);