Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Max - {Math.Max(a,Math.Max(b,c))}");