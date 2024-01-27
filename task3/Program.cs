int[] array = { 2, 7, 5, 9, 8, 6 };
int inverted;
for (int i = 0; i < array.Length / 2; i++)
{
    inverted = array[i];
    array[i] = array[array.Length - 1 - i];
    array[array.Length - 1 - i] = inverted;
}

Console.Write("Новый перевернутый массив: ");
foreach (int number in array)
{
    Console.Write(number + " ");
}