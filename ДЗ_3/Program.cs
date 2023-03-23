/**Задача 3:** Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.([https://learn.microsoft.com/ru-ru/dotnet/api/system.random.nextdouble?view=net-7.0](https://learn.microsoft.com/ru-ru/dotnet/api/system.random.nextdouble?view=net-7.0))
[3, 7.4, 22.3, 2, 78] -> 76
*/

//Main

Console.Write("Задайте размер массива: ");
int Size = int.Parse(Console.ReadLine()!);
double[] array = GetRandomArray(Size, -9999, 9999);
Console.WriteLine($"[{String.Join(";", array)}]");
double Result = GetMax(array)-GetMin(array);
Console.Write("Разница между максимальным и минимальным элементами массива: ");
Console.WriteLine(Result);

//Функция заполнения массива 
double[] GetRandomArray(int size, int minValue, int maxValue)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        Random rnd = new Random();
        result[i] = new Random().Next(minValue, maxValue + 1) + rnd.NextDouble();
    }
    return result;
}

//Функция поиска MIN элемента массива
double GetMin(double[] array)
{
    double MIN = array[0];
    foreach (double el in array)
    {
        if (el<MIN) MIN = el;
    }
    return MIN;
}

//Функция поиска MAX элемента массива
double GetMax (double[] array)
{
    double MAX = array[0];
    foreach (double el in array)
    {
        if (el>MAX) MAX = el;
    }
    return MAX;
}