// Задача 37: Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21
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
        collection[i] = new Random().Next(0, 10);
    }
}
void ProductOfPairsOfNumbers(int[] array)
{
    int j = array.Length - 1;
    Console.Write("[");
    for (int i = 0; i < (array.Length + 1) / 2; i++)
    {
        if (i == j)
        {
            Console.Write(array[i] + "");
        }
        else
        {
            Console.Write(array[i] * array[j] + ", ");
            j--;
        }
    }
    Console.Write("]");
}

int[] array1 = new int[8];
FillArray(array1);
Console.Write("Основной массив :");
PrintArray(array1);
Console.WriteLine();
Console.Write("произведение пар чисел в одномерном массиве :");
ProductOfPairsOfNumbers(array1);
