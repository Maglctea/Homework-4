void PrintArray(int[] array)
{
    Console.Write("[");
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine("]");
}


int[] CreateArrayRndInt(int size, int min, int max){
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

int[] array = CreateArrayRndInt(8, 0, 100);
PrintArray(array);
