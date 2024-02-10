



string name3 = "Ismoil";
string name1 = "Ghiyosov";
string name2 = "Abdullo";


Stack<string> name = new Stack<string>();
name.Push(name1);
name.Push(name2);
name.Push(name3);
foreach (var item in name)
{
    System.Console.WriteLine(item);
}
System.Console.WriteLine("-------------------");
System.Console.WriteLine(name.Pop());
System.Console.WriteLine("-------------------");
foreach (var item in name)
{
    System.Console.WriteLine(item);
}
System.Console.WriteLine("-------------------");
System.Console.WriteLine(name.Peak());