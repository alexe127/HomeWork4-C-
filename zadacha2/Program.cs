// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] array = new int[123];

Random random = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(1, 1000);
    Console.Write(array[i] + " ");
}
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 10 && array[i] < 100) count++;
}
Console.WriteLine();
Console.WriteLine("количество элементов из отрезка[10,99]= " + count);