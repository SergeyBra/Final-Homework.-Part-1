Console.Clear();
Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = CreateArray(size);
Console.WriteLine($"Введенный массив: [{string.Join(",", array)}]");
Console.WriteLine($"[{ShowSomeElements(array)}]");
string[] CreateArray(int sizeArray)
{
    string[] newArray = new string[sizeArray];
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.WriteLine("Введите элемент:");
        newArray[i] = Console.ReadLine();
    }
    return newArray;
}
string ShowSomeElements(string[] inputArray)
{
    string str = "";
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
            str += (inputArray[i] + ", ");
    }
    str = str.Remove(str.Length - 2);
    return str;
}