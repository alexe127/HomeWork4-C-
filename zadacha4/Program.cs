// Найти произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.
int[] array = new int[8];

void FillArray()
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0,10);
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
void PairNum()
{
    int len = array.Length;
        for (int i = 0; i < len / 2; i++)
    {
        Console.Write(array[i] * array[len-i-1] + " ");
    }
    
}
FillArray();
PrintArray(array);
PairNum();