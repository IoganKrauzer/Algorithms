Console.Clear();
int[] arr = { 2, 7, 9, 2, 4, 5, 1, 12, 17, 18, 16 };
int len = arr.Length;

for (int sortCount = 0; sortCount < len - 1; sortCount++)
{
    int temp = 0;
    int min = 1;
    min = min + sortCount;
    for (int index = 1; index < len - 1; index++)
    {
        if ((arr[index] > arr[index + 1]) && (arr[min] > arr[index + 1]))
        {
            min = index + 1;
        }
    }
    if (arr[sortCount] > arr[min])
    {
        temp = arr[sortCount];
        arr[sortCount] = arr[min];
        arr[min] = temp;
    }
}
for (int i = 0; i < len; i++)
{
    Console.Write(arr[i] + "\t");
}

