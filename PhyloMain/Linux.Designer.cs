namespace PhyloMain
{
    partial class Linux
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Linux));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picFolderOpen = new System.Windows.Forms.PictureBox();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResultsDirectory = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.txtGenomeSize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbPacbioRaw = new System.Windows.Forms.RadioButton();
            this.rdbPacbioCorrected = new System.Windows.Forms.RadioButton();
            this.rdbNanoporeRaw = new System.Windows.Forms.RadioButton();
            this.rdbNanoporeCorrected = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtCMD = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFolderOpen)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(454, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Run Linux in Windows environment";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(406, 109);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(490, 212);
            this.textBox1.TabIndex = 4;
            this.textBox1.TabStop = false;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "Select folder where fastq files are located:";
            // 
            // picFolderOpen
            // 
            this.picFolderOpen.BackColor = System.Drawing.Color.Transparent;
            this.picFolderOpen.Image = global::PhyloMain.Properties.Resources.content_48;
            this.picFolderOpen.Location = new System.Drawing.Point(933, 387);
            this.picFolderOpen.Name = "picFolderOpen";
            this.picFolderOpen.Size = new System.Drawing.Size(24, 23);
            this.picFolderOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFolderOpen.TabIndex = 33;
            this.picFolderOpen.TabStop = false;
            this.picFolderOpen.Click += new System.EventHandler(this.picFolderOpen_Click);
            // 
            // txtDirectory
            // 
            this.txtDirectory.AllowDrop = true;
            this.txtDirectory.Location = new System.Drawing.Point(262, 387);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(665, 23);
            this.txtDirectory.TabIndex = 32;
            this.txtDirectory.TextChanged += new System.EventHandler(this.txtDirectory_TextChanged);
            this.txtDirectory.DoubleClick += new System.EventHandler(this.txtDirectory_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "Create a directory to store results:";
            // 
            // txtResultsDirectory
            // 
            this.txtResultsDirectory.Location = new System.Drawing.Point(577, 451);
            this.txtResultsDirectory.Name = "txtResultsDirectory";
            this.txtResultsDirectory.Size = new System.Drawing.Size(121, 23);
            this.txtResultsDirectory.TabIndex = 34;
            this.txtResultsDirectory.Text = "run1";
            this.toolTip1.SetToolTip(this.txtResultsDirectory, "Short name for results directory. Don\'t use spaces or special characters.");
            this.txtResultsDirectory.TextChanged += new System.EventHandler(this.txtResultsDirectory_TextChanged);
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(577, 486);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(121, 23);
            this.txtPrefix.TabIndex = 34;
            this.txtPrefix.Text = "gspecies";
            this.toolTip1.SetToolTip(this.txtPrefix, "This could be a short name of the species or number, like cauris or cbs10845. Don" +
        "\'t use spaces or special characters.");
            this.txtPrefix.TextChanged += new System.EventHandler(this.txtPrefix_TextChanged);
            // 
            // txtGenomeSize
            // 
            this.txtGenomeSize.Location = new System.Drawing.Point(577, 521);
            this.txtGenomeSize.Name = "txtGenomeSize";
            this.txtGenomeSize.Size = new System.Drawing.Size(121, 23);
            this.txtGenomeSize.TabIndex = 34;
            this.txtGenomeSize.Text = "13m";
            this.toolTip1.SetToolTip(this.txtGenomeSize, "Provide a number and add g, m or k for giga, mega or kilobase. Don\'t use spaces.");
            this.txtGenomeSize.TextChanged += new System.EventHandler(this.txtGenomeSize_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(259, 487);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "Create a prefix to name the results:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(259, 522);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(312, 18);
            this.label5.TabIndex = 30;
            this.label5.Text = "Estimation of the genome size (g,m,k):";
            // 
            // rdbPacbioRaw
            // 
            this.rdbPacbioRaw.AutoSize = true;
            this.rdbPacbioRaw.Location = new System.Drawing.Point(733, 451);
            this.rdbPacbioRaw.Name = "rdbPacbioRaw";
            this.rdbPacbioRaw.Size = new System.Drawing.Size(95, 19);
            this.rdbPacbioRaw.TabIndex = 35;
            this.rdbPacbioRaw.Text = "pacbio-raw";
            this.rdbPacbioRaw.UseVisualStyleBackColor = true;
            this.rdbPacbioRaw.CheckedChanged += new System.EventHandler(this.rdbPacbioRaw_CheckedChanged);
            // 
            // rdbPacbioCorrected
            // 
            this.rdbPacbioCorrected.AutoSize = true;
            this.rdbPacbioCorrected.Location = new System.Drawing.Point(733, 476);
            this.rdbPacbioCorrected.Name = "rdbPacbioCorrected";
            this.rdbPacbioCorrected.Size = new System.Drawing.Size(137, 19);
            this.rdbPacbioCorrected.TabIndex = 35;
            this.rdbPacbioCorrected.Text = "pacbio-corrected";
            this.rdbPacbioCorrected.UseVisualStyleBackColor = true;
            this.rdbPacbioCorrected.CheckedChanged += new System.EventHandler(this.rdbPacbioCorrected_CheckedChanged);
            // 
            // rdbNanoporeRaw
            // 
            this.rdbNanoporeRaw.AutoSize = true;
            this.rdbNanoporeRaw.Checked = true;
            this.rdbNanoporeRaw.Location = new System.Drawing.Point(733, 501);
            this.rdbNanoporeRaw.Name = "rdbNanoporeRaw";
            this.rdbNanoporeRaw.Size = new System.Drawing.Size(109, 19);
            this.rdbNanoporeRaw.TabIndex = 35;
            this.rdbNanoporeRaw.TabStop = true;
            this.rdbNanoporeRaw.Text = "nanopore-raw";
            this.rdbNanoporeRaw.UseVisualStyleBackColor = true;
            this.rdbNanoporeRaw.CheckedChanged += new System.EventHandler(this.rdbNanoporeRaw_CheckedChanged);
            // 
            // rdbNanoporeCorrected
            // 
            this.rdbNanoporeCorrected.AutoSize = true;
            this.rdbNanoporeCorrected.Location = new System.Drawing.Point(733, 526);
            this.rdbNanoporeCorrected.Name = "rdbNanoporeCorrected";
            this.rdbNanoporeCorrected.Size = new System.Drawing.Size(151, 19);
            this.rdbNanoporeCorrected.TabIndex = 35;
            this.rdbNanoporeCorrected.Text = "nanopore-corrected";
            this.rdbNanoporeCorrected.UseVisualStyleBackColor = true;
            this.rdbNanoporeCorrected.CheckedChanged += new System.EventHandler(this.rdbNanoporeCorrected_CheckedChanged);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnStart.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnStart.Location = new System.Drawing.Point(447, 570);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(172, 34);
            this.btnStart.TabIndex = 37;
            this.btnStart.Text = "Create cmd line";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnReset.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnReset.Location = new System.Drawing.Point(659, 570);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(172, 34);
            this.btnReset.TabIndex = 37;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtCMD
            // 
            this.txtCMD.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMD.ForeColor = System.Drawing.Color.Firebrick;
            this.txtCMD.Location = new System.Drawing.Point(262, 641);
            this.txtCMD.Multiline = true;
            this.txtCMD.Name = "txtCMD";
            this.txtCMD.Size = new System.Drawing.Size(820, 167);
            this.txtCMD.TabIndex = 38;
            this.txtCMD.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(890, 431);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 124);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(18, 25);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(61, 19);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "-trim";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(18, 49);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(82, 19);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "-correct";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(18, 71);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(89, 19);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "-assemble";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(18, 96);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(124, 19);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.Text = "-trim-assemble";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // Linux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1251, 837);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCMD);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.rdbNanoporeCorrected);
            this.Controls.Add(this.rdbNanoporeRaw);
            this.Controls.Add(this.rdbPacbioCorrected);
            this.Controls.Add(this.rdbPacbioRaw);
            this.Controls.Add(this.txtGenomeSize);
            this.Controls.Add(this.txtPrefix);
            this.Controls.Add(this.txtResultsDirectory);
            this.Controls.Add(this.picFolderOpen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDirectory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Linux";
            this.Text = "Linux";
            this.Load += new System.EventHandler(this.Linux_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFolderOpen)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picFolderOpen;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResultsDirectory;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGenomeSize;
        private System.Windows.Forms.RadioButton rdbPacbioRaw;
        private System.Windows.Forms.RadioButton rdbPacbioCorrected;
        private System.Windows.Forms.RadioButton rdbNanoporeRaw;
        private System.Windows.Forms.RadioButton rdbNanoporeCorrected;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtCMD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}