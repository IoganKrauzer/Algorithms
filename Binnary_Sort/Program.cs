Console.Clear();
int[] arr = new int[100];
// int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };  // L = 0;  H = 18; M = 9;
int len = arr.Length;
Console.Write("Массив: ");
for (int i = 0; i < len; i++)
{
    arr[i] = 1 + i;   //массив от 1 до 100;
    Console.Write(arr[i] + " ");
}
int guess = new Random().Next(-15, 100);
// int guess = -10;                //TEST Stroke!
Console.WriteLine("\n");
Console.WriteLine("Число: " + guess);
int low = 0;
int high = len - 1;
int mid = (high + low) / 2; // 9
int count = 0;


if (guess > low && guess < high)
{
    while (low <= high)
    {
        count++;
        if (guess > arr[mid])
        {
            Console.WriteLine("To Low...");
            low = mid + 1;
        }
        else if (guess < arr[mid])
        {
            Console.WriteLine("To High!");
            high = mid - 1;
        }
        else if (guess == arr[mid])
        {
            Console.WriteLine("Yeah! Number is: " + arr[mid]);
            Console.WriteLine("Счетчик: " + count);
            break;
        }
        mid = (high + low) / 2;
    }
}
else
    Console.WriteLine("Такого числа: " + guess + " нет в массиве!");