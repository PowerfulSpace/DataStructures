using System.Collections;

namespace LinkedList.Model
{
    public class LinkedList<T> :IEnumerable
    {
        public Item<T> Head { get; private set; }
        public Item<T> Tail { get; private set; }
        public int Count { get; private set; }

        public LinkedList()
        {
            Clear();
        }
        public LinkedList(T data)
        {
            SetHeadAndTail(data);
        }

        public void Add(T data)
        {
            if (Tail != null)
            {
                Item<T> item = new Item<T>(data);
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else
                SetHeadAndTail(data);

        }
        public void Delete(T data)
        {
            if (Head != null)
            {
                if (Head.Data!.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }

                Item<T> previous = Head;
                Item<T> current = Head.Next;

                while (current != null)
                {
                    if (current.Data!.Equals(data))
                    {
                        previous.Next = current.Next;
                        Count--;
                        return;
                    }
                    previous = current;
                    current = current.Next;
                }
            }
        }

        public void AppendHead(T data)
        {
            Item<T> item = new Item<T>(data);

            item.Next = Head!;
            Head = item;
            Count++;
        }

        public void InsertAfter(T target, T data)
        {
            if(Head != null)
            {
                var current = Head;

                while (current != null)
                {
                    if (current.Data!.Equals(target))
                    {
                        var item = new Item<T>(data);
                        item.Next = current.Next;
                        current.Next = item;
                        Count++;
                        return;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }
            }
        }

        public void Clear()
        {
            Head = null!;
            Tail = null!;
            Count = 0;
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
            Item<T> current = Head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;      
            }
        }

        public override string ToString()
        {
            return "LinkedList " + Count + " items";
        }
    }
}
