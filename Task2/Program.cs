int[] GetBinaryArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100);
    }
    return array;
}

int size = 8;
int[] resultArray = GetBinaryArray(size);
int result = 0;
Console.WriteLine($"Массив: [ {String.Join(", ", resultArray)} ]");
for (int i = 0; i < size; i++)
{
    if (i != 0 & (i % 2 > 0)){ 
        result = resultArray[i] + result;
        //Console.WriteLine($"{resultArray[i]}");
    }
}

Console.WriteLine($"Сумма элементов, находящихся на нечетных позициях: {result}");
