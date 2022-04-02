//  Задать массив, заполнить случайными положительными трёхзначными числами. 
//Показать количество нечетных\четных чисел

int[] array = new int[10];

Random random = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(100, 1000);
    Console.Write(array[i] + " ");
}
int chet = 0;
int nechet = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        chet++;
    }
    else nechet++;
}


Console.WriteLine();
Console.WriteLine("количество чётных элементов = " + chet);
Console.WriteLine("количество не чётныхэлементов = " + nechet);