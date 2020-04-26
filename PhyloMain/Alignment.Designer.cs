namespace PhyloMain
{
    partial class Alignment
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
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.rdbMuscle = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbClustalW = new System.Windows.Forms.RadioButton();
            this.rdbMAFFT = new System.Windows.Forms.RadioButton();
            this.grpMuscle = new System.Windows.Forms.GroupBox();
            this.chkDiag = new System.Windows.Forms.CheckBox();
            this.txtMuscleIterations = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpMAFFT = new System.Windows.Forms.GroupBox();
            this.cboRetree = new System.Windows.Forms.ComboBox();
            this.chkAdjust = new System.Windows.Forms.CheckBox();
            this.rdbGINS = new System.Windows.Forms.RadioButton();
            this.rdbLINS = new System.Windows.Forms.RadioButton();
            this.rdbEINS = new System.Windows.Forms.RadioButton();
            this.rdbFFTi = new System.Windows.Forms.RadioButton();
            this.rdbFFT1 = new System.Windows.Forms.RadioButton();
            this.grpClustalW = new System.Windows.Forms.GroupBox();
            this.rdbAligned = new System.Windows.Forms.RadioButton();
            this.rdbInput = new System.Windows.Forms.RadioButton();
            this.chkNJtree = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBootstrap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFastaFile = new System.Windows.Forms.TextBox();
            this.txtAlignment = new System.Windows.Forms.TextBox();
            this.btnAlign = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.lblParam = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkGblocks = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtB3 = new System.Windows.Forms.TextBox();
            this.txtB4 = new System.Windows.Forms.TextBox();
            this.cboGaps = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.picFileSave = new System.Windows.Forms.PictureBox();
            this.picFileOpen = new System.Windows.Forms.PictureBox();
            this.chkCommand = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnStartBioEdit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpMuscle.SuspendLayout();
            this.grpMAFFT.SuspendLayout();
            this.grpClustalW.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFileSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFileOpen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(396, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sequence Alignment";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // rdbMuscle
            // 
            this.rdbMuscle.AutoSize = true;
            this.rdbMuscle.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMuscle.Location = new System.Drawing.Point(9, 28);
            this.rdbMuscle.Name = "rdbMuscle";
            this.rdbMuscle.Size = new System.Drawing.Size(81, 23);
            this.rdbMuscle.TabIndex = 0;
            this.rdbMuscle.Text = "Muscle";
            this.rdbMuscle.UseVisualStyleBackColor = true;
            this.rdbMuscle.CheckedChanged += new System.EventHandler(this.RdbMuscle_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.rdbClustalW);
            this.groupBox1.Controls.Add(this.rdbMAFFT);
            this.groupBox1.Controls.Add(this.rdbMuscle);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(216, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 62);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alignment method";
            // 
            // rdbClustalW
            // 
            this.rdbClustalW.AutoSize = true;
            this.rdbClustalW.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbClustalW.Location = new System.Drawing.Point(488, 28);
            this.rdbClustalW.Name = "rdbClustalW";
            this.rdbClustalW.Size = new System.Drawing.Size(99, 23);
            this.rdbClustalW.TabIndex = 2;
            this.rdbClustalW.Text = "ClustalW";
            this.rdbClustalW.UseVisualStyleBackColor = true;
            this.rdbClustalW.CheckedChanged += new System.EventHandler(this.RdbClustalW_CheckedChanged);
            // 
            // rdbMAFFT
            // 
            this.rdbMAFFT.AutoSize = true;
            this.rdbMAFFT.Checked = true;
            this.rdbMAFFT.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMAFFT.Location = new System.Drawing.Point(265, 28);
            this.rdbMAFFT.Name = "rdbMAFFT";
            this.rdbMAFFT.Size = new System.Drawing.Size(72, 23);
            this.rdbMAFFT.TabIndex = 1;
            this.rdbMAFFT.TabStop = true;
            this.rdbMAFFT.Text = "MAFFT";
            this.rdbMAFFT.UseVisualStyleBackColor = true;
            this.rdbMAFFT.CheckedChanged += new System.EventHandler(this.RdbMAFFT_CheckedChanged);
            // 
            // grpMuscle
            // 
            this.grpMuscle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.grpMuscle.Controls.Add(this.chkDiag);
            this.grpMuscle.Controls.Add(this.txtMuscleIterations);
            this.grpMuscle.Controls.Add(this.label2);
            this.grpMuscle.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMuscle.Location = new System.Drawing.Point(216, 233);
            this.grpMuscle.Name = "grpMuscle";
            this.grpMuscle.Size = new System.Drawing.Size(170, 107);
            this.grpMuscle.TabIndex = 4;
            this.grpMuscle.TabStop = false;
            this.grpMuscle.Text = "Muscle parameters";
            this.grpMuscle.Visible = false;
            // 
            // chkDiag
            // 
            this.chkDiag.AutoSize = true;
            this.chkDiag.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDiag.Location = new System.Drawing.Point(15, 68);
            this.chkDiag.Name = "chkDiag";
            this.chkDiag.Size = new System.Drawing.Size(68, 19);
            this.chkDiag.TabIndex = 2;
            this.chkDiag.Text = "-diags";
            this.chkDiag.UseVisualStyleBackColor = true;
            // 
            // txtMuscleIterations
            // 
            this.txtMuscleIterations.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMuscleIterations.Location = new System.Drawing.Point(109, 30);
            this.txtMuscleIterations.Name = "txtMuscleIterations";
            this.txtMuscleIterations.Size = new System.Drawing.Size(32, 23);
            this.txtMuscleIterations.TabIndex = 1;
            this.txtMuscleIterations.Text = "8";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Iterations: ";
            // 
            // grpMAFFT
            // 
            this.grpMAFFT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.grpMAFFT.Controls.Add(this.cboRetree);
            this.grpMAFFT.Controls.Add(this.chkAdjust);
            this.grpMAFFT.Controls.Add(this.rdbGINS);
            this.grpMAFFT.Controls.Add(this.rdbLINS);
            this.grpMAFFT.Controls.Add(this.rdbEINS);
            this.grpMAFFT.Controls.Add(this.rdbFFTi);
            this.grpMAFFT.Controls.Add(this.rdbFFT1);
            this.grpMAFFT.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMAFFT.Location = new System.Drawing.Point(418, 233);
            this.grpMAFFT.Name = "grpMAFFT";
            this.grpMAFFT.Size = new System.Drawing.Size(238, 178);
            this.grpMAFFT.TabIndex = 5;
            this.grpMAFFT.TabStop = false;
            this.grpMAFFT.Text = "MAFFT parameters";
            this.grpMAFFT.Visible = false;
            // 
            // cboRetree
            // 
            this.cboRetree.Enabled = false;
            this.cboRetree.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRetree.FormattingEnabled = true;
            this.cboRetree.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cboRetree.Location = new System.Drawing.Point(168, 22);
            this.cboRetree.Name = "cboRetree";
            this.cboRetree.Size = new System.Drawing.Size(37, 23);
            this.cboRetree.TabIndex = 2;
            // 
            // chkAdjust
            // 
            this.chkAdjust.AutoSize = true;
            this.chkAdjust.Checked = true;
            this.chkAdjust.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAdjust.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAdjust.Location = new System.Drawing.Point(7, 148);
            this.chkAdjust.Name = "chkAdjust";
            this.chkAdjust.Size = new System.Drawing.Size(138, 19);
            this.chkAdjust.TabIndex = 1;
            this.chkAdjust.Text = "adjust direction";
            this.chkAdjust.UseVisualStyleBackColor = true;
            // 
            // rdbGINS
            // 
            this.rdbGINS.AutoSize = true;
            this.rdbGINS.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbGINS.Location = new System.Drawing.Point(7, 123);
            this.rdbGINS.Name = "rdbGINS";
            this.rdbGINS.Size = new System.Drawing.Size(186, 19);
            this.rdbGINS.TabIndex = 0;
            this.rdbGINS.Text = "G-INS-i (entire region)";
            this.rdbGINS.UseVisualStyleBackColor = true;
            // 
            // rdbLINS
            // 
            this.rdbLINS.AutoSize = true;
            this.rdbLINS.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbLINS.Location = new System.Drawing.Point(7, 98);
            this.rdbLINS.Name = "rdbLINS";
            this.rdbLINS.Size = new System.Drawing.Size(207, 19);
            this.rdbLINS.TabIndex = 0;
            this.rdbLINS.Text = "L-INS-i (flanking regions)";
            this.rdbLINS.UseVisualStyleBackColor = true;
            // 
            // rdbEINS
            // 
            this.rdbEINS.AutoSize = true;
            this.rdbEINS.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEINS.Location = new System.Drawing.Point(7, 73);
            this.rdbEINS.Name = "rdbEINS";
            this.rdbEINS.Size = new System.Drawing.Size(228, 19);
            this.rdbEINS.TabIndex = 0;
            this.rdbEINS.Text = "E-INS-i (unalignable regions)";
            this.rdbEINS.UseVisualStyleBackColor = true;
            // 
            // rdbFFTi
            // 
            this.rdbFFTi.AutoSize = true;
            this.rdbFFTi.Checked = true;
            this.rdbFFTi.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFFTi.Location = new System.Drawing.Point(7, 48);
            this.rdbFFTi.Name = "rdbFFTi";
            this.rdbFFTi.Size = new System.Drawing.Size(81, 19);
            this.rdbFFTi.TabIndex = 0;
            this.rdbFFTi.TabStop = true;
            this.rdbFFTi.Text = "FFT-NS-i";
            this.rdbFFTi.UseVisualStyleBackColor = true;
            // 
            // rdbFFT1
            // 
            this.rdbFFT1.AutoSize = true;
            this.rdbFFT1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFFT1.Location = new System.Drawing.Point(7, 23);
            this.rdbFFT1.Name = "rdbFFT1";
            this.rdbFFT1.Size = new System.Drawing.Size(81, 19);
            this.rdbFFT1.TabIndex = 0;
            this.rdbFFT1.Text = "FFT-NS-x";
            this.rdbFFT1.UseVisualStyleBackColor = true;
            this.rdbFFT1.CheckedChanged += new System.EventHandler(this.RdbFFT1_CheckedChanged);
            // 
            // grpClustalW
            // 
            this.grpClustalW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.grpClustalW.Controls.Add(this.rdbAligned);
            this.grpClustalW.Controls.Add(this.rdbInput);
            this.grpClustalW.Controls.Add(this.chkNJtree);
            this.grpClustalW.Controls.Add(this.label7);
            this.grpClustalW.Controls.Add(this.label6);
            this.grpClustalW.Controls.Add(this.label5);
            this.grpClustalW.Controls.Add(this.txtBootstrap);
            this.grpClustalW.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpClustalW.Location = new System.Drawing.Point(687, 233);
            this.grpClustalW.Name = "grpClustalW";
            this.grpClustalW.Size = new System.Drawing.Size(175, 125);
            this.grpClustalW.TabIndex = 6;
            this.grpClustalW.TabStop = false;
            this.grpClustalW.Text = "ClustalW parameters";
            this.grpClustalW.Visible = false;
            // 
            // rdbAligned
            // 
            this.rdbAligned.AutoSize = true;
            this.rdbAligned.Checked = true;
            this.rdbAligned.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAligned.Location = new System.Drawing.Point(96, 81);
            this.rdbAligned.Name = "rdbAligned";
            this.rdbAligned.Size = new System.Drawing.Size(74, 19);
            this.rdbAligned.TabIndex = 15;
            this.rdbAligned.TabStop = true;
            this.rdbAligned.Text = "ALIGNED";
            this.rdbAligned.UseVisualStyleBackColor = true;
            // 
            // rdbInput
            // 
            this.rdbInput.AutoSize = true;
            this.rdbInput.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbInput.Location = new System.Drawing.Point(96, 100);
            this.rdbInput.Name = "rdbInput";
            this.rdbInput.Size = new System.Drawing.Size(60, 19);
            this.rdbInput.TabIndex = 15;
            this.rdbInput.Text = "INPUT";
            this.rdbInput.UseVisualStyleBackColor = true;
            // 
            // chkNJtree
            // 
            this.chkNJtree.AutoSize = true;
            this.chkNJtree.Location = new System.Drawing.Point(96, 59);
            this.chkNJtree.Name = "chkNJtree";
            this.chkNJtree.Size = new System.Drawing.Size(15, 14);
            this.chkNJtree.TabIndex = 14;
            this.chkNJtree.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Output";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "NJ tree";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Bootstrap: ";
            // 
            // txtBootstrap
            // 
            this.txtBootstrap.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBootstrap.Location = new System.Drawing.Point(96, 30);
            this.txtBootstrap.Name = "txtBootstrap";
            this.txtBootstrap.Size = new System.Drawing.Size(47, 23);
            this.txtBootstrap.TabIndex = 1;
            this.txtBootstrap.Text = "1000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(231, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Open Fasta file:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(231, 477);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Save Alignment As:";
            // 
            // txtFastaFile
            // 
            this.txtFastaFile.AllowDrop = true;
            this.txtFastaFile.Location = new System.Drawing.Point(393, 432);
            this.txtFastaFile.Name = "txtFastaFile";
            this.txtFastaFile.Size = new System.Drawing.Size(469, 23);
            this.txtFastaFile.TabIndex = 8;
            this.txtFastaFile.TextChanged += new System.EventHandler(this.TxtFastaFile_TextChanged);
            this.txtFastaFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.TxtFastaFile_DragDrop);
            this.txtFastaFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxtFastaFile_DragEnter);
            // 
            // txtAlignment
            // 
            this.txtAlignment.Location = new System.Drawing.Point(393, 474);
            this.txtAlignment.Name = "txtAlignment";
            this.txtAlignment.Size = new System.Drawing.Size(469, 23);
            this.txtAlignment.TabIndex = 8;
            this.txtAlignment.TextChanged += new System.EventHandler(this.TxtAlignment_TextChanged);
            this.txtAlignment.DoubleClick += new System.EventHandler(this.TxtAlignment_DoubleClick);
            // 
            // btnAlign
            // 
            this.btnAlign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAlign.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAlign.Location = new System.Drawing.Point(447, 630);
            this.btnAlign.Name = "btnAlign";
            this.btnAlign.Size = new System.Drawing.Size(172, 34);
            this.btnAlign.TabIndex = 0;
            this.btnAlign.Text = "Start alignment";
            this.btnAlign.UseVisualStyleBackColor = false;
            this.btnAlign.Click += new System.EventHandler(this.BtnAlign_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnClearAll.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnClearAll.Location = new System.Drawing.Point(687, 630);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(136, 34);
            this.btnClearAll.TabIndex = 1;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.BtnClearAll_Click);
            // 
            // lblParam
            // 
            this.lblParam.AutoSize = true;
            this.lblParam.Location = new System.Drawing.Point(20, 679);
            this.lblParam.Name = "lblParam";
            this.lblParam.Size = new System.Drawing.Size(133, 15);
            this.lblParam.TabIndex = 12;
            this.lblParam.Text = "parameters visible";
            // 
            // panel1
            // 
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(216, 211);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 296);
            this.panel1.TabIndex = 14;
            this.panel1.Visible = false;
            // 
            // chkGblocks
            // 
            this.chkGblocks.AutoSize = true;
            this.chkGblocks.Enabled = false;
            this.chkGblocks.Location = new System.Drawing.Point(393, 513);
            this.chkGblocks.Name = "chkGblocks";
            this.chkGblocks.Size = new System.Drawing.Size(215, 19);
            this.chkGblocks.TabIndex = 15;
            this.chkGblocks.Text = "Use GBlocks on aligned file";
            this.toolTip1.SetToolTip(this.chkGblocks, "The \'>\' line can\'t be >50 characters");
            this.chkGblocks.UseVisualStyleBackColor = true;
            this.chkGblocks.CheckedChanged += new System.EventHandler(this.ChkGblocks_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(393, 539);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(371, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Maximum Number Of Contiguous Nonconserved Positions:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(396, 568);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Minimum Length Of A Block:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(399, 596);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Allowed Gap Positions:";
            // 
            // txtB3
            // 
            this.txtB3.Enabled = false;
            this.txtB3.Location = new System.Drawing.Point(765, 536);
            this.txtB3.Name = "txtB3";
            this.txtB3.Size = new System.Drawing.Size(33, 23);
            this.txtB3.TabIndex = 19;
            this.txtB3.Text = "8";
            this.toolTip1.SetToolTip(this.txtB3, "Bigger values of this parameter INCREASE the selected number of positions");
            // 
            // txtB4
            // 
            this.txtB4.Enabled = false;
            this.txtB4.Location = new System.Drawing.Point(586, 565);
            this.txtB4.Name = "txtB4";
            this.txtB4.Size = new System.Drawing.Size(33, 23);
            this.txtB4.TabIndex = 20;
            this.txtB4.Text = "10";
            this.toolTip1.SetToolTip(this.txtB4, "Bigger values of this parameter DECREASE the selected number of positions");
            this.txtB4.TextChanged += new System.EventHandler(this.TxtB4_TextChanged);
            // 
            // cboGaps
            // 
            this.cboGaps.Enabled = false;
            this.cboGaps.FormattingEnabled = true;
            this.cboGaps.Items.AddRange(new object[] {
            "None",
            "With Half",
            "All"});
            this.cboGaps.Location = new System.Drawing.Point(586, 593);
            this.cboGaps.Name = "cboGaps";
            this.cboGaps.Size = new System.Drawing.Size(87, 23);
            this.cboGaps.TabIndex = 21;
            this.cboGaps.Text = "None";
            // 
            // picFileSave
            // 
            this.picFileSave.BackColor = System.Drawing.Color.Transparent;
            this.picFileSave.Image = global::PhyloMain.Properties.Resources.content_48;
            this.picFileSave.Location = new System.Drawing.Point(868, 474);
            this.picFileSave.Name = "picFileSave";
            this.picFileSave.Size = new System.Drawing.Size(24, 23);
            this.picFileSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFileSave.TabIndex = 9;
            this.picFileSave.TabStop = false;
            this.picFileSave.Click += new System.EventHandler(this.PicFileSave_Click);
            this.picFileSave.MouseLeave += new System.EventHandler(this.PicFileSave_MouseLeave);
            this.picFileSave.MouseHover += new System.EventHandler(this.PicFileSave_MouseHover);
            // 
            // picFileOpen
            // 
            this.picFileOpen.BackColor = System.Drawing.Color.Transparent;
            this.picFileOpen.Image = global::PhyloMain.Properties.Resources.content_48;
            this.picFileOpen.Location = new System.Drawing.Point(868, 432);
            this.picFileOpen.Name = "picFileOpen";
            this.picFileOpen.Size = new System.Drawing.Size(24, 23);
            this.picFileOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFileOpen.TabIndex = 9;
            this.picFileOpen.TabStop = false;
            this.picFileOpen.Click += new System.EventHandler(this.PicFileOpen_Click);
            this.picFileOpen.MouseLeave += new System.EventHandler(this.PicFileOpen_MouseLeave);
            this.picFileOpen.MouseHover += new System.EventHandler(this.PicFileOpen_MouseHover);
            // 
            // chkCommand
            // 
            this.chkCommand.AutoSize = true;
            this.chkCommand.Checked = true;
            this.chkCommand.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCommand.Location = new System.Drawing.Point(447, 670);
            this.chkCommand.Name = "chkCommand";
            this.chkCommand.Size = new System.Drawing.Size(152, 19);
            this.chkCommand.TabIndex = 22;
            this.chkCommand.Text = "Show output window";
            this.chkCommand.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(455, 712);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 19);
            this.label11.TabIndex = 23;
            this.label11.Text = "Running.....";
            this.label11.Visible = false;
            // 
            // btnStartBioEdit
            // 
            this.btnStartBioEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnStartBioEdit.Enabled = false;
            this.btnStartBioEdit.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartBioEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnStartBioEdit.Location = new System.Drawing.Point(203, 630);
            this.btnStartBioEdit.Name = "btnStartBioEdit";
            this.btnStartBioEdit.Size = new System.Drawing.Size(172, 34);
            this.btnStartBioEdit.TabIndex = 24;
            this.btnStartBioEdit.Text = "Open alignment";
            this.btnStartBioEdit.UseVisualStyleBackColor = false;
            this.btnStartBioEdit.Click += new System.EventHandler(this.btnStartBioEdit_Click);
            // 
            // Alignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1134, 755);
            this.Controls.Add(this.btnStartBioEdit);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.chkCommand);
            this.Controls.Add(this.cboGaps);
            this.Controls.Add(this.txtB4);
            this.Controls.Add(this.txtB3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chkGblocks);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblParam);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnAlign);
            this.Controls.Add(this.picFileSave);
            this.Controls.Add(this.picFileOpen);
            this.Controls.Add(this.txtAlignment);
            this.Controls.Add(this.txtFastaFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grpClustalW);
            this.Controls.Add(this.grpMAFFT);
            this.Controls.Add(this.grpMuscle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alignment";
            this.Text = "Alignment";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpMuscle.ResumeLayout(false);
            this.grpMuscle.PerformLayout();
            this.grpMAFFT.ResumeLayout(false);
            this.grpMAFFT.PerformLayout();
            this.grpClustalW.ResumeLayout(false);
            this.grpClustalW.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFileSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFileOpen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RadioButton rdbMuscle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbClustalW;
        private System.Windows.Forms.RadioButton rdbMAFFT;
        private System.Windows.Forms.GroupBox grpMuscle;
        private System.Windows.Forms.CheckBox chkDiag;
        private System.Windows.Forms.TextBox txtMuscleIterations;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpMAFFT;
        private System.Windows.Forms.GroupBox grpClustalW;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFastaFile;
        private System.Windows.Forms.TextBox txtAlignment;
        private System.Windows.Forms.PictureBox picFileOpen;
        private System.Windows.Forms.PictureBox picFileSave;
        private System.Windows.Forms.Button btnAlign;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label lblParam;
        private System.Windows.Forms.RadioButton rdbAligned;
        private System.Windows.Forms.RadioButton rdbInput;
        private System.Windows.Forms.CheckBox chkNJtree;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBootstrap;
        private System.Windows.Forms.ComboBox cboRetree;
        private System.Windows.Forms.CheckBox chkAdjust;
        private System.Windows.Forms.RadioButton rdbGINS;
        private System.Windows.Forms.RadioButton rdbLINS;
        private System.Windows.Forms.RadioButton rdbEINS;
        private System.Windows.Forms.RadioButton rdbFFTi;
        private System.Windows.Forms.RadioButton rdbFFT1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkGblocks;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtB3;
        private System.Windows.Forms.TextBox txtB4;
        private System.Windows.Forms.ComboBox cboGaps;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox chkCommand;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnStartBioEdit;
    }
}