namespace DoublyLinkedList.Model
{
    public class Item<T>
    {
        public T Data { get; set; }
        public Item<T> Next { get; set; }
        public Item<T> Previous { get; set; }

        public Item(T data)
        {
            Data = data;
            Next = null!;
            Previous = null!;
        }
        public override string ToString()
        {
            return Data!.ToString()!;
        }
    }
}
