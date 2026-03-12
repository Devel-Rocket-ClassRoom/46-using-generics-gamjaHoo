using System;
using System.Collections.Generic;
using System.Text;

namespace GenericStack
{
    class MyStack<T>
    {
        private T[] items;
        private int _count;

        public int Count { get { return _count; } }

        public bool IsEmpty { get { return _count == 0; } }

        public MyStack(int capacity)
        {
            items = new T[capacity];
        }

        public void Push(T item)
        {
            if (_count >= items.Length)
            {
                Console.WriteLine("스택이 가득 찼습니다.");
                return;
            }

            items[_count] = item;
            _count++;
        }

        public T Pop()
        {
            if (IsEmpty)
            {
                Console.WriteLine("스택이 비어있습니다.");
                return default(T);
            }

            _count--;
            return items[_count];
        }

        public T Peek()
        {
            if (IsEmpty)
            {
                Console.WriteLine("스택이 비어있습니다.");
                return default(T);
            }

            return items[_count - 1];
        }
    }
}
