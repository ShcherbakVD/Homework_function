int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(100, 1000);
        Console.Write(array[i] + " ");
    }
    return array;
}

int GetEvenNumbers(int[] array)
{
    int countEvenNumbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            countEvenNumbers += 1;
        }
    }
    return countEvenNumbers;
}

Console.WriteLine("size:");
int n = Int32.Parse(Console.ReadLine());

int[] array = CreateArray(n);
int count = GetEvenNumbers(array);
Console.WriteLine(count);
