using stack.Models;
using System;

namespace stack
{
    class Program
    {
        static void Main(string[] args)
        {
            StackImpl<int> stk = new StackImpl<int>()
                                .Push(1)
                                .Push(2)
                                .Push(3)
                                .Push(4)
                                .Push(5)
                                .Push(6)
                                .Push(7);

            Console.WriteLine("Popped - {0}", stk.Pop());
            Console.WriteLine("Popped - {0}", stk.Pop());

            foreach (int item in stk)
            {
                Console.WriteLine(item);
            }
        }
    }
}
