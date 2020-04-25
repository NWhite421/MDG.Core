namespace MDG.Core
{
    partial class StringInput
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblMessage = new System.Windows.Forms.Label();
            this.TxtEntry = new System.Windows.Forms.TextBox();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblMessage
            // 
            this.LblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblMessage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMessage.Location = new System.Drawing.Point(10, 10);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(363, 62);
            this.LblMessage.TabIndex = 0;
            this.LblMessage.Text = "label1";
            // 
            // TxtEntry
            // 
            this.TxtEntry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtEntry.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TxtEntry.Location = new System.Drawing.Point(10, 74);
            this.TxtEntry.Name = "TxtEntry";
            this.TxtEntry.Size = new System.Drawing.Size(364, 25);
            this.TxtEntry.TabIndex = 1;
            this.TxtEntry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            // 
            // CmdCancel
            // 
            this.CmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CmdCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.CmdCancel.Location = new System.Drawing.Point(10, 105);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(66, 27);
            this.CmdCancel.TabIndex = 2;
            this.CmdCancel.Text = "Cancel";
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CnclButton);
            // 
            // CmdEnter
            // 
            this.CmdEnter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdEnter.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.CmdEnter.Location = new System.Drawing.Point(308, 105);
            this.CmdEnter.Name = "CmdEnter";
            this.CmdEnter.Size = new System.Drawing.Size(66, 27);
            this.CmdEnter.TabIndex = 3;
            this.CmdEnter.Text = "Submit";
            this.CmdEnter.UseVisualStyleBackColor = true;
            this.CmdEnter.Click += new System.EventHandler(this.SubmitInput);
            // 
            // StringInput
            // 
            this.AcceptButton = this.CmdEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CmdCancel;
            this.ClientSize = new System.Drawing.Size(384, 144);
            this.Controls.Add(this.CmdEnter);
            this.Controls.Add(this.CmdCancel);
            this.Controls.Add(this.TxtEntry);
            this.Controls.Add(this.LblMessage);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 316);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 175);
            this.Name = "StringInput";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StringInput";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtEntry;
        private System.Windows.Forms.Button CmdCancel;
        private System.Windows.Forms.Button CmdEnter;
        internal System.Windows.Forms.Label LblMessage;
    }
}