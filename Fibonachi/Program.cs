Console.Clear();
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int answer = Fibonachi(num);
Console.WriteLine(answer);

int Fibonachi(int n)
{
    if (n == 0) return 0; 
    if (n == 1) return 1;
    return Fibonachi((n - 2)) + Fibonachi((n - 1));
}


// int Fibonachi(int nu)
// {

//     int temp = 0;

//     if (num == 0) return 0;
//     if (num == 1) return 1;

//     int preFib = 0;  //F_0
//     int curFib = 1;  //F_1

//     for (int i = 1; i < num; i++)
//     {
//         temp = curFib;
//         curFib = preFib + curFib;
//         preFib = temp;
//     }
//     return curFib;
// }

//   /Pre  /Cur
//     0   1 = 1    (2)
//     1   1 = 2    (3)
//     1   2 = 3    (4)
//     2   3 = 5    (5)
//     3   5 = 8    (6)

// Console.WriteLine(num);