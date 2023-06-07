// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


void CreateArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
    
}
void EvenNumbers(int[] array)
    {
        int mass =0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]%2==0) mass ++;
        }
        System.Console.WriteLine(mass);
    }
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine(array[i]);
    }
}

Console.Clear();
int[] array = new int [4];
CreateArray(array);
PrintArray(array);
EvenNumbers(array);