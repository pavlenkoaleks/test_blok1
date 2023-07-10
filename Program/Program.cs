using System;
Console.Clear();
Console.Write("Введите исходный массив строк(элементы через пробел) : ");
string str = Console.ReadLine();
Console.WriteLine(str);
string[] words = str.Split(' ');
Console.WriteLine("Введенные значения: ");
foreach (var word in words)
{
    Console.WriteLine($"<{word}>");
}
string[] result = new string[100];
int count=0;
for(int i=0;i<words.Length;i++){
  if (words[i].Length<=3) {result[count]=words[i];count++;}
}
 Console.WriteLine("Длина элементов <=3 : ");
 Console.WriteLine(String.Join(" ",result));

 