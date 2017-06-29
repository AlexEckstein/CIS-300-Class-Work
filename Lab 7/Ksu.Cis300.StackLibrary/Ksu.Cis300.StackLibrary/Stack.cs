/* Stack.cs
 * Author: Rod Howell
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.StackLibrary
{
    /// <summary>
    /// A simple generic stack.
    /// </summary>
    /// <typeparam name="T">The type of the elements in the stack.</typeparam>
    public class Stack<T>
    {
        /// <summary>
        /// The elements of the stack, with the bottom element at location 0.
        /// </summary>
        private T[] _elements = new T[5];

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
        /// Places the given element at the top of the stack.
        /// </summary>
        /// <param name="x">The element to push.</param>
        public void Push(T x)
        {
            if (_count == _elements.Length)
            {
                T[] el = new T[2 * _count];
                _elements.CopyTo(el, 0);
                _elements = el;
            }
            _elements[_count] = x;
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
            return _elements[_count - 1];
        }

        /// <summary>
        /// Removes the element at the top of the stack.
        /// If the stack is empty, throws an InvalidOperationException.
        /// </summary>
        /// <returns>The element removed.</returns>
        public T Pop()
        {
            T x = Peek();
            _count--;
            _elements[_count] = default(T);
            return x;
        }
    }
}
