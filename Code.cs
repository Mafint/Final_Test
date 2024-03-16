string[][] arrays = new string[][]
{
    new string[] {"toyota", "320", "bmw" },
    new string[] {"nice", "777", "action" },
    new string[] {"Russia", "Moldova", "USA" }
};
for (int i = 0; i < arrays.Length; i++)
{
    string [] inputArray = arrays[i];
    int count = 0;

    for (int j = 0; j < inputArray.Length; j++)
    {
        if (inputArray[j].Length <= 3);
        {
            count++;
        }
    }
    string[] resultArray = new string[count];
    int index = 0;
    for (int j = 0; j < inputArray.Length; j++)
    {
        if (inputArray[j].Length <= 3)
        {
            resultArray[index] = inputArray[j];
            index++;
        }
    }
    Console.WriteLine("Результат для массива "+(i + 1)+":");
    foreach (var item in resultArray)
    {
        Console.WriteLine(item);

    }
    Console.WriteLine();
}
