Console.Clear();
Console.WriteLine("Введите первое число:");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int B = Convert.ToInt32(Console.ReadLine());
if (A/B == B)
    {
        Console.WriteLine($"Число {A} является квадратом числа {B}");
        }
else
{
    Console.WriteLine($"Число {A}  не является квадратом числа {B}");
}