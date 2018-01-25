using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ImageCompressor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(Form1_DragEnter);
            this.DragDrop += new DragEventHandler(Form1_DragDrop);
            ImageList = new List<string>();
        }

        void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop,false))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        void Form1_DragDrop(object sender, DragEventArgs e)
        {
           string[] WhiteExtension = { ".png",".jpg",".jpeg" };
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string file in files)
            {
                string ext = Path.GetExtension(file);
                //if its image
                if (WhiteExtension.Where(y=>y==ext.ToLower()).Any())
                {
                    ImageList.Add(file);
                }
            }
            SourceChanged();
        }
        public List<string> ImageList { get; set; }
        private void btnSource_Click(object sender, EventArgs e)
        {
            
            if (ofd_source.ShowDialog() == DialogResult.OK)
            {
                if (ofd_source.FileNames!=null)
                {
                    ImageList.AddRange(ofd_source.FileNames);
                }
                SourceChanged();
            }
        }

        private void SourceChanged()
        {
            txtSources.Text = "";
            foreach (var item in ImageList)
            {
                txtSources.Text += item + Environment.NewLine;
            }
        }

        private void btnSetWebPDir_Click(object sender, EventArgs e)
        {
            if (fbWebPDir.ShowDialog()== DialogResult.OK)
            {
                SetValueWebp(fbWebPDir.SelectedPath);
                MessageBox.Show("Path Saved");
            }
        }
        private void btnSetJPEGTranDir_Click(object sender, EventArgs e)
        {
            if (fbJPEGTranDir.ShowDialog() == DialogResult.OK)
            {
                SetValueJPEGTran(fbJPEGTranDir.SelectedPath);
                MessageBox.Show("Path Saved");
            }
        }
        private void SetValueWebp(string val)
        {
            Environment.SetEnvironmentVariable("ImgWebpCompressor", val, EnvironmentVariableTarget.User);
        }
        private string GetValueWebp()
        {
            return Environment.GetEnvironmentVariable("ImgWebpCompressor", EnvironmentVariableTarget.User);
        }
        private void SetValueJPEGTran(string val)
        {
            Environment.SetEnvironmentVariable("ImgJPEGTranCompressor", val, EnvironmentVariableTarget.User);
        }
        private string GetValueJPEGTran()
        {
            return Environment.GetEnvironmentVariable("ImgJPEGTranCompressor", EnvironmentVariableTarget.User);
        }
        private void btnDest_Click(object sender, EventArgs e)
        {
            if (fbDest.ShowDialog() == DialogResult.OK)
            {
                txtDest.Text = fbDest.SelectedPath;
            }
        }

        private void btnProgress_Click(object sender, EventArgs e)
        {
            if (rdWebp.Checked)
            {
                foreach (var item in ImageList)
                {
                    compressWebp(item);
                }
            }
            else
            {
                foreach (var item in ImageList)
                {
                    compressJPEG(item);
                }
            }
            openExplore(txtDest.Text);
            ImageList = new List<string>();
            SourceChanged();
        }
        private void openExplore(string dest)
        {
            var process = new ProcessStartInfo("cmd.exe");
            string command = String.Format(@"/c explorer {0}", dest);
            process.Arguments = command;
            process.ErrorDialog = true;
            process.UseShellExecute = false;
            process.RedirectStandardOutput = true;
            process.RedirectStandardError = true;
            process.CreateNoWindow = true;
            Process.Start(process);
        }
        private void compressJPEG(string source)
        {
            if (string.IsNullOrEmpty(GetValueJPEGTran()))
            {
                MessageBox.Show("Set JPEGTran Directory");
                return;
            }
            else
            {
                string tempFileName = "jpegtran.exe";
                FileInfo fi = new FileInfo(source);
                var dir = fi.Directory.FullName;
                var name = Path.GetFileNameWithoutExtension(fi.Name);
                string libpath = GetValueJPEGTran();
                var process = new ProcessStartInfo("cmd.exe");
                string command = String.Format(@"/c {0}\{1} -optimize -progressive {2} {3}\{4}.jpg", libpath, tempFileName, source, txtDest.Text, name);
                process.Arguments = command;
                process.ErrorDialog = true;
                process.UseShellExecute = false;
                process.RedirectStandardOutput = true;
                process.RedirectStandardError = true;
                process.CreateNoWindow = true;
                Process.Start(process);
            }
        }
        private void compressWebp(string source)
        {
            if (string.IsNullOrEmpty(GetValueWebp()))
            {
                MessageBox.Show("Set WebP Directory");
                return;
            }
            else
            {
                string tempFileName = "cwebp.exe";
                FileInfo fi = new FileInfo(source);
                var dir = fi.Directory.FullName;
                var name = Path.GetFileNameWithoutExtension(fi.Name);
                string libpath = GetValueWebp();
                var process = new ProcessStartInfo("cmd.exe");
                string command = String.Format(@"/c {0}\{1} {2} -q 80 -o {3}\{4}.webp", libpath,tempFileName,source, txtDest.Text,name);
                process.Arguments = command;
                process.ErrorDialog = true;
                process.UseShellExecute = false;
                process.RedirectStandardOutput = true;
                process.RedirectStandardError = true;
                process.CreateNoWindow = true;
                Process.Start(process);
            }
        }

        private void fbJPEGTranDir_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}
