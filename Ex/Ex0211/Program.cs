//Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа

int num = new Random().Next(100, 1000);
Console.WriteLine(num);

/* int firstchar = num / 100;
int secondchar = num%100/10;
num = num - firstchar*100 - secondchar*10 + firstchar*10; */

//num = num - (num / 100) * 100 - (num % 100) / 10 * 10 + (num / 100) * 10;

//Console.WriteLine(num);

Console.WriteLine($"{num/100}{num%10}");

string stroka = num.ToString();
Console.WriteLine($"{stroka[0]}{stroka[2]}");