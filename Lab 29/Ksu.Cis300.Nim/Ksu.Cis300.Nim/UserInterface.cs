/* UserInterface.cs
 * Author: Rod Howell
 */
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ksu.Cis300.LinkedListLibrary;

namespace Ksu.Cis300.Nim
{
    /// <summary>
    /// A GUI for a program that plays a variant of Nim.
    /// </summary>
    public partial class UserInterface : Form
    {
        /// <summary>
        /// The status message to show during the setup phase.
        /// </summary>
        private const string _setupMessage = "Set up board";

        /// <summary>
        /// The status message to show when it's the computer's turn.
        /// </summary>
        private const string _computerPlayMessage = "My turn";

        /// <summary>
        /// The status message that it is the human player's turn.
        /// </summary>
        private const string _humanPlayMessage = "Your turn";

        /// <summary>
        /// The names displayed for each of the piles.
        /// </summary>
        private string[] _pileNames = { "Pile 1", "Pile 2", "Pile 3" };

        /// <summary>
        /// The graphical controls displaying the number of stones on each pile.
        /// </summary>
        private NumericUpDown[] _pileControls;

        /// <summary>
        /// The graphical controls displaying the limit for each pile.
        /// </summary>
        private NumericUpDown[] _limitControls;

        /// <summary>
        /// The current board position.
        /// </summary>
        private Board _currentPosition;

        /// <summary>
        /// The best play for each board position examined so far.
        /// </summary>
        private Dictionary<Board, Play> _bestPlays = new Dictionary<Board, Play>();

        /// <summary>
        /// Constructs the GUI
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
            _pileControls = new NumericUpDown[] { uxValue1, uxValue2, uxValue3 };
            _limitControls = new NumericUpDown[] { uxLimit1, uxLimit2, uxLimit3 };
            Setup();
        }

        /// <summary>
        /// Places the game in the setup phase.
        /// </summary>
        private void Setup()
        {
            uxStatus.Text = _setupMessage;
            uxStart.Enabled = true;
            uxRemove.Enabled = false;
            uxRemovePile.Enabled = false;
            uxPlay.Enabled = false;
            for (int i = 0; i < _pileControls.Length; i++)
            {
                _pileControls[i].Minimum = 1;
                _limitControls[i].Minimum = 1;
                _pileControls[i].Enabled = true;
                _limitControls[i].Enabled = true;
            }
        }

        /// <summary>
        /// Handles a Click event on the "Start Game" button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxStart_Click(object sender, EventArgs e)
        {
            int[] piles = new int[_pileControls.Length];
            int[] limits = new int[_pileControls.Length];
            for (int i = 0; i < _pileControls.Length; i++)
            {
                _pileControls[i].Minimum = 0;
                _limitControls[i].Minimum = 0;
                _limitControls[i].Value = Math.Min(_limitControls[i].Value, _pileControls[i].Value);
                _pileControls[i].Enabled = false;
                _limitControls[i].Enabled = false;
                piles[i] = (int)_pileControls[i].Value;
                limits[i] = (int)_limitControls[i].Value;
            }
            _currentPosition = new Board(piles, limits);
            uxStart.Enabled = false;
            ComputerPlay();
            uxRemove.Enabled = true;
            uxRemovePile.Enabled = true;
            uxPlay.Enabled = true;
        }

        /// <summary>
        /// Makes the computer's play.
        /// </summary>
        private void ComputerPlay()
        {
            uxStatus.Text = _computerPlayMessage;
            Update();
            Play p = FindBestPlay(_currentPosition);
            if (p == null)
            {
                int i = 0;
                while (_currentPosition.GetValue(i) == 0)
                {
                    i++;
                }
                p = new Play(i, 1);
            }
            if (MakePlay(p))
            {
                MessageBox.Show("I take " + p.Number + " stones from " + _pileNames[p.Pile] + " and win!");
                Setup();
            }
            else
            {
                MessageBox.Show("I take " + p.Number + " stones from " + _pileNames[p.Pile] + ".");
                uxStatus.Text = _humanPlayMessage;
            }
        }

        /// <summary>
        /// Makes the given play.
        /// </summary>
        /// <param name="p">The play to make.</param>
        /// <returns>Whether the game is over.</returns>
        private bool MakePlay(Play p)
        {
            _currentPosition = _currentPosition.MakePlay(p);
            _pileControls[p.Pile].Value = _currentPosition.GetValue(p.Pile);
            _limitControls[p.Pile].Value = _currentPosition.GetLimit(p.Pile);
            UpdateAvailablePiles();
            return uxRemovePile.Items.Count == 0;
        }

        /// <summary>
        /// Updates the list of available piles to those that are nonempty.
        /// </summary>
        private void UpdateAvailablePiles()
        {
            uxRemovePile.Items.Clear();
            for (int i = 0; i < _currentPosition.NumberOfPiles; i++)
            {
                if (_currentPosition.GetValue(i) > 0)
                {
                    uxRemovePile.Items.Add(_pileNames[i]);
                }
            }
            if (uxRemovePile.Items.Count > 0)
            {
                uxRemovePile.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Finds a winning play from the given position if there is one.
        /// </summary>
        /// <param name="b">The board position.</param>
        /// <returns>A winning play, or null if there is no winning play.</returns>
        private Play FindBestPlay(Board b)
        {
            Play p;
            if (_bestPlays.TryGetValue(b, out p))
            {
                return p;
            }
            for (int i = 0; i < b.NumberOfPiles; i++)
            {
                for (int j = 1; j <= b.GetLimit(i); j++)
                {
                    p = new Play(i, j);
                    Board child = b.MakePlay(p);
                    if (FindBestPlay(child) == null)
                    {
                        _bestPlays.Add(b, p);
                        return p;
                    }
                }
            }
            _bestPlays.Add(b, null);
            return null;
        }

        /// <summary>
        /// Handles a Selected Index Changed event on the list of piles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxRemovePile_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = GetSelectedPile();
            uxRemove.Maximum = _currentPosition.GetLimit(i);
        }

        /// <summary>
        /// Gets the pile chosen by the user.
        /// </summary>
        /// <returns>The index of the pile chosen by the user.</returns>
        private int GetSelectedPile()
        {
            int i = 0;
            while (_pileNames[i] != (string)uxRemovePile.SelectedItem)
            {
                i++;
            }
            return i;
        }

        /// <summary>
        /// Handles a Click event on the Play button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxPlay_Click(object sender, EventArgs e)
        {
            int i = GetSelectedPile();
            if (MakePlay(new Play(i, (int)uxRemove.Value)))
            {
                MessageBox.Show("You win!");
                Setup();
            }
            else
            {
                ComputerPlay();
            }
        }
    }
}
