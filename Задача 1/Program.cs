void Stepen (int a, int b)
{
     int result = 1;
     for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);     

}

Console.WriteLine ("Введите число A:   ");
int A = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Введите число B:   ");
int B = Convert.ToInt32 (Console.ReadLine());

Stepen (A, B);