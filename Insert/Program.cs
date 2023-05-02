Console.Clear();
int[] arr = { 5, 2, 9, 3, 4, 1, 7, 11, 10 };
int len = arr.Length;
int temp = 0;
int sortedSize = 0;

for (int i = 0; i < len; i++)
{
    Console.Write("| " + arr[i] + " |");
}
Console.WriteLine("\n");



while (sortedSize < len - 1)
{
    int index = 1;
    index = index + sortedSize;

    if (arr[index] < arr[index - 1])
    {
        temp = arr[index - 1];
        arr[index - 1] = arr[index];
        arr[index] = temp;


        if ((index - 1) == 0)
        {
            sortedSize++;
            continue;
        }
        else
        {
            while (index - 1 != 0)
            {
                index--;
                if (arr[index] < arr[index - 1])
                {
                    temp = arr[index - 1];
                    arr[index - 1] = arr[index];
                    arr[index] = temp;
                }
            }
            sortedSize++;
            continue;
        }
    }
    else
    {
        sortedSize++;
        continue;
    }
}


for (int i = 0; i < len; i++)
{
    Console.Write("| " + arr[i] + " |");
}






