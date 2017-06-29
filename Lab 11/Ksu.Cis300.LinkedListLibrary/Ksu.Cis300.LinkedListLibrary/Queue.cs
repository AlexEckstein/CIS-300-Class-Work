/* Queue.cs
 * Author: Rod Howell
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.LinkedListLibrary
{
    /// <summary>
    /// A simple generic queue implemented using a linked list.
    /// </summary>
    /// <typeparam name="T">The type of elements in the queue.</typeparam>
    public class Queue<T>
    {
        /// <summary>
        /// The element at the front of the queue.
        /// </summary>
        private LinkedListCell<T> _front;

        /// <summary>
        /// The element at the back of the queue.
        /// </summary>
        private LinkedListCell<T> _back;

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
        /// Adds the given element to the back of the queue.
        /// </summary>
        /// <param name="x">The element to enqueue.</param>
        public void Enqueue(T x)
        {
            LinkedListCell<T> cell = new LinkedListCell<T>();
            if (_count == 0)
            {
                _front = cell;
            }
            else
            {
                _back.Next = cell;
            }
            _back = cell;
            cell.Data = x;
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
            return _front.Data;
        }

        /// <summary>
        /// Removes the element at the front of the queue.
        /// If the queue is empty, throws an InvalidOperationException.
        /// </summary>
        /// <returns>The element removed.</returns>
        public T Dequeue()
        {
            T x = Peek();
            _front = _front.Next;
            _count--;
            return x;
        }
    }
}
