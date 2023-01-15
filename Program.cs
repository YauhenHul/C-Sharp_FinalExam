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


string[] MakeResultArray(string[] stringArray, int maxLength, int arraySize)
{
    string[] finalArrayString = new string[arraySize];
    int counter = 0;

    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= maxLength)
        {
            finalArrayString[counter] = stringArray[i];
            counter++;
        }
    }

    return finalArrayString;
}


Console.Clear();
const int maxElementLength = 3; // максимальная длина элементов массива, которые будем выбирать

Console.Write("Какое количество элементов будет в исходном массиве? ");
int numbersN = Convert.ToInt32(Console.ReadLine());