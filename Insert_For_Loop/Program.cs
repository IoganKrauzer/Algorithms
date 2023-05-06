Console.Clear();
int[] arr = { 2, 5, 8, 3, 4, 6, 9, 7, 1 };
// int[] arr = new int[12];
int len = arr.Length;


for (int sortCount = 0; sortCount < len; sortCount++)
{
    int index = 1;
    index += sortCount;
    while (index < len)
    {
        int temp = 0;
        if (arr[index] < arr[index - 1])
        {
            temp = arr[index - 1];
            arr[index - 1] = arr[index];
            arr[index] = temp;
        }
        else break;
        
        if (index - 1 == 0) break;
        else
        {
            index--;
            continue;
        }
    }
}
for (int i = 0; i < len; i++)
{
    Console.Write(arr[i] + "\t");
}

// for (int i =0; i < len; i++)
// {
//     arr[i] = new Random().Next(1, 25);
//     Console.Write(arr[i] + "\t");
// }
// Console.WriteLine("\n");