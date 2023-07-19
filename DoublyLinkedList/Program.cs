

using DoublyLinkedList.Model;

MyLinkedList<int> list = new MyLinkedList<int>();

list.Add(1);
list.Add(2);
list.Add(3);
list.Add(4);
list.Add(5);

list.Delete(2);

list.Delete(3);
list.Delete(4);
list.Delete(1);
list.Delete(5);

Console.ReadLine();