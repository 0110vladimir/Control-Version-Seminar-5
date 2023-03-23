/**Задача 1**: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет **количество чётных чисел** в массиве.
[345, 897, 568, 234] -> 2
*/

//Main

Console.Write("Задайте размер массива: ");
int Size = int.Parse(Console.ReadLine()!);
int[] array = GetRandomArray(Size, 100, 999);
Console.WriteLine($"[{String.Join(",", array)}]");
int Count = GetEvenNumberCount (array);
Console.Write("Количество чётных элементов в массиве: ");
Console.WriteLine(Count);


//Функция заполнения массива 
int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}

//Функция вычисления кол-ва чётных чисел массива
int GetEvenNumberCount (int[] array)
{
    int count = 0;
    foreach (int el in array)
    {
        if (el % 2 == 0) count++;
    }
    return count;
}
