using System.Text.RegularExpressions;
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("1)"); 
Console.Write("Текст: ");
string usertext = Console.ReadLine();

Console.WriteLine("Кількість символів пілся першої крапки: " + usertext.IndexOf('.'));
Console.WriteLine("2)");
Console.Write("S: ");
string s = Console.ReadLine();
Console.Write("S1: ");
string s1 = Console.ReadLine();
Console.Write("S2: ");
string s2 = Console.ReadLine();
s = s.Remove(s.IndexOf(s1), s1.Length).Insert(s.IndexOf(s1), s2);
Console.WriteLine("Результат: " + s);
Console.WriteLine("3)");
Console.Write("Текст: ");
string inputtextuser = Console.ReadLine();
string[] arr = inputtextuser.Split(new char[] { ' ', ',', '.' }); 
foreach(string i in arr)
{
    Console.WriteLine(Regex.Replace(i, "ing$", "ed")); 
}
Console.ReadLine(); 