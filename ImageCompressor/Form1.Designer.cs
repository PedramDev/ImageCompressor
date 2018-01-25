namespace ImageCompressor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ofd_source = new System.Windows.Forms.OpenFileDialog();
            this.btnSource = new System.Windows.Forms.Button();
            this.txtSources = new System.Windows.Forms.TextBox();
            this.btnDest = new System.Windows.Forms.Button();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.fbDest = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSetWebPDir = new System.Windows.Forms.Button();
            this.fbWebPDir = new System.Windows.Forms.FolderBrowserDialog();
            this.btnProgress = new System.Windows.Forms.Button();
            this.rdJPEG = new System.Windows.Forms.RadioButton();
            this.rdWebp = new System.Windows.Forms.RadioButton();
            this.btnSetJPEGTran = new System.Windows.Forms.Button();
            this.fbJPEGTranDir = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // ofd_source
            // 
            this.ofd_source.Multiselect = true;
            this.ofd_source.RestoreDirectory = true;
            this.ofd_source.Title = "Select Images";
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(385, 12);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(75, 23);
            this.btnSource.TabIndex = 0;
            this.btnSource.Text = "Source";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // txtSources
            // 
            this.txtSources.Location = new System.Drawing.Point(13, 14);
            this.txtSources.Multiline = true;
            this.txtSources.Name = "txtSources";
            this.txtSources.ReadOnly = true;
            this.txtSources.Size = new System.Drawing.Size(162, 252);
            this.txtSources.TabIndex = 1;
            // 
            // btnDest
            // 
            this.btnDest.Location = new System.Drawing.Point(385, 41);
            this.btnDest.Name = "btnDest";
            this.btnDest.Size = new System.Drawing.Size(75, 23);
            this.btnDest.TabIndex = 0;
            this.btnDest.Text = "Dest";
            this.btnDest.UseVisualStyleBackColor = true;
            this.btnDest.Click += new System.EventHandler(this.btnDest_Click);
            // 
            // txtDest
            // 
            this.txtDest.Location = new System.Drawing.Point(181, 70);
            this.txtDest.Multiline = true;
            this.txtDest.Name = "txtDest";
            this.txtDest.ReadOnly = true;
            this.txtDest.Size = new System.Drawing.Size(279, 38);
            this.txtDest.TabIndex = 2;
            // 
            // btnSetWebPDir
            // 
            this.btnSetWebPDir.Location = new System.Drawing.Point(369, 243);
            this.btnSetWebPDir.Name = "btnSetWebPDir";
            this.btnSetWebPDir.Size = new System.Drawing.Size(91, 23);
            this.btnSetWebPDir.TabIndex = 3;
            this.btnSetWebPDir.Text = "Set WebP Dir";
            this.btnSetWebPDir.UseVisualStyleBackColor = true;
            this.btnSetWebPDir.Click += new System.EventHandler(this.btnSetWebPDir_Click);
            // 
            // btnProgress
            // 
            this.btnProgress.Location = new System.Drawing.Point(181, 114);
            this.btnProgress.Name = "btnProgress";
            this.btnProgress.Size = new System.Drawing.Size(75, 23);
            this.btnProgress.TabIndex = 4;
            this.btnProgress.Text = "Progress";
            this.btnProgress.UseVisualStyleBackColor = true;
            this.btnProgress.Click += new System.EventHandler(this.btnProgress_Click);
            // 
            // rdJPEG
            // 
            this.rdJPEG.AutoSize = true;
            this.rdJPEG.Checked = true;
            this.rdJPEG.Location = new System.Drawing.Point(181, 15);
            this.rdJPEG.Name = "rdJPEG";
            this.rdJPEG.Size = new System.Drawing.Size(52, 17);
            this.rdJPEG.TabIndex = 5;
            this.rdJPEG.TabStop = true;
            this.rdJPEG.Text = "JPEG";
            this.rdJPEG.UseVisualStyleBackColor = true;
            // 
            // rdWebp
            // 
            this.rdWebp.AutoSize = true;
            this.rdWebp.Location = new System.Drawing.Point(182, 39);
            this.rdWebp.Name = "rdWebp";
            this.rdWebp.Size = new System.Drawing.Size(54, 17);
            this.rdWebp.TabIndex = 6;
            this.rdWebp.Text = "Webp";
            this.rdWebp.UseVisualStyleBackColor = true;
            // 
            // btnSetJPEGTran
            // 
            this.btnSetJPEGTran.Location = new System.Drawing.Point(256, 243);
            this.btnSetJPEGTran.Name = "btnSetJPEGTran";
            this.btnSetJPEGTran.Size = new System.Drawing.Size(107, 23);
            this.btnSetJPEGTran.TabIndex = 3;
            this.btnSetJPEGTran.Text = "Set JPEGTran Dir";
            this.btnSetJPEGTran.UseVisualStyleBackColor = true;
            this.btnSetJPEGTran.Click += new System.EventHandler(this.btnSetJPEGTranDir_Click);
            // 
            // fbJPEGTranDir
            // 
            this.fbJPEGTranDir.HelpRequest += new System.EventHandler(this.fbJPEGTranDir_HelpRequest);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 278);
            this.Controls.Add(this.rdWebp);
            this.Controls.Add(this.rdJPEG);
            this.Controls.Add(this.btnProgress);
            this.Controls.Add(this.btnSetJPEGTran);
            this.Controls.Add(this.btnSetWebPDir);
            this.Controls.Add(this.txtDest);
            this.Controls.Add(this.txtSources);
            this.Controls.Add(this.btnDest);
            this.Controls.Add(this.btnSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Web Compression";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofd_source;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.TextBox txtSources;
        private System.Windows.Forms.Button btnDest;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.FolderBrowserDialog fbDest;
        private System.Windows.Forms.Button btnSetWebPDir;
        private System.Windows.Forms.FolderBrowserDialog fbWebPDir;
        private System.Windows.Forms.Button btnProgress;
        private System.Windows.Forms.RadioButton rdJPEG;
        private System.Windows.Forms.RadioButton rdWebp;
        private System.Windows.Forms.Button btnSetJPEGTran;
        private System.Windows.Forms.FolderBrowserDialog fbJPEGTranDir;
    }
}

