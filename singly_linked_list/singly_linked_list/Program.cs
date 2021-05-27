using singly_linked_list.Models;
using System;

namespace singly_linked_list
{
    class Program
    {
        static void Main(string[] args)
        {
			SinglyLinkedList<int> sl = new SinglyLinkedList<int>()
									.InsertRear(1)
									.InsertRear(2)
									.InsertRear(3)
									.InsertRear(4)
									.InsertRear(5);

			sl.Delete(2);

			foreach (Node<int> item in sl)
			{
				Console.WriteLine(item.Data);
			}

			SinglyLinkedList<int> slRev = new(sl.Reverse(sl.First));
            Console.WriteLine("Reversed");
			foreach (Node<int> item in slRev)
			{
				Console.WriteLine(item.Data);
			}
		}
    }
}
