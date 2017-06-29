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
using Ksu.Cis300.Graphs;

namespace Ksu.Cis300.MaximumOutgoingWeight
{
    /// <summary>
    /// A user interface for a program that computes the maximum total outgoing edge weight from any
    /// node of a given directed graph.
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
        /// Handles a Click event on the "Read a Graph" button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxReadGraph_Click(object sender, EventArgs e)
        {
            if (uxOpenDialog.ShowDialog() == DialogResult.OK)
            {
                DirectedGraph<string, decimal> g = ReadGraph(uxOpenDialog.FileName);
                MessageBox.Show("Maximum outgoing edge weight = " + MaximumWeight(g));
            }
        }

        /// <summary>
        /// Reads a graph from the given file.
        /// </summary>
        /// <param name="fn">The file to read.</param>
        /// <returns>The graph represented in the file.</returns>
        private DirectedGraph<string, decimal> ReadGraph(string fn)
        {
            DirectedGraph<string, decimal> g = new DirectedGraph<string, decimal>();
            using (StreamReader input = new StreamReader(fn))
            {
                input.ReadLine();
                while (!input.EndOfStream)
                {
                    string line = input.ReadLine();
                    string[] fields = line.Split(',');
                    g.AddEdge(fields[0], fields[1], Convert.ToDecimal(fields[2]));
                }
            }
            return g;
        }

        /// <summary>
        /// Finds the maximum total outgoing edge weight from any node in the given graph.
        /// </summary>
        /// <param name="g">The graph to search.</param>
        /// <returns>The maximum total outgoing edge weight from any node in g.</returns>
        private decimal MaximumWeight(DirectedGraph<string, decimal> g)
        {
            decimal max = 0;
            foreach (string u in g.Nodes)
            {
                decimal sum = 0;
                foreach (Edge<string, decimal> e in g.OutgoingEdges(u))
                {
                    sum += e.Data;
                }
                if (sum > max)
                {
                    max = sum;
                }
            }
            return max;
        }
    }
}
