using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeFinder
{
    public partial class ProgressBarForm : Form
    {
        Form1 myParent;

        public ProgressBarForm(Form1 myParent)
        {
            InitializeComponent();
            this.myParent = myParent;
        }

        private void ProgressBarForm_Load(object sender, EventArgs e)
        {

        }
        public void UpdateProgressBar(string copyingText, int value)
        {
            pBar.Value = value;
            CopyingTextLabel.Text = copyingText;
        }

        private void ProgressBarForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (myParent.formWorker.IsBusy)
            {
                myParent.formWorker.CancelAsync();
            }
        }
    }
}
