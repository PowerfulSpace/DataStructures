using System.Collections;

namespace DoublyLinkedList.Model
{
    public class MyLinkedList<T> : IEnumerable<T>
    {
        public Item<T> Head { get; set; }
        public Item<T> Tail { get; set; }
        public int Count { get; set; }

        public MyLinkedList()
        {
            Head = null!;
            Tail = null!;
            Count = 0;
        }
        public MyLinkedList(T data)
        {
            SetHeadAndTail(data);
        }

        public void Add(T data)
        {
            var item = new Item<T>(data);

            if (Count == 0)
            {
                SetHeadAndTail(data);
            }
            else
            {
                Tail.Next = item;
                item.Previous = Tail;
                Tail = item;
                Count++;
            }
        }
        public void Delete(T data)
        {

            var current = Head;
            while (current != null)
            {
                if (current.Data!.Equals(data))
                {
                    if (Count == 1)
                    {
                        Head = null!;
                        Tail = null!;
                        Count = 0;
                        break;
                    }
                    if (current.Previous == null)
                    {
                        Head = current.Next;
                        current.Next.Previous = null!;
                        Count--;
                        break;
                    }
                    if (current.Next == null)
                    {
                        Tail = current.Previous;
                        current.Previous.Next = null!;
                        Count--;
                        break;
                    }
                    current.Previous.Next = current.Next;
                    current.Next.Previous = current.Previous;
                    Count--;
                    break;
                }
                else
                {
                    current = current.Next;
                }
            }
        }

        public MyLinkedList<T> Reverse()
        {
            MyLinkedList<T> links = new MyLinkedList<T>();
            var current = Tail;

            while (current != null)
            {
                links.Add(current.Data);
                current = current.Previous;
            }

            return links;
        }

        private void SetHeadAndTail(T data)
        {
            Item<T> item = new Item<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (IEnumerator<T>)GetEnumerator();
        }


        public override string ToString()
        {
            return $"Список содержит {Count} элементов";
        }
    }
}
