/* UserInterface.cs
 * Author: Rod Howell 
 */
using System;
//using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Ksu.Cis300.ImmutableBinaryTrees;
using KansasStateUniversity.TreeViewer2;

namespace Ksu.Cis300.NameLookup
{
    /// <summary>
    /// A GUI for a program that retrieves information about last names in
    /// a sample of US data.
    /// </summary>
    public partial class UserInterface : Form
    {
        /// <summary>
        /// The information on all the names.
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
                    _names = GetAllInformation(uxOpenDialog.FileName);
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
            NameInformation info;
            if (_names.TryGetValue(name, out info))
            {
                uxFrequency.Text = info.Frequency.ToString();
                uxRank.Text = info.Rank.ToString();
            }
            else
            {
                MessageBox.Show("Name not found.");
                uxRank.Text = "";
                uxFrequency.Text = "";
            }
        }

        /// <summary>
        /// Reads the given file and forms a dictionary from its contents.
        /// </summary>
        /// <param name="fn">The name of the file.</param>
        /// <returns>The dictionary containing all the name information.</returns>
        private Dictionary<string, NameInformation> GetAllInformation(string fn)
        {
            Dictionary<string, NameInformation> names = new Dictionary<string, NameInformation>();
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
        /// Writes the contents of the given binary tree to the given stream using an inorder traversal.
        /// </summary>
        /// <param name="t">The dictionary to write.</param>
        /// <param name="output">The stream to write to.</param>
        private void WriteAll(Dictionary<string, NameInformation> t, StreamWriter output)
        {
            foreach (System.Collections.Generic.KeyValuePair<string, NameInformation> kvp in t)
            {
                output.WriteLine(kvp.Value.Name);
                output.WriteLine(kvp.Value.Frequency);
                output.WriteLine(kvp.Value.Rank);
            }
        }

        /// <summary>
        /// Handles a Save event.
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
                        WriteAll(_names, output);
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
