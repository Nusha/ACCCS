Console.Clear();
Console.Write("Введите день недели в диапазоне от 1 до 7:  ");
int day = Convert.ToInt32(Console.ReadLine());

if (day==1)
    {
        Console.WriteLine("Пн");
        }
else if (day==2)
    {
        Console.WriteLine("Вт");
        }
else if (day==3)
    {
        Console.WriteLine("Ср");
        }
else if (day==4)
    {
        Console.WriteLine("Чт");
        }
else if (day==5)
    {
        Console.WriteLine("Пт");
        }
else if (day==6)
    {
        Console.WriteLine("Сб");
        }
else if (day==7)
    {
        Console.WriteLine("Вс");
        }

    else     {
        Console.WriteLine("Вы ввели число вне дипапзона");        }