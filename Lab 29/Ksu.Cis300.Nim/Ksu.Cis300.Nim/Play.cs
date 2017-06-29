/* Play.cs
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
    /// A single play in Nim.
    /// </summary>
    public class Play
    {
        /// <summary>
        /// The pile from which stones are taken.
        /// </summary>
        private int _pile;

        /// <summary>
        /// Gets the pile from which stones are taken.
        /// </summary>
        public int Pile
        {
            get
            {
                return _pile;
            }
        }

        /// <summary>
        /// The number of stones taken.
        /// </summary>
        private int _number;

        /// <summary>
        /// Gets the number of stones taken.
        /// </summary>
        public int Number
        {
            get
            {
                return _number;
            }
        }

        /// <summary>
        /// Constructs a Play taking the given number of stones from the given pile.
        /// </summary>
        /// <param name="pile">The pile from which stones are taken.</param>
        /// <param name="number">The number of stones taken.</param>
        public Play(int pile, int number)
        {
            if (pile < 0 || number < 1)
            {
                throw new ArgumentException();
            }
            _pile = pile;
            _number = number;
        }
    }
}
