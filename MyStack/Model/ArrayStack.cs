namespace MyStack.Model
{
    public class ArrayStack<T>
    {
        T[] items;
        public int Capasity => items.Length;
        private int current = 0;
        public int Current => current;
        public ArrayStack(int size = 10)
        {
            items= new T[size];
        }
        public ArrayStack(T data, int size = 10) : this(size)
        {
            items[0] = data;
            current++;
        }

        public void Push(T data)
        {
            if (current+1 <= Capasity)
            {
                items[current] = data;
                current++;
            }
            else
                throw new StackOverflowException("стек переполнен");
        }

        public T Pop()
        {
            if (current > 0 && current <= Capasity)
            {
                T item = items[current-1];
                items[current-1] = default(T)!;
                current--;
                return item;
            }
            else
                throw new NullReferenceException("стек пуст");
        }

        public T Peek()
        {
            if (current > 0 && current <= Capasity)
            {
                return items[current - 1];
            }
            else
                throw new NullReferenceException("стек пуст");
        }

        public override string ToString()
        {
            return $"Стек содержит: {current} элементов";
        }
    }
}
