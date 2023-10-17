// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите целое число");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (a != 0)
{
    int x = a % 10;
    a = a / 10;
    sum = sum + x;
}
Console.WriteLine("Сумма цифр числа = " + sum);
