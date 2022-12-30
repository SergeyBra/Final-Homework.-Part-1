Console.Clear();
Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = CreateArray(size);
Console.WriteLine($"Введенный массив: [{string.Join(",", array)}]");
Console.WriteLine($"Введенный массив: [{string.Join(",", ShowSomeElements(CountElementsInCondition(array),array))}]");
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
int CountElementsInCondition(string[] inputArray)
{
    int count = 0;
    string[] arr = new string[count];
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}
string[] ShowSomeElements(int countnumber,string[] inputArray)
{
    string[] resultArr = new string[countnumber];
    int count=0; 
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            resultArr[count]=inputArray[i];
            count++;
        }
    }
   
    return resultArr;
}