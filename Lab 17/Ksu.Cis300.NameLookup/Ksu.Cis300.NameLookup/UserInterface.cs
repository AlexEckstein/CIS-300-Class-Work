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
        private BinaryTreeNode<NameInformation> _names = null;

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
                    new TreeForm(_names, 100).Show();
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
            NameInformation info = GetInformation(name, _names);
            if (info.Name == null)
            {
                MessageBox.Show("Name not found.");
                uxFrequency.Text = "";
                uxRank.Text = "";
            }
            else
            {
                uxFrequency.Text = info.Frequency.ToString();
                uxRank.Text = info.Rank.ToString();
            }
        }

        /// <summary>
        /// Reads the name data in the given file.
        /// </summary>
        /// <param name="fn">The name of the file to read.</param>
        /// <returns>A binary search tree containing the data read.</returns>
        private BinaryTreeNode<NameInformation> ReadNames(string fn)
        {
            BinaryTreeNode<NameInformation> names = null;
            using (StreamReader input = new StreamReader(fn))
            {
                while (!input.EndOfStream)
                {
                    string name = input.ReadLine().Trim();
                    float freq = Convert.ToSingle(input.ReadLine());
                    int rank = Convert.ToInt32(input.ReadLine());
                    names = Add(new NameInformation(name, freq, rank), names);
                }
            }
            return names;
        }

        /// <summary>
        /// Finds the information associated with the given name in the given binary search tree.
        /// If the given name is not in the tree, returns a NameInformation with a null name.
        /// </summary>
        /// <param name="name">The name to look for.</param>
        /// <param name="t">The binary search tree to look in.</param>
        /// <returns>The NameInformation containing the given name, or a NameInformation with a null name
        /// if the tree does not contain the name.</returns>
        private NameInformation GetInformation(string name, BinaryTreeNode<NameInformation> t)
        {
            if (t == null)
            {
                return new NameInformation();
            }
            else
            {
                int comp = name.CompareTo(t.Data.Name);
                if (comp == 0)
                {
                    return t.Data;
                }
                else if (comp < 0)
                {
                    return GetInformation(name, t.LeftChild);
                }
                else
                {
                    return GetInformation(name, t.RightChild);
                }
            }
        }

        /// <summary>
        /// Builds the binary search tree that results from adding the given NameInformation to the given tree.
        /// </summary>
        /// <param name="info">The data to add to the tree.</param>
        /// <param name="t">The binary search tree to which the data will be added.</param>
        /// <returns>The resulting tree.</returns>
        private BinaryTreeNode<NameInformation> Add(NameInformation info, BinaryTreeNode<NameInformation> t)
        {
            if (t == null)
            {
                return new BinaryTreeNode<NameInformation>(info, null, null);
            }
            else
            {
                int comp = info.Name.CompareTo(t.Data.Name);
                if (comp == 0)
                {
                    throw new ArgumentException();
                }
                else if (comp < 0)
                {
                    return new BinaryTreeNode<NameInformation>(t.Data, Add(info, t.LeftChild), t.RightChild);
                }
                else
                {
                    return new BinaryTreeNode<NameInformation>(t.Data, t.LeftChild, Add(info, t.RightChild));
                }
            }
        }

        /// <summary>
        /// Handles a Click event on the Remove button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxRemove_Click(object sender, EventArgs e)
        {
            bool removed;
            _names = Remove(uxName.Text.Trim().ToUpper(), _names, out removed);
            if (removed)
            {
                MessageBox.Show("Name removed.");
                new TreeForm(_names, 100).Show();
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
        /// Removes the element with minimum name from the given binary search tree, which must not be null.
        /// </summary>
        /// <param name="t">The binary search tree from which to remove the minimum.</param>
        /// <param name="min">The data removed.</param>
        /// <returns>The resulting binary search tree.</returns>
        private BinaryTreeNode<NameInformation> RemoveMinimumName(BinaryTreeNode<NameInformation> t, out NameInformation min)
        {
            if (t.LeftChild == null)
            {
                min = t.Data;
                return t.RightChild;
            }
            else
            {
                return new BinaryTreeNode<NameInformation>(t.Data, RemoveMinimumName(t.LeftChild, out min), t.RightChild);
            }
        }

        /// <summary>
        /// Builds the binary search tree that results from removing the NameInformation containing the given name from the given tree.
        /// </summary>
        /// <param name="name">The name to remove.</param>
        /// <param name="t">The binary search tree from which to remove the name.</param>
        /// <param name="removed">Indicates whether the name was found.</param>
        /// <returns>The resulting binary search tree.</returns>
        private BinaryTreeNode<NameInformation> Remove(string name, BinaryTreeNode<NameInformation> t, out bool removed)
        {
            if (t == null)
            {
                removed = false;
                return t;
            }
            else
            {
                int comp = name.CompareTo(t.Data.Name);
                if (comp == 0)
                {
                    removed = true;
                    if (t.LeftChild == null)
                    {
                        return t.RightChild;
                    }
                    else if (t.RightChild == null)
                    {
                        return t.LeftChild;
                    }
                    else
                    {
                        NameInformation min;
                        BinaryTreeNode<NameInformation> newRight = RemoveMinimumName(t.RightChild, out min);
                        return new BinaryTreeNode<NameInformation>(min, t.LeftChild, newRight);
                    }
                }
                else if (comp < 0)
                {
                    return new BinaryTreeNode<NameInformation>(t.Data, Remove(name, t.LeftChild, out removed), t.RightChild);
                }
                else
                {
                    return new BinaryTreeNode<NameInformation>(t.Data, t.LeftChild, Remove(name, t.RightChild, out removed));
                }
            }
        }
    }
}
