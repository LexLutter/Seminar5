int[] GetBinaryArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000); // [0;1]
    }
    return array;
}

int size = 8;
int[] resultArray = GetBinaryArray(size);
int result = 0;
Console.WriteLine($"Массив: [ {String.Join(", ", resultArray)} ]");
for (int i = 0; i < size; i++)
{
    if (resultArray[i] % 2 == 0) result++;
}

Console.WriteLine($"Количество четных чисел в массиве равно: {result}");
