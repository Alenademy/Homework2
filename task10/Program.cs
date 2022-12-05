Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine());
   if (n < 100)
Console.WriteLine(("Не трехзначное число"));
else 
{
   Console.WriteLine((n / 10) % 10);
}

