namespace MyStack.Model
{
    public class EasyStack<T> : ICloneable
    {
        private List<T> items;
        public int Count => items.Count;
        public bool IsEmpty => Count== 0;
        public EasyStack()
        {
            items = new List<T>();
        }

        public void Push(T item)
        {
            items.Add(item);
        }
        public T Peek()
        {
            if (!IsEmpty)
            {
                return items.LastOrDefault();
            }
            else
            {
                throw new NullReferenceException("Стек пуст");
            }
        }
        public T Pop()
        {
            if (!IsEmpty)
            {
                T item = items.LastOrDefault();
                items.RemoveAt(items.Count - 1);
                return item;
            }
            else
            {
                throw new NullReferenceException("Стек пуст");
            }
        }

        public void Clear()
        {
            items.Clear();
        }
        public object Clone()
        {
            var newStack = new EasyStack<T>();
            newStack.items = new List<T>(items);
            return newStack;
        }

        public override string ToString()
        {
            return $"Стек с {Count} элементами";
        }
    }
}
