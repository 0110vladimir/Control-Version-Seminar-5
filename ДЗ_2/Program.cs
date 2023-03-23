/**Задача 2**: Задайте одномерный массив, заполненный случайными числами. Найдите **сумму элементов, стоящих на нечётных индексах**.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

//Main

Console.Write("Задайте размер массива: ");
int Size = int.Parse(Console.ReadLine()!);
int[] array = GetRandomArray(Size, -9999, 9999);
Console.WriteLine($"[{String.Join(",", array)}]");

int Summ = GetSummOddElements (array);
Console.Write("Сумма элементов в массива с нечётными индексами: ");
Console.WriteLine(Summ);


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

//Функция вычисления суммы элементов, стоящих на нечётных индексах
int GetSummOddElements (int[] array)
{
    int size = array.Length;
    int Summ = 0;
    for (int i = 1; i < size; i=i+2)
    {
        Summ = Summ+array[i];
    }
    return Summ;
}