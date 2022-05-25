// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
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
        collection[i] = new Random().Next(-99, 100);
    }
}
int NotEvenNumbers(int[] array)
{
    int result=0;
    for (int i = 1; i < array.Length; i+=2)
    {
        
        result+=array[i];
        
    }
    return result;
}

int[] array1 = new int[4];
FillArray(array1);
Console.Write("Основной массив :");
PrintArray(array1);
Console.WriteLine();
Console.Write("Сумма элементов, стоящих на нечётных позициях :");
int count = NotEvenNumbers(array1);
Console.WriteLine($"{count}");