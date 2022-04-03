//  Задать массив, заполнить случайными положительными трёхзначными числами. 
//Показать количество нечетных\четных чисел
int[] array = new int[11];

void FillArray()
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 1000);
    }
}
void PrintArray(int[] currentArray)
{
    for (int i = 0; i < currentArray.Length; i++)
    {
        Console.Write(currentArray[i] + " ");
    }
    Console.WriteLine();
}
void ChetNechet()
{
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
    Console.WriteLine("количество чётных элементов = " + chet);
    Console.WriteLine("количество не чётных элементов = " + nechet);
}
FillArray();
PrintArray(array);
ChetNechet();






