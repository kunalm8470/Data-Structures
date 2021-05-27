using doubly_linked_list.Models;

namespace doubly_linked_list.Interfaces
{
    public interface IDoubleLinkedList<T> where T : struct
    {
        public DoubleLinkedList<T> InsertRear(T data);
        public DoubleLinkedList<T> InsertFront(T data);
        public bool Contains(T data);
        public DoubleLinkedList<T> Delete(T data);
        public DoubleLinkedList<T> DeleteFront();
    }
}
