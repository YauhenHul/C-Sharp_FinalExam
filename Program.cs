void FillStartArray(string[] stringArray, int maxLength, out int finalArraySize)
{
    finalArraySize = 0;

    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.Write("Введите текстовый элемент массива [" + i + "] : ");
        stringArray[i] = Console.ReadLine();

        if (stringArray[i].Length <= maxLength)
            finalArraySize++;
    }
}