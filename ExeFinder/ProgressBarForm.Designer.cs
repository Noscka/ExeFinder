
namespace ExeFinder
{
    partial class ProgressBarForm
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
            this.panel = new System.Windows.Forms.Panel();
            this.CopyingTextLabel = new System.Windows.Forms.Label();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel.Controls.Add(this.CopyingTextLabel);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(484, 70);
            this.panel.TabIndex = 0;
            this.panel.UseWaitCursor = true;
            // 
            // CopyingTextLabel
            // 
            this.CopyingTextLabel.Font = new System.Drawing.Font("BankGothic Lt BT", 12F);
            this.CopyingTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(126)))), ((int)(((byte)(175)))));
            this.CopyingTextLabel.Location = new System.Drawing.Point(25, 23);
            this.CopyingTextLabel.Name = "CopyingTextLabel";
            this.CopyingTextLabel.Size = new System.Drawing.Size(450, 25);
            this.CopyingTextLabel.TabIndex = 0;
            this.CopyingTextLabel.Text = "Copying...";
            this.CopyingTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CopyingTextLabel.UseWaitCursor = true;
            // 
            // pBar
            // 
            this.pBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pBar.Location = new System.Drawing.Point(50, 150);
            this.pBar.Name = "pBar";
            this.pBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pBar.Size = new System.Drawing.Size(400, 23);
            this.pBar.Step = 1;
            this.pBar.TabIndex = 1;
            this.pBar.UseWaitCursor = true;
            // 
            // ProgressBarForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.pBar);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProgressBarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Copying";
            this.UseWaitCursor = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProgressBarForm_FormClosing);
            this.Load += new System.EventHandler(this.ProgressBarForm_Load);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label CopyingTextLabel;
        private System.Windows.Forms.ProgressBar pBar;

    }
}