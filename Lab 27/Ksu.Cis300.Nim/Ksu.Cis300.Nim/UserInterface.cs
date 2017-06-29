/* UserInterface.cs
 * Author: Rod Howell
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ksu.Cis300.Nim
{
    /// <summary>
    /// A GUI to compare two Nim boards for equality.
    /// </summary>
    public partial class UserInterface : Form
    {
        /// <summary>
        /// The controls for the piles on board 1.
        /// </summary>
        private NumericUpDown[] _piles1;

        /// <summary>
        /// The controls for the limits on board 1.
        /// </summary>
        private NumericUpDown[] _limits1;

        /// <summary>
        /// The controls for the piles on board 2.
        /// </summary>
        private NumericUpDown[] _piles2;

        /// <summary>
        /// The controls for the limits on board 2.
        /// </summary>
        private NumericUpDown[] _limits2;

        /// <summary>
        /// Constructs the GUI.
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
            _piles1 = new NumericUpDown[] { uxBoard1Value1, uxBoard1Value2, uxBoard1Value3 };
            _limits1 = new NumericUpDown[] { uxBoard1Limit1, uxBoard1Limit2, uxBoard1Limit3 };
            _piles2 = new NumericUpDown[] { uxBoard2Value1, uxBoard2Value2, uxBoard2Value3 };
            _limits2 = new NumericUpDown[] { uxBoard2Limit1, uxBoard2Limit2, uxBoard2Limit3 };
        }

        /// <summary>
        /// Handles a Click event on the Compare Boards button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxCompare_Click(object sender, EventArgs e)
        {
            Board board1 = new Board(GetValues(_piles1), GetValues(_limits1));
            Board board2 = new Board(GetValues(_piles2), GetValues(_limits2));
            board1.Equals(null);
            board2.Equals(_piles2);
            if (board1 != null && null != board2)
            {
                uxAreEqual.Text = board1.Equals(board2).ToString();
                uxAreDoubleEqual.Text = (board1 == board2).ToString();
            }
        }

        /// <summary>
        /// Gets the values from the given controls.
        /// </summary>
        /// <param name="controls">The controls whose values are to be retrieved.</param>
        /// <returns>An array containing the values on the given controls.</returns>
        private int[] GetValues(NumericUpDown[] controls)
        {
            int[] values = new int[controls.Length];
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = (int)controls[i].Value;
            }
            return values;
        }
    }
}
