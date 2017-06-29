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
using System.IO;

namespace Ksu.Cis300.WordLookup
{
    /// <summary>
    /// A GUI for a program to look up words in a dictionary.
    /// </summary>
    public partial class UserInterface : Form
    {
        /// <summary>
        /// The list of words.
        /// </summary>
        private ITrie _dictionary = new TrieWithNoChildren();

        /// <summary>
        /// Constructs the GUI.
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles a Click event on the Open Dictionary button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOpen_Click(object sender, EventArgs e)
        {
            if (uxOpenDialog.ShowDialog() == DialogResult.OK)
            {
                _dictionary = new TrieWithNoChildren();
                try
                {
                    using (StreamReader input = File.OpenText(uxOpenDialog.FileName))
                    {
                        while (!input.EndOfStream)
                        {
                            string word = input.ReadLine();
                            _dictionary = _dictionary.Add(word);
                        }
                    }
                    MessageBox.Show("Dictionary successfully read.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        /// <summary>
        /// Handles a Click event on the "Look up Word" button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxLookUp_Click(object sender, EventArgs e)
        {
            if (_dictionary.Contains(uxWord.Text))
            {
                MessageBox.Show("The word is found.");
            }
            else
            {
                MessageBox.Show("The word is not found.");
            }
        }
    }
}
