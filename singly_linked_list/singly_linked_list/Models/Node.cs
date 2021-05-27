namespace singly_linked_list.Models
{
    public class Node<T>
	{
		public T Data { get; }
		public Node<T> Next { get; set; }

        public Node(T data)
        {
            Data = data;
        }
	}
}
