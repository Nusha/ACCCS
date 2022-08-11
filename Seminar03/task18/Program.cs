Console.WriteLine("Введите Номер четверти:  ");
int num = Convert.ToInt32(Console.ReadLine());
string GetCoord(int q)
{
   if (num == 1) return ("xc > 0 и yc > 0");
   if (num == 2) return ("xc < 0 и yc > 0");
   if (num == 3) return ("xc < 0 и yc < 0");
   if (num == 4) return ("xc > 0 и yc < 0"); 
   return "Введены некорректные координаты";
}
string result = GetCoord(num);
Console.WriteLine(result);
