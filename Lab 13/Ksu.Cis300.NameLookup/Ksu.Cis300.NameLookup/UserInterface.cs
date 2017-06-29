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
        private LinkedListCell<NameInformation> _names = null;

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
            for (LinkedListCell<NameInformation> p = _names; p != null; p = p.Next)
            {
                if (p.Data.Name == name)
                {
                    uxFrequency.Text = p.Data.Frequency.ToString();
                    uxRank.Text = p.Data.Rank.ToString();
                    return;
                }
            }
            MessageBox.Show("Name not found.");
            uxFrequency.Text = "";
            uxRank.Text = "";
        }

        /// <summary>
        /// Reads the name data in the given file.
        /// </summary>
        /// <param name="fn">The name of the file to read.</param>
        /// <returns>A linked list containing the data read.</returns>

        private LinkedListCell<NameInformation> ReadNames(string fn)
        {
            LinkedListCell<NameInformation> list = null;
            using (StreamReader input = new StreamReader(fn))
            {
                while (!input.EndOfStream)
                {
                    LinkedListCell<NameInformation> cell = new LinkedListCell<NameInformation>();
                    string name = input.ReadLine().Trim();
                    float freq = Convert.ToSingle(input.ReadLine());
                    int rank = Convert.ToInt32(input.ReadLine());
                    cell.Data = new NameInformation(name, freq, rank);
                    cell.Next = list;
                    list = cell;
                }
            }
            return list;
        }
    }
}
