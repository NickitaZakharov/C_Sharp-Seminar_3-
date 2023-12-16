// Задайте массив из вещественных чисел с ненулевой дробной частью. 
//Найдите разницу между максимальным и минимальным элементов массива.

Random random = new Random();
double[] array = new double[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.NextDouble() + random.Next(1, 10);
}
double max = array[0];
double min = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}
double difference = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементами: {difference}");
