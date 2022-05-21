Console.Write("Введите любое натуральное число => ");
int number = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= number; i++)
{
    sum = sum + i;
}
 Console.WriteLine($"Сумма чисел от 1 до {number} равна {sum}");