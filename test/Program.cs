int NewArray(string[] array, string[] newArray, int size)
{
    int count = 0;
    int maxSymbol = 3;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxSymbol)
        {
            newArray[count] = array[i];
            count++;
            size++;
        }
    }
    return size;
}

void PrintArray(string[] array) => Console.WriteLine($"[“{string.Join("“,“", array)}“]");

int size = 0;
string[] array = new string[] { "Hello", "2", "world", ":-)" };
string[] fixArray = new string[array.Length];

size = NewArray(array, fixArray, size);
Array.Resize(ref fixArray, size);
PrintArray(fixArray);
