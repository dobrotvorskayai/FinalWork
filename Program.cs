Console.WriteLine("Введите размер массива (кол-во строк): ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите допустимую длинну элемента нового массива: ");
int elementSize = Convert.ToInt32(Console.ReadLine());

string[] Array(int sizeArray)
{
    string[] array = new string[sizeArray];
    for (int i = 0; i < sizeArray; i++)
    {
        Console.WriteLine($"Введите {i + 1} строку: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]}, ");
        else
            Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int NewSize(string[] array, int elementSize)
{
    int newSize = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= elementSize)
            newSize += 1;
    }
    return newSize;
}

string[] NewArray(string[] array, int newSize, int elementSize)
{
    string[] newArray = new string[newSize];
    int j = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= elementSize)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

string[] firstArray = Array(size);
Console.Write($"Исходный массив: ");
PrintArray(firstArray);
int secondArraySize = NewSize(firstArray, elementSize);
string[] secondArray = NewArray(firstArray, secondArraySize, elementSize);
Console.Write($"Преобразованный массив: ");
PrintArray(secondArray);
