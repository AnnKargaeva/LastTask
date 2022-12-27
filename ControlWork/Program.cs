string[] array = new string[] { "control", "5", "Hello", ";)", "123" };

void PrintArray(string[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
       Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void DiffArray(string[] arr)
{
       for (int i = 0; i < arr.Length; i++)
    {
        string newarray = arr[i];
        if (newarray.Length <= 3)
        {
            arr[i] = newarray;
        }
        else arr[i] =  string.Empty;

    }
}

PrintArray(array);

DiffArray(array);

Console.Write("-> ");

PrintArray(array);