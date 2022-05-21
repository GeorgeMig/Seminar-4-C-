Console.Write("Введите любое натуральное число => ");
int number = int.Parse(Console.ReadLine());
int i = 0;
int delnum = number; //  переменная для деления
while (delnum > 0)
{
    delnum = delnum / 10;
    i++;
}
 Console.WriteLine($"Количество цифр в числе {number} равняется {i}.");
