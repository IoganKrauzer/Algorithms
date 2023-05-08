Console.Clear();
int[] arr = new int[100];
int len = arr.Length;

for (int i = 0; i < len; i++)
{
    arr[i] = 1 + i;
    Console.Write(arr[i] + " ");
}
Console.WriteLine("\n");

int low = 0;
int high = len - 1;
int mid = (low + high) / 2;
int count = 0;
Console.WriteLine("Загадайте число!");
Console.WriteLine("\n Программа будет пытаться отгадать загаданное вами число ");
Console.WriteLine("\n Если загаданное вами число больше варианта программы - нажмите Y ");
Console.WriteLine("\n Если загаданное вами число меньше варианта программы - нажмите N ");


BinCheck(arr);



void BinCheck(int[] ar)
{
    while (low <= high)
{
    Console.WriteLine(arr[mid]);
    count++;
    string dicision = Console.ReadLine().ToLower(); 
    if (dicision == "y")
    {
        mid += 1;
        low = mid;
    }
    else if (dicision == "n")
    {
        mid -= 1;
        high = mid;
    }
    else if (dicision == "g")
    {
        Console.WriteLine("Программа отгадала число! Урааааа!");
        break;
    }
    mid = (low + high) / 2;
}
Console.WriteLine("\n Загаданное вами число: " + arr[mid]);
Console.WriteLine("\n Программа отгадала число за: " + count + " ходов!");
}