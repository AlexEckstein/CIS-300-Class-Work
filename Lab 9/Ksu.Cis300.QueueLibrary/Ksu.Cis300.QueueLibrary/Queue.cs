using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.QueueLibrary
{
    /// <summary>
    /// An implementation of a simple generic queue using a circular array.
    /// </summary>
    /// <typeparam name="T">The type of elements in the queue.</typeparam>
    public class Queue<T>
    {
        /// <summary>
        /// The elements of the queue.
        /// </summary>
        private T[] _elements = new T[5];

        /// <summary>
        /// The index of the element at the front of the queue.
        /// If the queue is empty, may be any valid index.
        /// </summary>
        private int _front = 0;

        /// <summary>
        /// The number of elements in the queue.
        /// </summary>
        private int _count = 0;

        /// <summary>
        /// Gets the number of elements in the queue.
        /// </summary>
        public int Count
        {
            get
            {
                return _count;
            }
        }

        /// <summary>
        /// Places the given element at the back of the queue.
        /// </summary>
        /// <param name="x">The element to enqueue.</param>
        public void Enqueue(T x)
        {
            if (_count == _elements.Length)
            {
                T[] el = new T[2 * _count];
                Array.Copy(_elements, _front, el, _front, _count - _front);
                Array.Copy(_elements, 0, el, _count, _front);
                _elements = el;
            }
            int loc = _front + _count;
            if (loc >= _elements.Length)
            {
                loc -= _elements.Length;
            }
            _elements[loc] = x;
            _count++;
        }

        /// <summary>
        /// Retrieves the element at the front of the queue.
        /// If the queue is empty, throws an InvalidOperationException.
        /// </summary>
        /// <returns>The element at the front of the queue.</returns>
        public T Peek()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException();
            }
            return _elements[_front];
        }

        /// <summary>
        /// Removes the element at the front of the queue.
        /// If the queue is empty, throws an InvalidOperationException.
        /// </summary>
        /// <returns>The element removed.</returns>
        public T Dequeue()
        {
            T x = Peek();
            _elements[_front] = default(T);
            _front++;
            if (_front == _elements.Length)
            {
                _front = 0;
            }
            _count--;
            return x;
        }
    }
}
