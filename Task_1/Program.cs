﻿// Задайте одномерный массив из 10 целых чисел от 1 до 100. 
//Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

int[] array = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= 20 && array[i] <= 90)
    {
        count++;
    }
}
Console.WriteLine("Количество элементов массива, значения которых лежат в диапазоне [20, 90]: " + count);