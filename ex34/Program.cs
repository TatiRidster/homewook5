// Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет количество
// чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
void PrintArray(int[] col)
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
void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(100, 1000);
    }
}
int EvenNumbers(int[] array)
{
    int result=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0)
        {
          result++;
        }
    }
    return result;
}

int[] array1 = new int[4];
FillArray(array1);
Console.Write("Основной массив :");
PrintArray(array1);
Console.WriteLine();
Console.Write("Количество четных чисел :");
int count = EvenNumbers(array1);
Console.WriteLine($"{count}");