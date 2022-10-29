string[] array1 = new string[7] { "123", "hello", "world", "1234", "1567", "-2", "computer science" };
string[] array2 = new string[array1.Length];
void newArray(string[] array1, string[] array2)
{
    int k = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[k] = array1[i];
            k++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
newArray(array1, array2);
PrintArray(array2);