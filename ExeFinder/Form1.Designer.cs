
namespace ExeFinder
{
    partial class Form1
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
            this.Control_Bar = new System.Windows.Forms.Panel();
            this.MinimizePictureBox = new System.Windows.Forms.PictureBox();
            this.ExitPictureBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AfterFirstSearch = new System.Windows.Forms.Panel();
            this.CopyButton = new System.Windows.Forms.Button();
            this.Search2 = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.FolderNumberLabel = new System.Windows.Forms.Label();
            this.FileNumberLabel = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.SizeNumberLabel = new System.Windows.Forms.Label();
            this.SizeEXELabel = new System.Windows.Forms.Label();
            this.SizeEXE = new System.Windows.Forms.Label();
            this.ExeNumber = new System.Windows.Forms.Label();
            this.FileNumber = new System.Windows.Forms.Label();
            this.FolderNumber = new System.Windows.Forms.Label();
            this.SizeNumber = new System.Windows.Forms.Label();
            this.exeshow = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FinderMain = new System.ComponentModel.BackgroundWorker();
            this.CopySelect = new System.Windows.Forms.OpenFileDialog();
            this.Control_Bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.AfterFirstSearch.SuspendLayout();
            this.exeshow.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Control_Bar
            // 
            this.Control_Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Control_Bar.Controls.Add(this.MinimizePictureBox);
            this.Control_Bar.Controls.Add(this.ExitPictureBox);
            this.Control_Bar.Controls.Add(this.panel2);
            this.Control_Bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Control_Bar.Location = new System.Drawing.Point(0, 0);
            this.Control_Bar.Name = "Control_Bar";
            this.Control_Bar.Size = new System.Drawing.Size(418, 32);
            this.Control_Bar.TabIndex = 1;
            this.Control_Bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ControlBar_Panel_MouseDown);
            // 
            // MinimizePictureBox
            // 
            this.MinimizePictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizePictureBox.Image = global::ExeFinder.Properties.Resources._;
            this.MinimizePictureBox.Location = new System.Drawing.Point(354, 0);
            this.MinimizePictureBox.Name = "MinimizePictureBox";
            this.MinimizePictureBox.Size = new System.Drawing.Size(32, 32);
            this.MinimizePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MinimizePictureBox.TabIndex = 3;
            this.MinimizePictureBox.TabStop = false;
            this.MinimizePictureBox.Click += new System.EventHandler(this.MinimizePictureBox_Click);
            this.MinimizePictureBox.MouseLeave += new System.EventHandler(this.MinimizePictureBox_MouseLeave);
            this.MinimizePictureBox.MouseHover += new System.EventHandler(this.MinimizePictureBox_MouseHover);
            // 
            // ExitPictureBox
            // 
            this.ExitPictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitPictureBox.Image = global::ExeFinder.Properties.Resources.x;
            this.ExitPictureBox.Location = new System.Drawing.Point(386, 0);
            this.ExitPictureBox.Name = "ExitPictureBox";
            this.ExitPictureBox.Size = new System.Drawing.Size(32, 32);
            this.ExitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ExitPictureBox.TabIndex = 3;
            this.ExitPictureBox.TabStop = false;
            this.ExitPictureBox.Click += new System.EventHandler(this.ExitPictureBox_Click);
            this.ExitPictureBox.MouseLeave += new System.EventHandler(this.ExitPictureBox_MouseLeave);
            this.ExitPictureBox.MouseHover += new System.EventHandler(this.ExitPictureBox_MouseHover);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(132, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 175);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.AfterFirstSearch);
            this.panel1.Controls.Add(this.SearchButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 382);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 54);
            this.panel1.TabIndex = 2;
            // 
            // AfterFirstSearch
            // 
            this.AfterFirstSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.AfterFirstSearch.Controls.Add(this.CopyButton);
            this.AfterFirstSearch.Controls.Add(this.Search2);
            this.AfterFirstSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AfterFirstSearch.Location = new System.Drawing.Point(0, 0);
            this.AfterFirstSearch.Name = "AfterFirstSearch";
            this.AfterFirstSearch.Size = new System.Drawing.Size(418, 54);
            this.AfterFirstSearch.TabIndex = 3;
            this.AfterFirstSearch.Visible = false;
            // 
            // CopyButton
            // 
            this.CopyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CopyButton.Location = new System.Drawing.Point(209, 17);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(90, 25);
            this.CopyButton.TabIndex = 0;
            this.CopyButton.Text = "Copy";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // Search2
            // 
            this.Search2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Search2.Location = new System.Drawing.Point(119, 17);
            this.Search2.Name = "Search2";
            this.Search2.Size = new System.Drawing.Size(90, 25);
            this.Search2.TabIndex = 0;
            this.Search2.Text = "Search";
            this.Search2.UseVisualStyleBackColor = true;
            this.Search2.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.SearchButton.Location = new System.Drawing.Point(164, 17);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(90, 25);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // FolderNumberLabel
            // 
            this.FolderNumberLabel.AutoSize = true;
            this.FolderNumberLabel.Font = new System.Drawing.Font("BankGothic Lt BT", 20F);
            this.FolderNumberLabel.ForeColor = System.Drawing.Color.White;
            this.FolderNumberLabel.Location = new System.Drawing.Point(12, 35);
            this.FolderNumberLabel.Name = "FolderNumberLabel";
            this.FolderNumberLabel.Size = new System.Drawing.Size(142, 28);
            this.FolderNumberLabel.TabIndex = 3;
            this.FolderNumberLabel.Text = "Folders:";
            // 
            // FileNumberLabel
            // 
            this.FileNumberLabel.AutoSize = true;
            this.FileNumberLabel.Font = new System.Drawing.Font("BankGothic Lt BT", 20F);
            this.FileNumberLabel.ForeColor = System.Drawing.Color.White;
            this.FileNumberLabel.Location = new System.Drawing.Point(12, 63);
            this.FileNumberLabel.Name = "FileNumberLabel";
            this.FileNumberLabel.Size = new System.Drawing.Size(93, 28);
            this.FileNumberLabel.TabIndex = 3;
            this.FileNumberLabel.Text = "Files:";
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("BankGothic Lt BT", 20F);
            this.Label.ForeColor = System.Drawing.Color.White;
            this.Label.Location = new System.Drawing.Point(12, 91);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(96, 28);
            this.Label.TabIndex = 3;
            this.Label.Text = "EXEs:";
            // 
            // SizeNumberLabel
            // 
            this.SizeNumberLabel.AutoSize = true;
            this.SizeNumberLabel.Font = new System.Drawing.Font("BankGothic Lt BT", 20F);
            this.SizeNumberLabel.ForeColor = System.Drawing.Color.White;
            this.SizeNumberLabel.Location = new System.Drawing.Point(12, 147);
            this.SizeNumberLabel.Name = "SizeNumberLabel";
            this.SizeNumberLabel.Size = new System.Drawing.Size(173, 28);
            this.SizeNumberLabel.TabIndex = 3;
            this.SizeNumberLabel.Text = "Total Size:";
            // 
            // SizeEXELabel
            // 
            this.SizeEXELabel.AutoSize = true;
            this.SizeEXELabel.Font = new System.Drawing.Font("BankGothic Lt BT", 20F);
            this.SizeEXELabel.ForeColor = System.Drawing.Color.White;
            this.SizeEXELabel.Location = new System.Drawing.Point(12, 119);
            this.SizeEXELabel.Name = "SizeEXELabel";
            this.SizeEXELabel.Size = new System.Drawing.Size(150, 28);
            this.SizeEXELabel.TabIndex = 3;
            this.SizeEXELabel.Text = "EXE Size:";
            // 
            // SizeEXE
            // 
            this.SizeEXE.AutoSize = true;
            this.SizeEXE.Font = new System.Drawing.Font("BankGothic Lt BT", 20F);
            this.SizeEXE.ForeColor = System.Drawing.Color.White;
            this.SizeEXE.Location = new System.Drawing.Point(191, 119);
            this.SizeEXE.Name = "SizeEXE";
            this.SizeEXE.Size = new System.Drawing.Size(205, 28);
            this.SizeEXE.TabIndex = 3;
            this.SizeEXE.Text = "PlaceHolder";
            this.SizeEXE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SizeEXE.Visible = false;
            // 
            // ExeNumber
            // 
            this.ExeNumber.AutoSize = true;
            this.ExeNumber.Font = new System.Drawing.Font("BankGothic Lt BT", 20F);
            this.ExeNumber.ForeColor = System.Drawing.Color.White;
            this.ExeNumber.Location = new System.Drawing.Point(191, 91);
            this.ExeNumber.Name = "ExeNumber";
            this.ExeNumber.Size = new System.Drawing.Size(205, 28);
            this.ExeNumber.TabIndex = 3;
            this.ExeNumber.Text = "PlaceHolder";
            this.ExeNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExeNumber.Visible = false;
            // 
            // FileNumber
            // 
            this.FileNumber.AutoSize = true;
            this.FileNumber.Font = new System.Drawing.Font("BankGothic Lt BT", 20F);
            this.FileNumber.ForeColor = System.Drawing.Color.White;
            this.FileNumber.Location = new System.Drawing.Point(191, 63);
            this.FileNumber.Name = "FileNumber";
            this.FileNumber.Size = new System.Drawing.Size(205, 28);
            this.FileNumber.TabIndex = 3;
            this.FileNumber.Text = "PlaceHolder";
            this.FileNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FileNumber.Visible = false;
            // 
            // FolderNumber
            // 
            this.FolderNumber.AutoSize = true;
            this.FolderNumber.Font = new System.Drawing.Font("BankGothic Lt BT", 20F);
            this.FolderNumber.ForeColor = System.Drawing.Color.White;
            this.FolderNumber.Location = new System.Drawing.Point(191, 35);
            this.FolderNumber.Name = "FolderNumber";
            this.FolderNumber.Size = new System.Drawing.Size(205, 28);
            this.FolderNumber.TabIndex = 3;
            this.FolderNumber.Text = "PlaceHolder";
            this.FolderNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FolderNumber.Visible = false;
            // 
            // SizeNumber
            // 
            this.SizeNumber.AutoSize = true;
            this.SizeNumber.Font = new System.Drawing.Font("BankGothic Lt BT", 20F);
            this.SizeNumber.ForeColor = System.Drawing.Color.White;
            this.SizeNumber.Location = new System.Drawing.Point(191, 147);
            this.SizeNumber.Name = "SizeNumber";
            this.SizeNumber.Size = new System.Drawing.Size(205, 28);
            this.SizeNumber.TabIndex = 3;
            this.SizeNumber.Text = "PlaceHolder";
            this.SizeNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SizeNumber.Visible = false;
            // 
            // exeshow
            // 
            this.exeshow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.exeshow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exeshow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.exeshow.Controls.Add(this.panel3);
            this.exeshow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.exeshow.Location = new System.Drawing.Point(0, 189);
            this.exeshow.Name = "exeshow";
            this.exeshow.Size = new System.Drawing.Size(418, 166);
            this.exeshow.TabIndex = 4;
            this.exeshow.WrapContents = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(381, 54);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("BankGothic Lt BT", 8F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(57, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(608, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "D:\\Users\\Adam\\Documents\\Programming Projects\\Visual Studio Projects\\Csharp\\Tudor\'" +
    "s NewsFeed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "afwagwag";
            // 
            // FinderMain
            // 
            this.FinderMain.WorkerReportsProgress = true;
            this.FinderMain.WorkerSupportsCancellation = true;
            this.FinderMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.FinderMain_DoWork);
            this.FinderMain.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.FinderMain_ProgressChanged);
            // 
            // CopySelect
            // 
            this.CopySelect.CheckFileExists = false;
            this.CopySelect.FileName = "Folder Selection.";
            this.CopySelect.Title = "Select File to Upload";
            this.CopySelect.ValidateNames = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(418, 436);
            this.Controls.Add(this.exeshow);
            this.Controls.Add(this.SizeEXELabel);
            this.Controls.Add(this.FolderNumber);
            this.Controls.Add(this.FileNumber);
            this.Controls.Add(this.ExeNumber);
            this.Controls.Add(this.SizeNumber);
            this.Controls.Add(this.SizeEXE);
            this.Controls.Add(this.SizeNumberLabel);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.FileNumberLabel);
            this.Controls.Add(this.FolderNumberLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Control_Bar);
            this.Font = new System.Drawing.Font("BankGothic Lt BT", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Control_Bar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.AfterFirstSearch.ResumeLayout(false);
            this.exeshow.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Control_Bar;
        private System.Windows.Forms.PictureBox MinimizePictureBox;
        private System.Windows.Forms.PictureBox ExitPictureBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label FolderNumberLabel;
        private System.Windows.Forms.Label FileNumberLabel;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label SizeNumberLabel;
        private System.Windows.Forms.Label SizeEXELabel;
        private System.Windows.Forms.Label SizeEXE;
        private System.Windows.Forms.Label ExeNumber;
        private System.Windows.Forms.Label FileNumber;
        private System.Windows.Forms.Label FolderNumber;
        private System.Windows.Forms.Label SizeNumber;
        private System.Windows.Forms.FlowLayoutPanel exeshow;
        private System.ComponentModel.BackgroundWorker FinderMain;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel AfterFirstSearch;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button Search2;
        private System.Windows.Forms.OpenFileDialog CopySelect;
    }
}

