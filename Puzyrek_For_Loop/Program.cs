Console.Clear();
int[] arr = { 9, 8, 6, 5, 4, 3, 2, 1 };
int len = arr.Length;


for (int sortCount = 0; sortCount < len; sortCount++)
{
    for (int index = 0; index < len - 1 - sortCount; index++)
    {
        int temp = 0;
        if (arr[index] > arr[index + 1])
        {
            temp = arr[index];
            arr[index] = arr[index + 1];
            arr[index + 1] = temp;
        }

    }
}

for (int i = 0; i < len; i++)
{
    Console.Write(arr[i] + "\t");
}