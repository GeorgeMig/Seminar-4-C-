//метод, который принимает слово и возвращает true, если в этом слове есть две одинаковые, стоящие рядом буквы.

Console.Write("Введите любое слово => ");
string word = Console.ReadLine();
string res = Findres(word);

string Findres(string pair)
{
    string ress = "false";
    for( int i = 0; i < word.Length - 1; i++)
{
    if (pair [i] == pair [i + 1])
    {
         ress = "true";
    }
}
return ress;
}
Console.WriteLine(res);

