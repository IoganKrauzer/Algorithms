//  >>> EXAMPLE For two pairs Sum ( 8 ) <<<
Console.Clear();
// int[] arr1 = { -1, 2, 5, 8 };
// int[] arr1 = { -3, -1, 0, 2, 4, 6 };
int[] arr1 = { -5, -3, -1, 0, 1, 2, 3, 4, 5, 6 };
// int[] arr1 = { -2, -1, 1, 2 };
// int[] arr1 = { 1, 2, 3, 4, 5, 6, 7 };
int len1 = arr1.Length;
int sumCheck = 8;
int temp = 0;
int count = 0;

SumPairs(arr1);

void SumPairs(int[] ar1)
{
    for (int i = 0; i < len1; i++)
    {
        temp = sumCheck - arr1[i];
        for (int j = 1 + i; j < len1; j++)
        {
            if (arr1[j] == temp)
            {
                Console.WriteLine($"Пара: {arr1[i]} + {arr1[j]} = {sumCheck}");
                count++;
            }
        }
    }
    if (count == 0)
    {
        Console.WriteLine("Пар в сумме которые дают " + sumCheck + " в данном массиве нет!");
    }
    Console.WriteLine("Счетчик: " + count);
}





/* int count = 0;
for (int i = 0; i < len1 / 2; i++)
{
    for (int j = len1 / 2; j < len1; j++)
    {
        if (arr1[i] + arr1[j] == 8)
        {
            Console.WriteLine($"Пара: {arr1[i]} + {arr1[j]} = 8 ");
            count++;
        }
        else continue;
    }
}
if (count == 0) Console.WriteLine("Пар в сумме которые дают 8 в данном массиве нет!");
Console.WriteLine("Кол-во пар: " + count);

 */


// ---ПОЛНЫЙ МЕТОД---

// for (int i = 0; i < len1; i++)
// {
//     temp = sumCheck - arr1[i];
//     for (int j = 1 + i; j < len1; j++)
//     {
//         if (arr1[j] == temp)
//         {
//             Console.WriteLine($"Пара: {arr1[i]} + {arr1[j]} = {sumCheck}");
//             count++;
//         }
//     }
// }
// if (count == 0) Console.WriteLine("Пар в сумме которые дают " + sumCheck + " в данном массиве нет!");
// Console.WriteLine("Счетчик: " + count);
