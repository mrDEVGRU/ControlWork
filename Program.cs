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

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
}

string[] array = new string[] { "Hello", "2", "world", ":-)" };
string[] fixArray = new string[array.Length];

NewArray(array, fixArray);
PrintArray(fixArray);