/* Board.cs
 * Author: Rod Howell
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.Nim
{
    /// <summary>
    /// An immutable representation of a Nim board position.
    /// </summary>
    public class Board
    {
        /// <summary>
        /// The number of stones on each pile.
        /// </summary>
        private int[] _piles;

        /// <summary>
        /// The limit for each pile.
        /// </summary>
        private int[] _limits;

        /// <summary>
        /// The hash code for this board.
        /// </summary>
        private int _hashCode;

        /// <summary>
        /// Indicates whether this board's hash code has been computed.
        /// </summary>
        private bool _hashCodeIsComputed = false;

        /// <summary>
        /// Gets the number of piles.
        /// </summary>
        public int NumberOfPiles
        {
            get
            {
                return _piles.Length;
            }
        }

        /// <summary>
        /// Constructs a new Board.
        /// </summary>
        /// <param name="piles">The number of stones on each pile.</param>
        /// <param name="limits">The limit for each pile.</param>
        public Board(int[] piles, int[] limits)
        {
            if (piles.Length != limits.Length)
            {
                throw new ArgumentException();
            }
            _piles = new int[piles.Length];
            piles.CopyTo(_piles, 0);
            _limits = new int[limits.Length];
            limits.CopyTo(_limits, 0);
        }

        /// <summary>
        /// Gets the result of making the given play from this board position.
        /// </summary>
        /// <param name="p">The play to make.</param>
        /// <returns>The resulting board position.</returns>
        public Board MakePlay(Play p)
        {
            if (p.Pile > _piles.Length || p.Number > _limits[p.Pile])
            {
                throw new ArgumentException();
            }
            Board b = new Board(_piles, _limits);
            b._piles[p.Pile] -= p.Number;
            b._limits[p.Pile] = Math.Min(b._piles[p.Pile], 2 * p.Number);
            return b;
        }

        /// <summary>
        /// Gets the number of stones on the given pile.
        /// </summary>
        /// <param name="pile">The pile.</param>
        /// <returns>The number of stones on the given pile.</returns>
        public int GetValue(int pile)
        {
            if (pile < 0 || pile >= _piles.Length)
            {
                throw new ArgumentException();
            }
            return _piles[pile];
        }

        /// <summary>
        /// Gets the limit for the given pile.
        /// </summary>
        /// <param name="pile">The pile.</param>
        /// <returns>The limit for the given pile.</returns>
        public int GetLimit(int pile)
        {
            if (pile < 0 || pile >= _piles.Length)
            {
                throw new ArgumentException();
            }
            return _limits[pile];
        }

        /// <summary>
        /// Determines whether the given Boards are equal.
        /// </summary>
        /// <param name="x">The first Board.</param>
        /// <param name="y">The second Board.</param>
        /// <returns>Whether the given Boards are equal.</returns>
        public static bool operator ==(Board x, Board y)
        {
            if (Equals(x, null))
            {
                return (Equals(y, null));
            }
            else if (Equals(y, null))
            {
                return false;
            }
            else
            {
                if (x._piles.Length != y._piles.Length)
                {
                    return false;
                }
                for (int i = 0; i < x._piles.Length; i++)
                {
                    if (x._piles[i] != y._piles[i] || x._limits[i] != y._limits[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        /// <summary>
        /// Determnines whether the given Boards are different.
        /// </summary>
        /// <param name="x">The first Board.</param>
        /// <param name="y">The second Board.</param>
        /// <returns>Whether the two Boards are different.</returns>
        public static bool operator !=(Board x, Board y)
        {
            return !(x == y);
        }

        /// <summary>
        /// Determines whether this Board is equal to the given object.
        /// </summary>
        /// <param name="obj">The object to compare to.</param>
        /// <returns>Whether this Board is equal to obj.</returns>
        public override bool Equals(object obj)
        {
            if (obj is Board)
            {
                return this == (Board)obj;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Retrieves the hash code for this board.
        /// </summary>
        /// <returns>The hash code.</returns>
        public override int GetHashCode()
        {
            if (!_hashCodeIsComputed)
            {
                _hashCode = _piles.Length;
                for (int i = 0; i < _piles.Length; i++)
                {
					unchecked
					{
						_hashCode *= 37;
						_hashCode += _piles[i];
						_hashCode *= 37;
						_hashCode += _limits[i];
					}
                }
                _hashCodeIsComputed = true;
            }
            return _hashCode;
        }
    }
}
