double[] GetBinaryArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble() * 40 - 20;
    }
    return array;
}

int size = 8;
double[] resultArray = GetBinaryArray(size);
Console.WriteLine($"Массив: [ {String.Join(", ", resultArray)} ]");
double min = resultArray[0];
double max = resultArray[0];
for (int i = 0; i < size; i++)
{
    if (resultArray[i] > max) max = resultArray[i];
    if (resultArray[i] < min) min = resultArray[i];
    //Console.WriteLine($"{max}, {min}");
}
Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {max - min}");
