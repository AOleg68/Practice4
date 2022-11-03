// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int NLength (int n)
{
    int  index = 0;
    while (n > 0)
    {
          n /= 10;
          index++;
    }
    return index;
}
void Summa (int a, int Length)
{
    int sum = 0;
    for (int i = 1; i <= Length; i++)
    {
         sum = sum + a % 10;
         a /= 10;
    }
    Console.WriteLine(sum);

}

Console.WriteLine ("Введите число A:   ");
int A = Convert.ToInt32 (Console.ReadLine());
int Length = NLength (A);
Summa (A, Length);