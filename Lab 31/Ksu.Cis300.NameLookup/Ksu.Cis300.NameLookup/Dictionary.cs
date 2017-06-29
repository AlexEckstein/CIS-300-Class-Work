﻿/* Dictionary.cs
 * Author: Rod Howell
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.NameLookup
{
    /// <summary>
    /// A dictionary implemented using a hash table.
    /// </summary>
    /// <typeparam name="TKey">The key type.</typeparam>
    /// <typeparam name="TValue">The value type.</typeparam>
    public class Dictionary<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
    {
        /// <summary>
        /// The initial size of the hash table.
        /// </summary>
        private const int _initialSize = 197;

        /// <summary>
        /// The hash table.
        /// </summary>
        private LinkedListCell<KeyValuePair<TKey, TValue>>[] _table = new LinkedListCell<KeyValuePair<TKey, TValue>>[_initialSize];

        /// <summary>
        /// The allowable sizes for the hash table.
        /// </summary>
        private int[] _tableSizes =
        {
            _initialSize, 397, 797, 1597, 3203, 6421, 12853, 25717, 51437, 102877,
            205759, 411527, 823117, 1646237, 3292489, 6584983, 13169977,
            26339969, 52679969, 105359939, 210719881, 421439783, 842879579,
            1685759167
        };

        /// <summary>
        /// The index in _tableSizes of the current table size.
        /// </summary>
        private int _sizeIndex = 0;

        /// <summary>
        /// The number of keys in the hash table.
        /// </summary>
        private int _count = 0;

        /// <summary>
        /// Verifies that the given key is non-null. If k is null, throws an ArgumentNullException.
        /// </summary>
        /// <param name="k">The key to check.</param>
        private void CheckKey(TKey k)
        {
            if (k == null)
            {
                throw new ArgumentNullException();
            }
        }

        /// <summary>
        /// Gets the table location in which the given key belongs.
        /// </summary>
        /// <param name="k">The key.</param>
        /// <returns>The table location in which k belongs.</returns>
        private int GetLocation(TKey k)
        {
            return (k.GetHashCode() & 0x7fffffff) % _table.Length;
        }

        /// <summary>
        /// Finds the cell with the given key in the given linked list.
        /// </summary>
        /// <param name="k">The key to look for.</param>
        /// <param name="list">The beginning of the linked list to search.</param>
        /// <returns>The cell containing k, or null if there is no such cell.</returns>
        private LinkedListCell<KeyValuePair<TKey, TValue>> GetCell(TKey k, LinkedListCell<KeyValuePair<TKey, TValue>> list)
        {
            for (LinkedListCell<KeyValuePair<TKey, TValue>> p = list; p != null; p = p.Next)
            {
                if (k.Equals(p.Data.Key))
                {
                    return p;
                }
            }
            return null;
        }

        /// <summary>
        /// Inserts the given cell at the beginning of the linked list at the given table location.
        /// </summary>
        /// <param name="cell">The cell to insert.</param>
        /// <param name="loc">The table location containing the linked list in which the cell is to be
        /// inserted.</param>
        private void Insert(LinkedListCell<KeyValuePair<TKey, TValue>> cell, int loc)
        {
            cell.Next = _table[loc];
            _table[loc] = cell;
        }

        /// <summary>
        /// Inserts the given key and value into a new cell at the beginning of the linked list at the
        /// given table location.
        /// </summary>
        /// <param name="k">The key to insert.</param>
        /// <param name="v">The value to insert.</param>
        /// <param name="loc">The table location containing the linked list in which the given key and
        /// value are to be inserted.</param>
        private void Insert(TKey k, TValue v, int loc)
        {
            LinkedListCell<KeyValuePair<TKey, TValue>> cell = new LinkedListCell<KeyValuePair<TKey, TValue>>();
            cell.Data = new KeyValuePair<TKey, TValue>(k, v);
            Insert(cell, loc);
            _count++;
            if (_count > _table.Length && _sizeIndex < _tableSizes.Length - 1)
            {
                _sizeIndex++;
                LinkedListCell<KeyValuePair<TKey, TValue>>[] t = _table;
                _table = new LinkedListCell<KeyValuePair<TKey, TValue>>[_tableSizes[_sizeIndex]];
                for (int i = 0; i < t.Length; i++)
                {
                    while (t[i] != null)
                    {
                        cell = t[i];
                        t[i] = t[i].Next;
                        Insert(cell, GetLocation(cell.Data.Key));
                    }
                }
            }
        }

        /// <summary>
        /// Tries to get the value associated with the given key. If k is null, throws an ArgumentNullException.
        /// </summary>
        /// <param name="k">The key to look for.</param>
        /// <param name="v">The value associated with k, or the default value for this type if k is not in the
        /// dictionary.</param>
        /// <returns>Whether the was found.</returns>
        public bool TryGetValue(TKey k, out TValue v)
        {
            CheckKey(k);
            LinkedListCell<KeyValuePair<TKey, TValue>> cell = GetCell(k, _table[GetLocation(k)]);
            if (cell == null)
            {
                v = default(TValue);
                return false;
            }
            else
            {
                v = cell.Data.Value;
                return true;
            }
        }

        /// <summary>
        /// Associates the given value with the given key. If k is null, throws an ArgumentNullException.
        /// If k is already in the table, throws an ArgumentException.
        /// </summary>
        /// <param name="k">The key to add.</param>
        /// <param name="v">The value to associate with k.</param>
        public void Add(TKey k, TValue v)
        {
            CheckKey(k);
            int loc = GetLocation(k);
            LinkedListCell<KeyValuePair<TKey, TValue>> cell = GetCell(k, _table[loc]);
            if (cell == null)
            {
                Insert(k, v, loc);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        /// <summary>
        /// Gets an enumerator for the KeyValuePairs in this dictionary.
        /// </summary>
        /// <returns>The enumerator.</returns>
        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return new DictionaryEnumerator(_table);
        }

        /// <summary>
        /// Gets an enumerator for the KeyValuePairs in this dictionary.
        /// </summary>
        /// <returns>The enumerator.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Enumerates the key-value pairs stored in a dictionary.
        /// </summary>
        public class DictionaryEnumerator : IEnumerator<KeyValuePair<TKey, TValue>>
        {
            /// <summary>
            /// The index in the hash table of the list containing the cell at the current
            /// position. If the current position it the starting position, this value is -1.
            /// If the current position is the ending position, this value is the length of 
            /// the hash table.
            /// </summary>
            private int _currentIndex = -1;

            /// <summary>
            /// The cell at the current position.  If the current position is the ending position,
            /// this reference is null.
            /// </summary>
            private LinkedListCell<KeyValuePair<TKey, TValue>> _currentCell = new LinkedListCell<KeyValuePair<TKey, TValue>>();

            /// <summary>
            /// The hash table in the dictionary being enumerated.
            /// </summary>
            private LinkedListCell<KeyValuePair<TKey, TValue>>[] _table;

            /// <summary>
            /// Gets the key-value pair at the current position.
            /// </summary>
            public KeyValuePair<TKey, TValue> Current
            {
                get
                {
                    if (_currentIndex == -1 || _currentIndex == _table.Length)
                    {
                        throw new InvalidOperationException();
                    }
                    return _currentCell.Data;
                }
            }

            /// <summary>
            /// Gets the key-value pair at the current position.
            /// </summary>
            object IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }

            /// <summary>
            /// Constructs an enumerator using the given hash table.
            /// </summary>
            /// <param name="table">The hash table containing the key-value pairs to enumerate.</param>
            public DictionaryEnumerator(LinkedListCell<KeyValuePair<TKey, TValue>>[] table)
            {
                _table = table;
            }

            /// <summary>
            /// Disposes any unmanaged resources (there are none).
            /// </summary>
            public void Dispose()
            {
               
            }

            /// <summary>
            /// Advances this enumerator to the next position.
            /// </summary>
            /// <returns>Whether this brings the enumerator to a position prior to the end.</returns>
            public bool MoveNext()
            {
                if (_currentCell == null)
                {
                    return false;
                }
                _currentCell = _currentCell.Next;
                while (_currentCell == null)
                {
                    _currentIndex++;
                    if (_currentIndex == _table.Length)
                    {
                        return false;
                    }
                    _currentCell = _table[_currentIndex];
                }
                return true;
            }

            /// <summary>
            /// Not implemented.
            /// </summary>
            public void Reset()
            {
                throw new NotImplementedException();
            }
        }
    }
}
