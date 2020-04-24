using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDG.Core
{
    public partial class StringInput : Form
    {
        /// <summary>
        /// The input from the user.
        /// </summary>
        public string Input { get; private set; }
        public StringInput()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creates an instance of the StringInput dialog.
        /// </summary>
        /// <param name="Message">The message to display.</param>
        public StringInput(string Message)
        {
            InitializeComponent();

            this.LblMessage.Text = Message;
            this.Text = "Input Dialog";
            this.Icon = SystemIcons.Question;

            using (Graphics g = CreateGraphics())
            {
                int cHeight = LblMessage.Height;
                SizeF size = g.MeasureString(LblMessage.Text, LblMessage.Font, LblMessage.Width);
                int nHeight = (int)Math.Ceiling(size.Height);
                this.Height = this.Height + (nHeight - cHeight);
            }
        }

        /// <summary>
        /// Creates an instance of the StringInput dialog.
        /// </summary>
        /// <param name="Message">The message to display.</param>
        /// <param name="Title">The title of the dialog.</param>
        public StringInput(string Message, string Title)
        {
            InitializeComponent();

            this.LblMessage.Text = Message;
            this.Text = Title;
            this.Icon = SystemIcons.Question;

            using (Graphics g = CreateGraphics())
            {
                int cHeight = LblMessage.Height;
                SizeF size = g.MeasureString(LblMessage.Text, LblMessage.Font, LblMessage.Width);
                int nHeight = (int)Math.Ceiling(size.Height);
                this.Height = this.Height + (nHeight - cHeight);
            }
        }

        private void SubmitInput(object s, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtEntry.Text))
            {
                Input = TxtEntry.Text;
            }
            else
            {
                Input = "";
            }

            this.DialogResult = DialogResult.OK;
            Log.AddInfo($"String input returned {Input}.");
            this.Close();
            return;
        }

        private void CnclButton(object s, EventArgs e)
        {
            Input = null;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            Log.AddInfo("String input was cancelled by user.");
            return;
        }

        /// <summary>
        /// Sets the default value and pre-fills the input box.
        /// </summary>
        /// <param name="Value">Set value.</param>
        public void SetDefaultInput(string Value)
        {
            Input = Value;
            TxtEntry.Text = Value;
            Log.AddInfo($"String input was preset to {Value} by user.");
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SubmitInput(this, new EventArgs());
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                CnclButton(this, new EventArgs());
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
