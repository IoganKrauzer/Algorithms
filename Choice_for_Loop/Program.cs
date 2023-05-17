Console.Clear();
int[] arr = { 2, 7, 9, 2, 4, 5, 1, 12, 17, 18, 16, 22, 2, 7, 33, 14, 18 };
// int len = arr.Length;

ChangeSort(arr);

void ChangeSort(int[] ar)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int min = i;
        int temp = 0;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[min]) min = j;
        }
        if (arr[i] > arr[min])
        {
            temp = arr[i];
            arr[i] = arr[min];
            arr[min] = temp;
        }
        Console.Write(arr[i] + "  ");
    }
}



// for (int sortCount = 0; sortCount < len - 1; sortCount++)
// {
//     int temp = 0;
//     int min = 1;
//     min = min + sortCount;
//     for (int index = 1; index < len - 1; index++)
//     {
//         if ((arr[index] > arr[index + 1]) && (arr[min] > arr[index + 1]))
//         {
//             min = index + 1;
//         }
//     }
//     if (arr[sortCount] > arr[min])
//     {
//         temp = arr[sortCount];
//         arr[sortCount] = arr[min];
//         arr[min] = temp;
//     }
// }
// for (int i = 0; i < len; i++)
// {
//     Console.Write(arr[i] + "\t");
// }

