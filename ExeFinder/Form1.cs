using System;
using System.Threading;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Linq;
using System.IO;

namespace ExeFinder
{
    public partial class Form1 : Form
    {
        static readonly string[] SizeSuffixes =
                   { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };

        private int CopyAmount, searchamount;
        private string currentdir, exesizesuffix;
        private ProgressBarForm progressBarForm;
        private BackgroundWorker copybgw;

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public BackgroundWorker formWorker
        {
            get
            {
                return copybgw;
            }
        }

        public Form1()
        {
            InitializeComponent();
            copybgw = new BackgroundWorker();
            copybgw.WorkerSupportsCancellation = true;
            copybgw.DoWork += new DoWorkEventHandler(copybgw_DoWork);
            copybgw.ProgressChanged += new ProgressChangedEventHandler(copybgw_ProgressChanged);
            copybgw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(copybgw_RunWorkerCompleted);
            copybgw.WorkerReportsProgress = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBarForm = new ProgressBarForm(this);
        }

        private void ControlBar_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void ExitPictureBox_MouseHover(object sender, EventArgs e)
        {
            ExitPictureBox.BackColor = Color.FromArgb(240, 71, 71);
        }

        private void ExitPictureBox_MouseLeave(object sender, EventArgs e)
        {
            ExitPictureBox.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void ExitPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizePictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MinimizePictureBox_MouseHover(object sender, EventArgs e)
        {
            MinimizePictureBox.BackColor = Color.FromArgb(50, 53, 56);
        }

        private void MinimizePictureBox_MouseLeave(object sender, EventArgs e)
        {
            MinimizePictureBox.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.ShowNewFolderButton = false;
                fbd.SelectedPath = Environment.CurrentDirectory;
                DialogResult result = fbd.ShowDialog();
                

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    exeshow.Controls.Clear();
                    exeshow.AutoScroll = true;
                    currentdir = fbd.SelectedPath;
                    string[] files = Directory.GetFiles(fbd.SelectedPath, "*", SearchOption.AllDirectories);
                    string[] Folders = Directory.GetDirectories(fbd.SelectedPath,"*", SearchOption.AllDirectories);
                    string[] exefiles = Directory.GetFiles(fbd.SelectedPath, "*.exe", SearchOption.AllDirectories);

                    long exesize = 0;
                    long totalsize = 0;
                    var dirInfo = new DirectoryInfo(fbd.SelectedPath);

                    foreach (FileInfo fi in dirInfo.GetFiles("*.exe", SearchOption.AllDirectories))
                    {
                        exesize += fi.Length;
                    }

                    foreach (FileInfo fi in dirInfo.GetFiles("*", SearchOption.AllDirectories))
                    {
                        totalsize += fi.Length;
                    }


                    FileNumber.Visible = true; FolderNumber.Visible = true; ExeNumber.Visible = true; SizeNumber.Visible = true; SizeEXE.Visible = true;
                    FileNumber.Text = files.Length.ToString();
                    FolderNumber.Text = Folders.Length.ToString();
                    ExeNumber.Text = exefiles.Length.ToString();
                    SizeNumber.Text = SizeSuffix(totalsize);
                    exesizesuffix = SizeSuffix(exesize);
                    SizeEXE.Text = exesizesuffix;

                    CopyAmount = exefiles.Length;
                    AfterFirstSearch.Visible = true;
                    searchamount = exefiles.Length;

                    FinderMain.RunWorkerAsync();
                    progressBarForm.ShowDialog();
                }
            }
        }


