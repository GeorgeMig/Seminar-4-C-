Console.Write("Задайте размер масива любым числом => ");
int numleng = int.Parse(Console.ReadLine());
int [] array = new int [numleng];
int i = 0;
int count = numleng;
Console.Write("Массив =>");
while (i < count)
{
    array [i] = new Random().Next(0, 2);
    Console.Write($" |{array[i]}|");
    i++;
}

