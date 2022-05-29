// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
void PrintArray(double[] col)
{
    Console.Write("[");
    for (var i = 0; i < col.Length; i++)
    {
        if (i < col.Length - 1)
        {
            Console.Write($"{col[i]}, ");
        }
        else
        {
            Console.Write(col[i]);
        }
    }
    Console.Write("]");
}
void FillArray(double[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().NextDouble() * 200 - 100;
    }
}

double DiffMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    double diff = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= max) 
        {
          max = array[i];
        }
        if (array[i] <= min)
        { 
            min = array[i];
        }
        diff = max-min; 
    }
    return diff;
}

double[] array1 = new double[10];
FillArray(array1);
Console.Write("Основной массив :");
PrintArray(array1);
Console.WriteLine();
Console.Write("разница между максимальным и минимальным элементами массива : ");
double count = DiffMaxMin(array1);
Console.WriteLine($"{count}");