        private void FinderMain_DoWork(object sender, DoWorkEventArgs e)
        {
            var dirInfo = new DirectoryInfo(currentdir);
            int currentdone = 0;
            BackgroundWorker backgroundWorker = sender as BackgroundWorker;


            if (backgroundWorker != null)
            {
                while (!backgroundWorker.CancellationPending)
                {
                    foreach (FileInfo fi in dirInfo.GetFiles("*.exe", SearchOption.AllDirectories))
                    {
                        ///panel
                        Panel panel = new Panel();
                        panel.BackColor = Color.FromArgb(82, 82, 82);
                        panel.Size = new Size(376, 54);
                        panel.BorderStyle = BorderStyle.FixedSingle;


                        ///imagebox
                        var exeimage = new PictureBox();
                        exeimage.Image = Bitmap.FromHicon(new Icon(Icon.ExtractAssociatedIcon(fi.FullName), new Size(48, 48)).Handle);
                        exeimage.SizeMode = PictureBoxSizeMode.CenterImage;
                        exeimage.Size = new Size(48, 48);

                        ///Name
                        var nameLabel = new Label();
                        nameLabel.Text = fi.Name;
                        nameLabel.AutoSize = true;
                        nameLabel.Size = new Size(93, 17);
                        nameLabel.Font = new Font(nameLabel.Font.FontFamily, 12);
                        nameLabel.ForeColor = Color.White;
                        nameLabel.Location = new Point(57, 3);


                        ///directory
                        var directoryLabel = new Label();
                        directoryLabel.Text = fi.FullName;
                        directoryLabel.Size = new Size(608, 12);
                        directoryLabel.Font = new Font(directoryLabel.Font.FontFamily, 8);
                        directoryLabel.ForeColor = SystemColors.ControlDark;
                        directoryLabel.Location = new Point(57, 34);


                        ///adding to control
                        panel.Controls.Add(exeimage);
                        panel.Controls.Add(nameLabel);
                        panel.Controls.Add(directoryLabel);

                        currentdone++;
                        backgroundWorker.ReportProgress(currentdone, panel);
                        if (backgroundWorker.CancellationPending)
                        {
                            e.Cancel = true;
                            MessageBox.Show("Cancelled the operation");
                        }
                    }
                }
            }
        }

        private void FinderMain_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
           Panel panel = (Panel)e.UserState;

            exeshow.Controls.Add(panel);
            double dProgress = ((double)e.ProgressPercentage / searchamount) * 100.0;
            progressBarForm.UpdateProgressBar($@"Getting {e.ProgressPercentage}/{searchamount}", Convert.ToInt32(dProgress));
        }


        static string SizeSuffix(Int64 value, int decimalPlaces = 1)
        {
            if (decimalPlaces < 0) { throw new ArgumentOutOfRangeException("decimalPlaces"); }
            if (value < 0) { return "-" + SizeSuffix(-value, decimalPlaces); }
            if (value == 0) { return string.Format("{0:n" + decimalPlaces + "} bytes", 0); }

            // mag is 0 for bytes, 1 for KB, 2, for MB, etc.
            int mag = (int)Math.Log(value, 1024);

            // 1L << (mag * 10) == 2 ^ (10 * mag) 
            // [i.e. the number of bytes in the unit corresponding to mag]
            decimal adjustedSize = (decimal)value / (1L << (mag * 10));

            // make adjustment when the value is large enough that
            // it would round up to 1000 or more
            if (Math.Round(adjustedSize, decimalPlaces) >= 1000)
            {
                mag += 1;
                adjustedSize /= 1024;
            }

            return string.Format("{0:n" + decimalPlaces + "} {1}",
                adjustedSize,
                SizeSuffixes[mag]);
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            using (CopySelect)
            {
                CopySelect.InitialDirectory = Environment.CurrentDirectory;
                CopySelect.RestoreDirectory = true;

                if (CopySelect.ShowDialog() == DialogResult.OK)
                {
                    string path = CopySelect.FileName;

                    copybgw.RunWorkerAsync(argument: path);
                    progressBarForm.ShowDialog();
                }
            }
        }

        private void copybgw_DoWork(object sender, DoWorkEventArgs e)
        {
            string path = e.Argument.ToString();
            var dirInfo = new DirectoryInfo(currentdir);
            int donesofar = 0;

            BackgroundWorker backgroundWorker = sender as BackgroundWorker;
            if (backgroundWorker != null)
            {
                while (!backgroundWorker.CancellationPending)
                {
                    foreach (FileInfo fi in dirInfo.GetFiles("*.exe", SearchOption.AllDirectories))
                    {
                        File.Copy(Path.GetDirectoryName(fi.FullName), path);
                        donesofar++;

                        backgroundWorker.ReportProgress(donesofar);
                        if (backgroundWorker.CancellationPending)
                        {
                            e.Cancel = true;
                            MessageBox.Show("Cancelled the operation");
                        }
                    }
                    
                }
                
            }
        }

        private void copybgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            double dProgress = ((double)e.ProgressPercentage / CopyAmount) * 100.0;
            progressBarForm.UpdateProgressBar($@"Copying {e.ProgressPercentage}/{CopyAmount}    {exesizesuffix}", Convert.ToInt32(dProgress));
        }

        private void copybgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBarForm.Close();
        }
    }
}
