Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b) 
{ 
Console.WriteLine($"max = {a},min = {b}"); 
} 
else if (a < b) 
{ 
Console.WriteLine($"min = {a},max = {b}"); 
}