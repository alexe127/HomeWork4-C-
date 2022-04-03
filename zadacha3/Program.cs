// Найти сумму чисел одномерного массива стоящих на нечетной позиции
int[] array = new int[10];

void FillArray()
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 10);
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
void SummNechetPos()
{
    int summ = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        summ += array[i];
    }
    
    Console.WriteLine("сумма чисел стоящих на нечётной позиции = " + summ);
}
FillArray();
PrintArray(array);
SummNechetPos();
