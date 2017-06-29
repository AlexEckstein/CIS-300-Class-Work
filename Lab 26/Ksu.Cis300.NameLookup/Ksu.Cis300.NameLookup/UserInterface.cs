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
using KansasStateUniversity.TreeViewer2;
using Ksu.Cis300.ImmutableBinaryTrees;

namespace Ksu.Cis300.NameLookup
{
    /// <summary>
    /// A GUI for a program that retrieves information about last names in
    /// a sample of US data.
    /// </summary>
    public partial class UserInterface : Form
    {
        /// <summary>
        /// The names in the sample.
        /// </summary>
        private Dictionary<string, NameInformation> _names = new Dictionary<string, NameInformation>();

        /// <summary>
        /// Constructs a new GUI.
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles a Click event on the Open Data File button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOpen_Click(object sender, EventArgs e)
        {
            if (uxOpenDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _names = ReadNames(uxOpenDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        /// <summary>
        /// Handles a Click event on the Get Statistics button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxLookup_Click(object sender, EventArgs e)
        {
            string name = uxName.Text.Trim().ToUpper();
            NameInformation info; ;
            if (_names.TryGetValue(name, out info))
            {
                uxFrequency.Text = info.Frequency.ToString();
                uxRank.Text = info.Rank.ToString();
            }
            else
            {
                MessageBox.Show("Name not found.");
                uxFrequency.Text = "";
                uxRank.Text = "";
            }
        }

        /// <summary>
        /// Reads the name data in the given file.
        /// </summary>
        /// <param name="fn">The name of the file to read.</param>
        /// <returns>A dictionary containing the data read.</returns>
        private Dictionary<string, NameInformation> ReadNames(string fn)
        {
            Dictionary<string,NameInformation> names = new Dictionary<string, NameInformation>();
            using (StreamReader input = new StreamReader(fn))
            {
                while (!input.EndOfStream)
                {
                    string name = input.ReadLine().Trim();
                    float freq = Convert.ToSingle(input.ReadLine());
                    int rank = Convert.ToInt32(input.ReadLine());
                    names.Add(name, new NameInformation(name, freq, rank));
                }
            }
            return names;
        }

        /// <summary>
        /// Handles a Click event on the Remove button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxRemove_Click(object sender, EventArgs e)
        {
            if (_names.Remove(uxName.Text.Trim().ToUpper()))
            {
                MessageBox.Show("Name removed.");
            }
            else
            {
                MessageBox.Show("Name not found.");
            }
            uxName.Text = "";
            uxFrequency.Text = "";
            uxRank.Text = "";
        }

        /// <summary>
        /// Writes the information in the given binary search tree in alphabetic order of the names.
        /// </summary>
        /// <param name="output">The stream to which the information is written.</param>
        /// <param name="d">The dictionary containing the information to be written.</param>
        private void WriteInformation(StreamWriter output, Dictionary<string, NameInformation> d)
        {
            foreach (NameInformation info in d.Values)
            { 
                output.WriteLine(info.Name);
                output.WriteLine(info.Frequency);
                output.WriteLine(info.Rank);
            }
        }

        /// <summary>
        /// Handles a Click event on the Save button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSave_Click(object sender, EventArgs e)
        {
            if (uxSaveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter output = new StreamWriter(uxSaveDialog.FileName))
                    {
                        WriteInformation(output, _names);
                        MessageBox.Show("File written.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
