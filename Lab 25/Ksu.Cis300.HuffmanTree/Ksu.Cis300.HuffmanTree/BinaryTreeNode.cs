/* BinaryTreeNode.cs
 * Author: Rod Howell
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KansasStateUniversity.TreeViewer2;

namespace Ksu.Cis300.ImmutableBinaryTrees
{
    /// <summary>
    /// An immutable node for a generic binary tree.
    /// </summary>
    /// <typeparam name="T">The type of the data stored in the node.</typeparam>
    public class BinaryTreeNode<T> : ITree
    {
        /// <summary>
        /// The data stored in this node.
        /// </summary>
        private T _data;

        /// <summary>
        /// Gets the data stored in this node.
        /// </summary>
        public T Data
        {
            get
            {
                return _data;
            }
        }

        /// <summary>
        /// The left child of this node.
        /// </summary>
        private BinaryTreeNode<T> _leftChild;

        /// <summary>
        /// Gets the left child of this node.
        /// </summary>
        public BinaryTreeNode<T> LeftChild
        {
            get
            {
                return _leftChild;
            }
        }

        /// <summary>
        /// The right child of this node.
        /// </summary>
        private BinaryTreeNode<T> _rightChild;

        /// <summary>
        /// Gets the right child of this node.
        /// </summary>
        public BinaryTreeNode<T> RightChild
        {
            get
            {
                return _rightChild;
            }
        }

        /// <summary>
        /// Constructs a node containing the given data, left child, and right child.
        /// </summary>
        /// <param name="data">The data item to be stored in this node.</param>
        /// <param name="left">The left child of this node.</param>
        /// <param name="right">The right child of this node.</param>
        public BinaryTreeNode(T data, BinaryTreeNode<T> left, BinaryTreeNode<T> right)
        {
            _data = data;
            _leftChild = left;
            _rightChild = right;
        }

        /// <summary>
        /// Gets an array containing this nodes children.
        /// </summary>
        ITree[] ITree.Children
        {
            get
            {
                ITree[] children = new ITree[2];
                children[0] = _leftChild;
                children[1] = _rightChild;
                return children;
            }
        }

        /// <summary>
        /// Gets whether this node is an empty tree. Because it cannot be,
        /// it always returns false.
        /// </summary>
        bool ITree.IsEmpty
        {
            get { return false; }
        }

        /// <summary>
        /// Returns the data at the root of this tree.
        /// </summary>
        object ITree.Root
        {
            get { return _data; }
        }
    }
}
