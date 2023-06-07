// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


// void CreateArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(100, 1000);
    
// }

// void EvenNumbers(int[] array)
//     {
//         int mass =0;
//         for (int i = 0; i < array.Length; i++)
//         {
//             if (array[i]%2==0) mass ++;
//         }
//         System.Console.WriteLine(mass);
//     }
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.WriteLine(array[i]);
//     }
// }


// int[] array = new int [4];
// CreateArray(array);
// PrintArray(array);
// EvenNumbers(array);











// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i= i+1)
//         array[i] = new Random().Next(-9, 100);
// }
// void SumNonEvenPos(int[] array)
// {
//     int sum =0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i%2!=0) sum += array[i];
//     }
//     System.Console.WriteLine(sum);
// }
// void PrintArray(int[] array)
// {
//     foreach (var item in array)
//         Console.Write($"{item} ");
//     System.Console.WriteLine();
// }


// int[] num = new int[5];
// FillArray(num);
// PrintArray(num);
// SumNonEvenPos(num);








// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.




// void FillArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i= i+1)
//         array[i] = new Random().Next(1, 10) + new Random().NextDouble();

// }
// void PrintArray(double[] array)
// {
//     foreach (var item in array)
//         Console.Write($"{item} ");
//     System.Console.WriteLine();
// }
// double FindMax(double[] array)
// {
//     double max = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i]>max) max = array[i];
//     }
//     return max;
// }

// double FindMin(double[] array)
// {
//     double min = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i]<min) min = array[i];
//     }
//     return min;
// }
// void FindMinus(double max, double min)
// {
//     double res = max - min;
//     System.Console.WriteLine(res);
// }


// double[] array = new double [5];
// FillArray(array);
// PrintArray(array);
// double max = FindMax(array);
// double min = FindMin(array);
// System.Console.WriteLine($"{min}, {max}");
// FindMinus(max,min);

// Задача HARD STAT необязательная: Задайте массив случайных целых чисел. Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, 
// среднее арифметическое всех элементов. Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. 
// Найти медианное значение первоначалального массива ,
//  возможно придется кое-что для этого дополнительно выполнить.
int[] info = new int[5];
int[] array = new int [6];

FillArray(array);
FindMaxElementAndIndex(array);
FindMinElementAndIndex(array);
Arithmetic(array, info);
PrintArray(array);
FindMediana(array);

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 10);
}
void FindMaxElementAndIndex(int [] array)
{   
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        
        if (array[i]>count) 
        {   
            count = array[i];
            info[0] = array[i];
            info[1] = i;
        }  
    } 
}
void FindMinElementAndIndex(int [] array)
{   
    int count = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        
        if (array[i]<=count) 
        {   
            count = array[i];
            info[2] = array[i];
            info[3] = i;
        }  
    } 
}
void Arithmetic (int[] array, int[] arr)
{   
    int sum = 0;
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
        result = sum / array.Length;
    }
    arr[4] = result;
}
void PrintArray(int[] array)
{
    foreach (var item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}
void FindMediana(int[] array)
{   
    Array.Sort(array);
    int sum = 0;
    int mediana = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum+=array[i];
    }
    if (array.Length % 2 == 0) 
    mediana = (array[array.Length/2 +1] + array[array.Length/2]) /2;
    else
    mediana = array[array.Length/2];
    System.Console.WriteLine($"Медиана массива: {mediana}");

}

System.Console.WriteLine($"Максимальный элемент массива равен: {info[0]}, его индекс: {info[1]}.");
System.Console.WriteLine($"Минимальный элемент массива равен: {info[2]}, его индекс: {info[3]}.");
System.Console.WriteLine($"Среднее арифметическое всех значений массива равно: {info[4]}");