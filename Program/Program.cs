
Console.Clear();
Console.Write("Введите исходный массив строк(элементы через пробел) : ");
string str = Console.ReadLine();
Console.WriteLine(str);
string[] words = str.Split(' ');
foreach (var word in words)
{
    System.Console.WriteLine($"<{word}>");
}

