string[] GetArray(int size)
{
    string[] result = new string[size];
    Console.WriteLine($"Введите {size} элементов массива");
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = Console.ReadLine();
    }
    return result;
}

void UpToThreeSigns(string[] inputArray)
{
    int count = 0;
    for (int k = 0; k < inputArray.Length; k++)
    {
        if (inputArray[k].Length <= 3)
        {
            count++;
        }
    }
    int j = 0;
    string[] outputArray = new string[count];
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            outputArray[j] = inputArray[i];
            j++;
            i++;
        }
    }
    Console.WriteLine($"Массив с элементами, где 3 и менее знаков:  [{String.Join(";", outputArray)}]");
}
string[] array = GetArray(7);
Console.WriteLine($"Заданный массив:  [{String.Join(";", array)}]");
UpToThreeSigns(array);


