Console.Clear();
Console.WriteLine("Введите число");
int numb = Convert.ToInt32(Console.ReadLine());
Console.Write("Число: " + numb);
Console.WriteLine("\n");


int factorCount = FactorCount(numb);
Console.WriteLine($"Факториал числа: {numb} = {factorCount}");


int FactorCount(int num)
{
    if (num == 0) return 1;
    if (num == 1) return 1;
    return FactorCount(num - 1) * num;
}


// !F5 = 1 * 2 * 3 * 4 *5;
// int FactorCount(int num)
// {
//     int fact = 1;
//     for (int i = 1; i <= num; i++)
//     {
//         fact = fact * i;
//     }
//     return fact;
// }
