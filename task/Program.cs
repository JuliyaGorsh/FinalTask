
int CountLess3(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4) count++;
    }
    return count;
}

string[] FillResultArray(string[] array, int count)
{
    string[] result = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            result[result.Length - count] = array[i];
            count--;
        }
    }
    return result;
}