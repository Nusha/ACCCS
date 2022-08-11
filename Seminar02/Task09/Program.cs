int number = new Random().Next(10, 100);
Console.WriteLine ($"Случайное число из дипапзона 10 - 99 => {number}");
int firstDigit = number / 10;
int secondDigit = number % 10;

string result = firstDigit == secondDigit ? "Цифры равны"
: firstDigit > secondDigit ? firstDigit.ToString() : secondDigit.ToString();
Console.WriteLine($"Наибольшая цифра числа {number} => {result}");
