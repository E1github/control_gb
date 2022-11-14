
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i <= array.Length - 2; i++) Console.Write($"{array[i]},");
    Console.Write($"{array[array.Length - 1]}]");
}


string[] CreateFullStrArrayFromUser(int rows)
{
    string[] strArrFull = new string[rows];


    for (int i = 0; i < strArrFull.GetLength(0); i++) // 0 - rows  0 
    {
        Console.Write($"Введите {i + 1}-й элемент массива : ");
        strArrFull[i] = Console.ReadLine();
    }
    return strArrFull;
}


string[] CreateShortStrArrayFromFull(string[] str, int max)
{

    int lenghtShortArray = 0;

    for (int i = 0; i < str.GetLength(0); i++) // 0 - rows  0 
    {
        if (str[i].Length <= max) lenghtShortArray++;
    }

    if (lenghtShortArray != 0)
    {
        string[] strArrShort = new string[lenghtShortArray];

        int j = 0;

        for (int i = 0; i < str.GetLength(0); i++) // 0 - rows  0 
        {
            if (str[i].Length <= max)
            {
                strArrShort[j] = str[i];
                j++;
            }
        }
        return strArrShort;
    }
    else
    {
        string[] strArrShort = new string[] { "" };
        return strArrShort;
    }

}


int maxCountOfSymbols = 3;
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

string[] strFullArray = CreateFullStrArrayFromUser(rows);
string[] strShortArray = CreateShortStrArrayFromFull(strFullArray, maxCountOfSymbols);

PrintArray(strFullArray);
Console.Write(" -> ");
PrintArray(strShortArray);
