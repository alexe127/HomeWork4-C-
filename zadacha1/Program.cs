//  Задать массив, заполнить случайными положительными трёхзначными числами. 
//Показать количество нечетных\четных чисел

int[] array = new int[10];

Random random = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(100, 1000);
    Console.Write(array[i] + " ");
}
int countPlus = 0;
int countMinus = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        countPlus++;
    }
    else countMinus++;
}


Console.WriteLine();
Console.WriteLine("количество положительных элементов = " + countPlus);
Console.WriteLine("количество отрицательных элементов = " + countMinus);