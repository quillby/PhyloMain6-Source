namespace PhyloMain
{
    partial class OneClick
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
            this.label1 = new System.Windows.Forms.Label();
            this.picFileOpen = new System.Windows.Forms.PictureBox();
            this.txtFastaFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboAlign = new System.Windows.Forms.ComboBox();
            this.cboTree = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkViewTree = new System.Windows.Forms.CheckBox();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblParam = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFileOpen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(510, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "A Tree in One Go";
            // 
            // picFileOpen
            // 
            this.picFileOpen.BackColor = System.Drawing.Color.Transparent;
            this.picFileOpen.Image = global::PhyloMain.Properties.Resources.content_48;
            this.picFileOpen.Location = new System.Drawing.Point(942, 152);
            this.picFileOpen.Name = "picFileOpen";
            this.picFileOpen.Size = new System.Drawing.Size(24, 23);
            this.picFileOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFileOpen.TabIndex = 12;
            this.picFileOpen.TabStop = false;
            this.picFileOpen.Click += new System.EventHandler(this.PicFileOpen_Click);
            this.picFileOpen.MouseLeave += new System.EventHandler(this.PicFileOpen_MouseLeave);
            this.picFileOpen.MouseHover += new System.EventHandler(this.PicFileOpen_MouseHover);
            // 
            // txtFastaFile
            // 
            this.txtFastaFile.AllowDrop = true;
            this.txtFastaFile.Location = new System.Drawing.Point(467, 152);
            this.txtFastaFile.Name = "txtFastaFile";
            this.txtFastaFile.Size = new System.Drawing.Size(469, 23);
            this.txtFastaFile.TabIndex = 11;
            this.txtFastaFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.TxtFastaFile_DragDrop_1);
            this.txtFastaFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxtFastaFile_DragEnter_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(305, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Open Fasta file:";
            // 
            // cboAlign
            // 
            this.cboAlign.FormattingEnabled = true;
            this.cboAlign.Items.AddRange(new object[] {
            "Muscle",
            "MAFFT",
            "Clustal"});
            this.cboAlign.Location = new System.Drawing.Point(470, 252);
            this.cboAlign.Name = "cboAlign";
            this.cboAlign.Size = new System.Drawing.Size(121, 23);
            this.cboAlign.TabIndex = 22;
            this.cboAlign.SelectedIndexChanged += new System.EventHandler(this.CboAlign_SelectedIndexChanged);
            // 
            // cboTree
            // 
            this.cboTree.FormattingEnabled = true;
            this.cboTree.Items.AddRange(new object[] {
            "FastTree",
            "IQ-tree",
            "RaxML"});
            this.cboTree.Location = new System.Drawing.Point(638, 252);
            this.cboTree.Name = "cboTree";
            this.cboTree.Size = new System.Drawing.Size(121, 23);
            this.cboTree.TabIndex = 22;
            this.cboTree.SelectedIndexChanged += new System.EventHandler(this.CboTree_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(467, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Align with";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(635, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Build tree with";
            // 
            // chkViewTree
            // 
            this.chkViewTree.AutoSize = true;
            this.chkViewTree.Checked = true;
            this.chkViewTree.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkViewTree.Location = new System.Drawing.Point(798, 254);
            this.chkViewTree.Name = "chkViewTree";
            this.chkViewTree.Size = new System.Drawing.Size(89, 19);
            this.chkViewTree.TabIndex = 23;
            this.chkViewTree.Text = "View tree";
            this.chkViewTree.UseVisualStyleBackColor = true;
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnClearAll.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnClearAll.Location = new System.Drawing.Point(676, 716);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(136, 34);
            this.btnClearAll.TabIndex = 24;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.BtnClearAll_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnStart.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnStart.Location = new System.Drawing.Point(467, 716);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(172, 34);
            this.btnStart.TabIndex = 25;
            this.btnStart.Text = "Start procedure";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(230, 297);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 393);
            this.panel1.TabIndex = 26;
            // 
            // lblParam
            // 
            this.lblParam.AutoSize = true;
            this.lblParam.Location = new System.Drawing.Point(33, 818);
            this.lblParam.Name = "lblParam";
            this.lblParam.Size = new System.Drawing.Size(133, 15);
            this.lblParam.TabIndex = 27;
            this.lblParam.Text = "parameters visible";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.PaleGreen;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(390, 319);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(546, 87);
            this.richTextBox1.TabIndex = 28;
            this.richTextBox1.Text = "The alignment programs are using default parameters.\n\nThe tree building programs " +
    "don\'t use bootstrapping.\nThis program is used to create a simple tree in a relat" +
    "ively fast time.";
            // 
            // OneClick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1267, 876);
            this.Controls.Add(this.lblParam);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.chkViewTree);
            this.Controls.Add(this.cboTree);
            this.Controls.Add(this.cboAlign);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picFileOpen);
            this.Controls.Add(this.txtFastaFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OneClick";
            this.Text = "OneClick";
            this.Load += new System.EventHandler(this.OneClick_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFileOpen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picFileOpen;
        private System.Windows.Forms.TextBox txtFastaFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboAlign;
        private System.Windows.Forms.ComboBox cboTree;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkViewTree;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblParam;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}