// 1. Найти позицию минимального элемента 
// в неотсортированной части массива
// 2. Произвести обмен этого значения со 
// значением первой не отсортированной позиции
// 3. Повторять пока есть не отсорторованные элементы массива.

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    Console.Write("[ ");
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write("]");
    Console.WriteLine();
}

void SelectionSortMin(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.LongLength; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

void SelectionSortMax(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.LongLength; j++)
        {
            if(array[j] > array[maxPosition]) maxPosition = j;
        }

        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}
Console.Write("Исходный массив - "); 
PrintArray(arr);
SelectionSortMin(arr);
Console.Write("Отсортированный массив от мин к макс - ");
PrintArray(arr);
SelectionSortMax(arr);
Console.Write("Отсортированный массив от макс к мин - ");
PrintArray(arr);