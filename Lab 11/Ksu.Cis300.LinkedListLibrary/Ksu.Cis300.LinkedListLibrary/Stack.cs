/* Stack.cs
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
    /// A simple generic stack implemented using a linked list.
    /// </summary>
    /// <typeparam name="T">The type of the elements in the stack.</typeparam>
    public class Stack<T>
    {
        /// <summary>
        /// The elements of the stack.
        /// </summary>
        private LinkedListCell<T> _elements = null;

        /// <summary>
        /// The number of elements in the stack.
        /// </summary>
        private int _count = 0;

        /// <summary>
        /// Gets the number of elements in the stack.
        /// </summary>
        public int Count
        {
            get
            {
                return _count;
            }
        }

        /// <summary>
        /// Adds the given element to the top of the stack.
        /// </summary>
        /// <param name="x">The element to push.</param>
        public void Push(T x)
        {
            LinkedListCell<T> cell = new LinkedListCell<T>();
            cell.Data = x;
            cell.Next = _elements;
            _elements = cell;
            _count++;
        }

        /// <summary>
        /// Retrieves the element at the top of the stack.
        /// If the stack is empty, throws an InvalidOperationException.
        /// </summary>
        /// <returns>The element at the top of the stack.</returns>
        public T Peek()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException();
            }
            return _elements.Data;
        }

        /// <summary>
        /// Removes the element from the top of the stack.
        /// </summary>
        /// <returns>The element removed.</returns>
        public T Pop()
        {
            T x = Peek();
            _elements = _elements.Next;
            _count--;
            return x;
        }
    }
}
