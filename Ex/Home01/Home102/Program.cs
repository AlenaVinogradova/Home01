//Напишите программу, которая на вход принимает два числа 
//и выдаёт, какое число большее, а какое меньшее

Console.WriteLine("Введите два числа:");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if(a > b)
{
    Console.WriteLine(a + " больше " + b);
}
else if (a == b) 
Console.WriteLine(a + " равно " + b);
else
{
    Console.WriteLine(b + " больше " + a);
}

//Console.WriteLine($"{a} больше {b}");?