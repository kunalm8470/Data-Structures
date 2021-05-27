using singly_linked_list.Models;

namespace singly_linked_list.Interfaces
{
    interface ISinglyLinkedList<T> where T : struct
    {
        SinglyLinkedList<T> InsertRear(T data);
        SinglyLinkedList<T> Delete(T data);
        Node<T> Reverse(Node<T> head);
    }
}
