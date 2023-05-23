void NewArray(string[] array, string[] newArray)
{
    int count = 0;
    int maxSymbol = 3;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxSymbol)
        {
            newArray[count] = array[i];
            count++;
        }
    }
}

int NewSize(string[] array, int size)
{
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j].Length <= 3)
        {
            size++;
        }
    }
    return size;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int size = 0;
string[] array = new string[] { "Hello", "2", "world", ":-)" };
string[] fixArray = new string[array.Length];

size = NewSize(array, size);
NewArray(array, fixArray);
Array.Resize(ref fixArray, size);
PrintArray(fixArray);