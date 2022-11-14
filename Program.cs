
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
        Console.Write($"Введите {i+1}-й элемент массива : ");
        strArrFull[i] = Console.ReadLine();    
    }
    return strArrFull;
}

Console.Write("Введите количество строк: ");
int rows  = Convert.ToInt32(Console.ReadLine());

string[] strFullArray = CreateFullStrArrayFromUser(rows);

PrintArray(strFullArray);

