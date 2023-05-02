Console.Clear();
// int[] arr = new int[8];
// int len = arr.Length;
int[] arr = { 5, 3, 4, 2, 1, 6, 9, 7, 14, 11, };
int len = arr.Length;
int choiceCount = 0;
int temp = 0;
// PrintArray(arr);
// RandomArray(arr);
PrintArray(arr);
Console.WriteLine("\n");

// { 5, 3, 4, 2, 1, 6, 9 };

while (choiceCount < len -1)
{
    int min = 1;
    int index = 1;
    min = min + choiceCount;
    index = index + choiceCount;
    while (index < len - 1)
    {
        if (arr[index] > arr[index + 1] && arr[min] > arr[index + 1])               // переработка
        {
            min = index + 1;
            index++;
        }
        else
        {
            index++;
            continue;
        }


    }
    if (arr[choiceCount] > arr[min])
    {
        temp = arr[choiceCount];
        arr[choiceCount] = arr[min];
        arr[min] = temp;
    }
    choiceCount++;
}

PrintArray(arr);
// Console.WriteLine("\n");




// void RandomArray(int[] ar)
// {
//     int p = 0;
//     int alen = ar.Length;
//     while (p < alen)
//     {
//         ar[p] = new Random().Next(1, 31);
//         p++;

//     }

// }

void PrintArray(int[] ar)
{
    int r = 0;
    int ll = ar.Length;
    while (r < ll)
    {
        Console.Write("| " + ar[r] + " |");
        r++;
    }
}

// void PrintArray(int[] ar)
// {
//     int r = 0;
//     int ll = ar.Length;
//     while (r < ll)
//     {
//         Console.Write("| " + ar[r] + " |");
//         r++;
//     }
// }







/* int FindMin(int[] ar)
{
    int k = 1;
    int l = ar.Length;
    while (k < l - 1)
    {
        if (ar[k] > ar[k + 1] && ar[min] > ar[k + 1])
        {
            min = k + 1;
        }
        k++;
    } 

    return min;
} */

// int RandomArray(int[] mass)
// {
// int p = 0;
// while (p < len)
// { 
//     mass[p] = new Random().Next(1, 16);
// PrintArray(arr);
// }
// }