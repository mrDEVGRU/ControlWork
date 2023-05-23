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


