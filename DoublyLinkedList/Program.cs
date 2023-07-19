

using DoublyLinkedList.Model;

MyLinkedList<int> list = new MyLinkedList<int>();

list.Add(1);
list.Add(2);
list.Add(3);
list.Add(4);
list.Add(5);

foreach (var item in list)
{
    Console.Write(item + " ");
}

//list.Delete(2);
//list.Delete(3);
//list.Delete(4);
//list.Delete(1);
//list.Delete(5);

//foreach (var item in list)
//{
//    Console.Write(item + " ");
//}

Console.WriteLine();
var newList = list.Reverse();
foreach (var item in newList)
{
    Console.Write(item + " ");
}

Console.ReadLine();