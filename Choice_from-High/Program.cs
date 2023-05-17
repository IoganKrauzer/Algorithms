Console.Clear();
int[] array = new int[40];

ArrayCreate(array);
ChangePlace(array);
Check();

void ChangePlace(int[] arr)
{
    for (int i = arr.Length - 1; i >= 0; i--)
    {
        int max = i;
        int temp = 0;

        for (int j = i - 1; j >= 0; j--)
        {
            if (arr[j] > arr[max]) max = j;
        }
        if (arr[i] < arr[max])
        {
            temp = arr[i];
            arr[i] = arr[max];
            arr[max] = temp;
        }
    }
}
void ArrayCreate(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 100);
        Console.Write(arr[i] + " | ");
    }
    Console.WriteLine("\n");
}

void Check()
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " | ");
    }
    Console.Write("\n");
    Console.Write("\n");
}