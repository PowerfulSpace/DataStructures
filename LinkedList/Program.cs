




using LinkedList.Model;

var list = new LinkedList.Model.LinkedList<int>();
list.Add(1);
list.Add(2);
list.Add(3);
list.Add(4);
list.Add(5);
list.Add(6);

foreach (var item in list)
{
    Console.Write(item + " ");
}
Console.WriteLine();
Console.WriteLine(list);
Console.WriteLine();

list.Delete(7);
//list.Delete(3);
//list.Delete(1);
//list.Delete(6);

list.AppendHead(55);

list.InsertAfter(55, 10);


foreach (var item in list)
{
    Console.Write(item + " ");
}
Console.WriteLine();
Console.WriteLine(list);

Console.ReadLine();