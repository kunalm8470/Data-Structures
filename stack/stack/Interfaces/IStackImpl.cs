using stack.Models;

namespace stack.Interfaces
{
    public interface IStackImpl<T> where T : struct
    {
        public T Peek();
        public StackImpl<T> Push(T item);
        public T Pop();
    }
}
