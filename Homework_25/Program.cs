// ПРОГРАММА, которая принимает на вход
// два числа (A и B) и возводит число A в натуральную степень B

Console.Write("Введите любое натуральное число, которое необходимо возвести в степень => ");
int num = int.Parse(Console.ReadLine());
Console.Write("Введите натуральую степень, в которую необходимо возвести число => ");
int degree = int.Parse(Console.ReadLine());
int count = degree;
int res = num;
while (count > 0)
{
    res = res * num;
    count --;
}
Console.WriteLine($"Число {num} в степени {degree} равняется {res}.");