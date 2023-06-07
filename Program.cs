// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i= i+1)
        array[i] = new Random().Next(1, 10) + new Random().NextDouble();

}
void PrintArray(double[] array)
{
    foreach (var item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}
double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>max) max = array[i];
    }
    return max;
}
double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]<min) min = array[i];
    }
    return min;
}
void FindMinus(double max, double min)
{
    double res = max - min;
    System.Console.WriteLine(res);
}


double[] array = new double [5];
FillArray(array);
PrintArray(array);
double max = FindMax(array);
double min = FindMin(array);
System.Console.WriteLine($"{min}, {max}");
FindMinus(max,min);