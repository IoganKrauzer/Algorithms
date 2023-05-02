Console.Clear();
int[] arr = { 5, 3, 4, 2, 1, 9, 10, 6 };
int len = arr.Length;
int count = 0;
int temp = 0;

for (int j = 0; j < len; j++)                      // Для просмотра массива
{
    Console.Write("| " + arr[j] + " |");
}
Console.WriteLine("\n");

while (count < len - 1)
{
   int index = 0;
    while (index < len - 1 - count)
    {
        if (arr[index] > arr[index + 1])
        {
            temp = arr[index];
            arr[index] = arr[index + 1];
            arr[index + 1] = temp;
        }
        index++;
    }
    count++;
}

for (int j = 0; j < len; j++)       // Для просмотра отсортированного массива
{
    Console.Write("| " + arr[j] + " |");
}




// int[] array = new int[5];
// int len = array.Length;
// int[] arr = new int[5];
// int l = arr.Length;
// int temp = 0;
// int count = 0;




// for (int i = 0; i < len; i++)
// {
//     array[i] = new Random().Next(1, 99);
//     Console.Write("|" + array[i] + "| ");
// }
// Console.WriteLine();
// Console.WriteLine();

// for (int j = 0; j < l; j++)
// {
//     arr[j] = array[j];

//     Console.Write("|" + arr[j] + "| ");
// }

// //  int mMax = arr[0];



// while (count < l)
// {

// for (int k = 0; k < l; k++)
// {
//     int m = 1;
//     m++;
//     if (arr[k] > arr[m])
//     {
//         temp = arr[k];
//         arr[k] = arr[m];
//         arr[m] = temp;
//     }

// }

// count++;
// }
// for (int s = 0; s < l; s++)
// {
//     Console.WriteLine();
//     Console.WriteLine();
//     Console.Write("/" + arr[s] + "/ ");
// }