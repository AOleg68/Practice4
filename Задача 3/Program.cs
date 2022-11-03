// Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
// N = 5, получаем массив [1, 2, 5, 7, 19]
// N = 3, получаем массив [6, 1, 33]

Console.WriteLine ("Введите длину массива:   ");
int Length = Convert.ToInt32 (Console.ReadLine());

int [] Array = new int[Length];
for (int i = 0; i < Array.Length; i++)
{
    Array [i] = new Random().Next (1,100);
    Console.Write (Array [i] + " ");
}
