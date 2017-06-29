﻿/* TrieWithManyChildren.cs
 * Author: Rod Howell
 */
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.WordLookup
{
    /// <summary>
    /// A single trie node having more than one child.
    /// </summary>
    public class TrieWithManyChildren : ITrie
    {
        /// <summary>
        /// Indicates whether this trie contains the empty string.
        /// </summary>
        private bool _hasEmptyString = false;

        /// <summary>
        /// The children of this trie.
        /// </summary>
        private ITrie[] _children = new ITrie[26];

        /// <summary>
        /// Constructs a new trie containing the given string, along with the empty string if the
        /// given bool is true, and having the given child with the given label.
        /// </summary>
        /// <param name="s">A string to be contained in this trie.</param>
        /// <param name="hasEmpty">Indicates whether this trie should contain the empty string.</param>
        /// <param name="childLabel">The label for the given child.</param>
        /// <param name="child">The child to be contained.</param>
        public TrieWithManyChildren(string s, bool hasEmpty, char childLabel, ITrie child)
        {
            _hasEmptyString = hasEmpty;
            if (childLabel < 'a' || childLabel > 'z')
            {
                throw new ArgumentException();
            }
            _children[childLabel - 'a'] = child;
            Add(s);
        }

        /// <summary>
        /// Determines whether the trie rooted at this node contains the given string.
        /// </summary>
        /// <param name="s">The string to look up.</param>
        /// <returns>Whether the trie rooted at this node contains s.</returns>
        public bool Contains(string s)
        {
            if (s == "")
            {
                return _hasEmptyString;
            }
            else if (s[0] < 'a' || s[0] > 'z')
            {
                return false;
            }
            else
            {
                int loc = s[0] - 'a';
                if (_children[loc] == null)
                {
                    return false;
                }
                else
                {
                    return _children[loc].Contains(s.Substring(1));
                }
            }
        }

        /// <summary>
        /// Adds the given string to the trie rooted at this node.
        /// If the string contains any characters other than lower-case English letters,
        /// throws an ArgumentException.
        /// </summary>
        /// <param name="s">The string to add.</param>
        /// <returns>The resulting trie.</returns>
        public ITrie Add(string s)
        {
            if (s == "")
            {
                _hasEmptyString = true;
            }
            else if (s[0] < 'a' || s[0] > 'z')
            {
                throw new ArgumentException();
            }
            else
            {
                int loc = s[0] - 'a';
                if (_children[loc] == null)
                {
                    _children[loc] = new TrieWithNoChildren();
                }
                _children[loc] = _children[loc].Add(s.Substring(1));
            }
            return this;
        }

        /// <summary>
        /// Gets all of the strings that form words in this trie when appended to the given prefix.
        /// </summary>
        /// <param name="prefix">The prefix</param>
        /// <returns>A trie containing all of the strings that form words in this trie when appended
        /// to the given prefix.</returns>
        public ITrie GetCompletions(string prefix)
        {
            if (prefix == "")
            {
                return this;
            }
            else
            {
                int loc = prefix[0] - 'a';
                if (loc < 0 || loc >= _children.Length || _children[loc] == null)
                {
                    return null;
                }
                else
                {
                    return _children[loc].GetCompletions(prefix.Substring(1));
                }
            }
        }

        /// <summary>
        /// Adds all of the strings in this trie alphabetically to the end of the given list, with each
        /// string prefixed by the given prefix.
        /// </summary>
        /// <param name="prefix">The prefix.</param>
        /// <param name="list">The list to which the strings are to be added.</param>
        public void AddAll(StringBuilder prefix, IList list)
        {
            if (_hasEmptyString)
            {
                list.Add(prefix.ToString());
            }
            for (int i = 0; i < _children.Length; i++)
            {
                if (_children[i] != null)
                {
                    prefix.Append((char)('a' + i));
                    _children[i].AddAll(prefix, list);
                    prefix.Length--;
                }
            }
        }
    }
}
