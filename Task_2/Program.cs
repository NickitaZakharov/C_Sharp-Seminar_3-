// Задайте массив на 10 целых чисел. Напишите программу, 
//которая определяет количество чётных чисел в массиве.

int[] numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine("Количество четных чисел: " + count);
