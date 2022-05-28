// Программа, которая принимает на вход число и выдаёт сумму цифр в числе. 

Console.Write("Введите любое натуральное число => ");
int num = int.Parse(Console.ReadLine());
int countnum = num;
int secnum = 0;
int sum = 0;
while (countnum > 0)
{
    secnum = countnum % 10;
    sum = sum + secnum;
    countnum = countnum / 10;
}
Console.WriteLine($"Сумма цифр в числе {num} равна {sum}.");
