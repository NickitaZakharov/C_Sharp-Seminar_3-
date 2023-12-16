//Дано натуральное число в диапазоне от 1 до 100 000. 
//Создайте массив, состоящий из цифр этого числа. Старший разряд числа должен располагаться на 0-м индексе массива, 
//младший – на последнем. Размер массива должен быть равен количеству цифр.

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int tempNumber = number;
int count = 0;
while (tempNumber > 0)
{
    count++;
    tempNumber /= 10;
}
int[] array = new int[count];
tempNumber = number;
for (int i = count - 1; i >= 0; i--)
{
    array[i] = tempNumber % 10;
    tempNumber /= 10;
}
foreach (int arr in array)
{
    Console.Write($"{arr},");
}
