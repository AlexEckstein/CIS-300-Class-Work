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

namespace Ksu.Cis300.ParenthesisMatcher
{
    /// <summary>
    /// A GUI for a program that recognizes strings having balanced parentheses.
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
        /// Determines whether the given character is an opening parenthesis.
        /// </summary>
        /// <param name="c">The character to check.</param>
        /// <returns>Whether c is an opening parenthesis.</returns>
        private bool IsOpeningParenthesis(char c)
        {
            return c == '(' || c == '[' || c == '{';
        }

        /// <summary>
        /// Determines whether the given character is a closing parenthesis.
        /// </summary>
        /// <param name="c">The character to check.</param>
        /// <returns>Whether c is a closing parenthesis.</returns>
        private bool IsClosingParenthesis(char c)
        {
            return c == ')' || c == ']' || c == '}';
        }

        /// <summary>
        /// Determines whether the given characters for a matched pair
        /// of parentheses.
        /// </summary>
        /// <param name="a">The opening character.</param>
        /// <param name="b">The closing character.</param>
        /// <returns>Whether a and b form a matched pair of parentheses.</returns>
        private bool Matches(char a, char b)
        {
            return (a == '(' && b == ')') || (a == '[' && b == ']') ||
                (a == '{' && b == '}');
        }

        /// <summary>
        /// Displays a success message.
        /// </summary>
        private void ShowSuccess()
        {
            MessageBox.Show("The string is matched.");
        }

        /// <summary>
        /// Displays an error message.
        /// </summary>
        private void ShowError()
        {
            MessageBox.Show("The string is not matched.");
        }

        /// <summary>
        /// Handles a Click event on the "Check" button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxCheck_Click(object sender, EventArgs e)
        {
            string s = uxInput.Text;
            Stack<char> unmatched = new Stack<char>();
            foreach (char c in s)
            {
                if (IsOpeningParenthesis(c))
                {
                    unmatched.Push(c);
                }
                else if (IsClosingParenthesis(c))
                {
                    if (unmatched.Count > 0 && Matches(unmatched.Peek(), c))
                    {
                        unmatched.Pop();
                    }
                    else
                    {
                        ShowError();
                        return;
                    }
                }
            }
            if (unmatched.Count == 0)
            {
                ShowSuccess();
            }
            else
            {
                ShowError();
            }
        }
    }
}
