
string[] arr1 = new string[7] {"22", "ok", "no", "333", "hello", "4444", "-5"};
string[] arr2 = new string[arr1.Length];
void ResArray(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
    if(arr1[i].Length <= 3)
        {
        arr2[count] = arr1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("\b\b\b]");
}
ResArray(arr1, arr2);
PrintArray(arr2);
