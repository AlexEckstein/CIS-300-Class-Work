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
using Ksu.Cis300.Sort;
using KansasStateUniversity.TreeViewer2;
using Ksu.Cis300.ImmutableBinaryTrees;

namespace Ksu.Cis300.HuffmanTree
{
    /// <summary>
    /// A GUI for a program to construct and display Huffman trees.
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
        /// Handles a Click event on the "Select a File" button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSelectFile_Click(object sender, EventArgs e)
        {
            if (uxOpenDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    BinaryTreeNode<byte> t = null;

                    t = GetHuffmanTree(GetLeaves(GetFrequencyTable(uxOpenDialog.FileName)));

                    new TreeForm(t, 100).Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        /// <summary>
        /// Obtains a frequency table for the given file.
        /// </summary>
        /// <param name="fn">The name of the file.</param>
        /// <returns>The frequency table.</returns>
        private long[] GetFrequencyTable(string fn)
        {
            long[] table = new long[256];
            using (FileStream input = new FileStream(fn, FileMode.Open, FileAccess.Read))
            {
                int b;
                while ((b = input.ReadByte()) != -1)
                {
                    table[b]++;
                }
            }
            return table;
        }

        /// <summary>
        /// Gets a min-priority queue containing the leaves of a Huffman tree for the given frequency table.
        /// The prioiries are the frequencies of the bytes contained in the leaves.
        /// </summary>
        /// <param name="freqTable">The frequency table.</param>
        /// <returns>A min-priority queue containing the leaves of a Huffman tree.</returns>
        private MinPriorityQueue<long, BinaryTreeNode<byte>> GetLeaves(long[] freqTable)
        {
            MinPriorityQueue<long, BinaryTreeNode<byte>> q = new MinPriorityQueue<long, BinaryTreeNode<byte>>();
            for (int i = 0; i < 256; i++)
            {
                if (freqTable[i] > 0)
                {
                    q.Add(new BinaryTreeNode<byte>((byte)i, null, null), freqTable[i]);
                }
            }
            return q;
        }

        /// <summary>
        /// Builds a Huffman tree from the given leaves.
        /// </summary>
        /// <param name="q">A min-priority queue containing the leaves of a Huffman tree. The priority of each leaf is the number
        /// of occurrences of the byte it contains.</param>
        /// <returns>The Huffman tree.</returns>
        private BinaryTreeNode<byte> GetHuffmanTree(MinPriorityQueue<long, BinaryTreeNode<byte>> q)
        {
            while (q.Count > 1)
            {
                long p1 = q.MininumPriority;
                BinaryTreeNode<byte> t1 = q.RemoveMinimumPriority();
                long p2 = q.MininumPriority;
                BinaryTreeNode<byte> t2 = q.RemoveMinimumPriority();
                q.Add(new BinaryTreeNode<byte>(0, t1, t2), p1 + p2);
            }
            return q.RemoveMinimumPriority();
        }
    }
}
