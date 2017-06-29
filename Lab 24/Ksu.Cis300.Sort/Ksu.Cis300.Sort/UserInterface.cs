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

namespace Ksu.Cis300.Sort
{
    /// <summary>
    /// A GUI for a simple sorting program.
    /// </summary>
    public partial class UserInterface : Form
    {
        /// <summary>
        /// Constructs the GUI.
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles a Click event on the "Sort File" button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSort_Click(object sender, EventArgs e)
        {
            if (uxOpenDialog.ShowDialog() == DialogResult.OK && uxSaveDialog.ShowDialog() == DialogResult.OK)
            {
                decimal leftToShow = uxNumber.Value;
                MinPriorityQueue<int, string> q = new MinPriorityQueue<int, string>();
                try
                {
                    using (StreamReader input = new StreamReader(uxOpenDialog.FileName))
                    {
                        int count = 0;
                        while (!input.EndOfStream)
                        {
                            int value = Convert.ToInt32(input.ReadLine());
                            count++;
                            q.Add(count.ToString(), value);
                            leftToShow = Show(q, leftToShow,
                                "Adding: " + (uxNumber.Value - leftToShow + 1));
                        }
                    }
                    using (StreamWriter output = new StreamWriter(uxSaveDialog.FileName))
                    {
                        leftToShow = uxNumber.Value;
                        while (q.Count > 0)
                        {
                            output.WriteLine("{0,10:D}", q.MininumPriority);
                            q.RemoveMinimumPriority();
                            leftToShow = Show(q, leftToShow,
                                "Removing: " + (uxNumber.Value - leftToShow + 1));
                        }
                    }
                    MessageBox.Show("Sorting complete.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The following error occurred: " + ex.ToString());
                }
            }
        }

        /// <summary>
        /// Shows the given min-priority queue with the given title, provided leftToShow is
        /// positive.
        /// </summary>
        /// <param name="q">The min-priority queue.</param>
        /// <param name="leftToShow">If positive, the drawing will be shown.</param>
        /// <param name="title">The form title.</param>
        /// <returns>leftToShow - 1 if leftToShow is positive, or leftToShow 
        /// otherwise.</returns>
        private decimal Show(MinPriorityQueue<int, string> q, decimal leftToShow,
            string title)
        {
            if (leftToShow > 0)
            {
                TreeForm f = q.HeapDrawing;
                f.Text = title;
                f.Show();
                leftToShow--;
            }
            return leftToShow;
        }
    }
}
