namespace LinkedList.Model
{
    public class Item<T>
    {
        public Item<T> Next { get; set; } = null!;

        private T data = default(T)!;
        public T Data
        {
            get => data;
            set
            {
                if(value != null)
                    data = value;
                else
                    throw new ArgumentNullException(nameof(value));
            }
        }

        public Item(T data)
        {
            Data= data;
        }

        public override string ToString()
        {
            return Data!.ToString()!;
        }
    }
}
