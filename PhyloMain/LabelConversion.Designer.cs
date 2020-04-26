namespace PhyloMain
{
    partial class LabelConversion
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtFastaFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picFastaOpen = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOpenTree = new System.Windows.Forms.TextBox();
            this.picTreeOpen = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtExcel = new System.Windows.Forms.TextBox();
            this.picExcelOpen = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConvertedFile = new System.Windows.Forms.TextBox();
            this.picSaveConversion = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboProps = new System.Windows.Forms.ComboBox();
            this.chkConvTree = new System.Windows.Forms.CheckBox();
            this.chkConvFasta = new System.Windows.Forms.CheckBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblProps = new System.Windows.Forms.Label();
            this.picReset = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPiping = new System.Windows.Forms.TextBox();
            this.txtFinished = new System.Windows.Forms.TextBox();
            this.txtWarning = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFastaOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTreeOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExcelOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSaveConversion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReset)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(414, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Change tip info in alignment or tree file";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtFastaFile
            // 
            this.txtFastaFile.AllowDrop = true;
            this.txtFastaFile.Location = new System.Drawing.Point(447, 155);
            this.txtFastaFile.Name = "txtFastaFile";
            this.txtFastaFile.Size = new System.Drawing.Size(469, 23);
            this.txtFastaFile.TabIndex = 11;
            this.txtFastaFile.TextChanged += new System.EventHandler(this.TxtFastaFile_TextChanged);
            this.txtFastaFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.TxtFastaFile_DragDrop);
            this.txtFastaFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxtFastaFile_DragEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(285, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Open Fasta file:";
            // 
            // picFastaOpen
            // 
            this.picFastaOpen.BackColor = System.Drawing.Color.Transparent;
            this.picFastaOpen.Image = global::PhyloMain.Properties.Resources.content_48;
            this.picFastaOpen.Location = new System.Drawing.Point(922, 155);
            this.picFastaOpen.Name = "picFastaOpen";
            this.picFastaOpen.Size = new System.Drawing.Size(24, 23);
            this.picFastaOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFastaOpen.TabIndex = 12;
            this.picFastaOpen.TabStop = false;
            this.picFastaOpen.Click += new System.EventHandler(this.PicFastaOpen_Click);
            this.picFastaOpen.MouseLeave += new System.EventHandler(this.PicFastaOpen_MouseLeave);
            this.picFastaOpen.MouseHover += new System.EventHandler(this.PicFastaOpen_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Open Tree file:";
            // 
            // txtOpenTree
            // 
            this.txtOpenTree.AllowDrop = true;
            this.txtOpenTree.Location = new System.Drawing.Point(447, 195);
            this.txtOpenTree.Name = "txtOpenTree";
            this.txtOpenTree.Size = new System.Drawing.Size(469, 23);
            this.txtOpenTree.TabIndex = 11;
            this.txtOpenTree.TextChanged += new System.EventHandler(this.TxtOpenTree_TextChanged);
            this.txtOpenTree.DragDrop += new System.Windows.Forms.DragEventHandler(this.TxtOpenTree_DragDrop);
            this.txtOpenTree.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxtOpenTree_DragEnter);
            // 
            // picTreeOpen
            // 
            this.picTreeOpen.BackColor = System.Drawing.Color.Transparent;
            this.picTreeOpen.Image = global::PhyloMain.Properties.Resources.content_48;
            this.picTreeOpen.Location = new System.Drawing.Point(922, 195);
            this.picTreeOpen.Name = "picTreeOpen";
            this.picTreeOpen.Size = new System.Drawing.Size(24, 23);
            this.picTreeOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTreeOpen.TabIndex = 12;
            this.picTreeOpen.TabStop = false;
            this.picTreeOpen.Click += new System.EventHandler(this.PicTreeOpen_Click);
            this.picTreeOpen.MouseLeave += new System.EventHandler(this.PicTreeOpen_MouseLeave);
            this.picTreeOpen.MouseHover += new System.EventHandler(this.PicTreeOpen_MouseHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(285, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Open Excel file:";
            // 
            // txtExcel
            // 
            this.txtExcel.AllowDrop = true;
            this.txtExcel.Location = new System.Drawing.Point(447, 236);
            this.txtExcel.Name = "txtExcel";
            this.txtExcel.Size = new System.Drawing.Size(469, 23);
            this.txtExcel.TabIndex = 11;
            this.txtExcel.DoubleClick += new System.EventHandler(this.TxtExcel_DoubleClick);
            // 
            // picExcelOpen
            // 
            this.picExcelOpen.BackColor = System.Drawing.Color.Transparent;
            this.picExcelOpen.Image = global::PhyloMain.Properties.Resources.content_48;
            this.picExcelOpen.Location = new System.Drawing.Point(922, 236);
            this.picExcelOpen.Name = "picExcelOpen";
            this.picExcelOpen.Size = new System.Drawing.Size(24, 23);
            this.picExcelOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExcelOpen.TabIndex = 12;
            this.picExcelOpen.TabStop = false;
            this.picExcelOpen.Click += new System.EventHandler(this.PicExcelOpen_Click);
            this.picExcelOpen.MouseLeave += new System.EventHandler(this.PicExcelOpen_MouseLeave);
            this.picExcelOpen.MouseHover += new System.EventHandler(this.PicExcelOpen_MouseHover);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(253, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Save converted file:";
            // 
            // txtConvertedFile
            // 
            this.txtConvertedFile.Location = new System.Drawing.Point(447, 307);
            this.txtConvertedFile.Name = "txtConvertedFile";
            this.txtConvertedFile.Size = new System.Drawing.Size(469, 23);
            this.txtConvertedFile.TabIndex = 11;
            this.txtConvertedFile.TextChanged += new System.EventHandler(this.TxtConvertedFile_TextChanged);
            this.txtConvertedFile.DoubleClick += new System.EventHandler(this.TxtConvertedFile_DoubleClick);
            // 
            // picSaveConversion
            // 
            this.picSaveConversion.BackColor = System.Drawing.Color.Transparent;
            this.picSaveConversion.Image = global::PhyloMain.Properties.Resources.content_48;
            this.picSaveConversion.Location = new System.Drawing.Point(922, 307);
            this.picSaveConversion.Name = "picSaveConversion";
            this.picSaveConversion.Size = new System.Drawing.Size(24, 23);
            this.picSaveConversion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSaveConversion.TabIndex = 12;
            this.picSaveConversion.TabStop = false;
            this.picSaveConversion.Click += new System.EventHandler(this.PicSaveConversion_Click);
            this.picSaveConversion.MouseLeave += new System.EventHandler(this.PicSaveConversion_MouseLeave);
            this.picSaveConversion.MouseHover += new System.EventHandler(this.PicSaveConversion_MouseHover);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(448, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(360, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Add extra info to labels from the Excel file";
            // 
            // cboProps
            // 
            this.cboProps.FormattingEnabled = true;
            this.cboProps.Location = new System.Drawing.Point(451, 428);
            this.cboProps.Name = "cboProps";
            this.cboProps.Size = new System.Drawing.Size(212, 23);
            this.cboProps.TabIndex = 13;
            this.cboProps.SelectedIndexChanged += new System.EventHandler(this.CboProps_SelectedIndexChanged);
            // 
            // chkConvTree
            // 
            this.chkConvTree.AutoSize = true;
            this.chkConvTree.Location = new System.Drawing.Point(451, 711);
            this.chkConvTree.Name = "chkConvTree";
            this.chkConvTree.Size = new System.Drawing.Size(194, 19);
            this.chkConvTree.TabIndex = 14;
            this.chkConvTree.Text = "Open converted tree file";
            this.chkConvTree.UseVisualStyleBackColor = true;
            // 
            // chkConvFasta
            // 
            this.chkConvFasta.AutoSize = true;
            this.chkConvFasta.Location = new System.Drawing.Point(451, 686);
            this.chkConvFasta.Name = "chkConvFasta";
            this.chkConvFasta.Size = new System.Drawing.Size(201, 19);
            this.chkConvFasta.TabIndex = 14;
            this.chkConvFasta.Text = "Open converted fasta file";
            this.chkConvFasta.UseVisualStyleBackColor = true;
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnConvert.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConvert.Location = new System.Drawing.Point(451, 636);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(172, 34);
            this.btnConvert.TabIndex = 15;
            this.btnConvert.Text = "Start conversion";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnReset.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnReset.Location = new System.Drawing.Point(717, 636);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(172, 34);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset all";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // lblProps
            // 
            this.lblProps.AutoSize = true;
            this.lblProps.Location = new System.Drawing.Point(448, 464);
            this.lblProps.Name = "lblProps";
            this.lblProps.Size = new System.Drawing.Size(0, 15);
            this.lblProps.TabIndex = 16;
            // 
            // picReset
            // 
            this.picReset.Image = global::PhyloMain.Properties.Resources.cancel;
            this.picReset.Location = new System.Drawing.Point(419, 428);
            this.picReset.Name = "picReset";
            this.picReset.Size = new System.Drawing.Size(26, 25);
            this.picReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picReset.TabIndex = 25;
            this.picReset.TabStop = false;
            this.picReset.Click += new System.EventHandler(this.PicReset_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(683, 429);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "piping character:";
            // 
            // txtPiping
            // 
            this.txtPiping.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPiping.Location = new System.Drawing.Point(833, 428);
            this.txtPiping.Name = "txtPiping";
            this.txtPiping.Size = new System.Drawing.Size(29, 25);
            this.txtPiping.TabIndex = 11;
            this.txtPiping.Text = "/";
            this.txtPiping.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPiping.TextChanged += new System.EventHandler(this.TxtConvertedFile_TextChanged);
            // 
            // txtFinished
            // 
            this.txtFinished.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinished.ForeColor = System.Drawing.Color.Firebrick;
            this.txtFinished.Location = new System.Drawing.Point(451, 568);
            this.txtFinished.Multiline = true;
            this.txtFinished.Name = "txtFinished";
            this.txtFinished.Size = new System.Drawing.Size(418, 62);
            this.txtFinished.TabIndex = 26;
            this.txtFinished.Visible = false;
            // 
            // txtWarning
            // 
            this.txtWarning.BackColor = System.Drawing.Color.Black;
            this.txtWarning.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWarning.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWarning.ForeColor = System.Drawing.Color.Red;
            this.txtWarning.Location = new System.Drawing.Point(451, 508);
            this.txtWarning.Name = "txtWarning";
            this.txtWarning.Size = new System.Drawing.Size(357, 19);
            this.txtWarning.TabIndex = 27;
            this.txtWarning.Text = "Conversion is running.... Please wait !";
            this.txtWarning.Visible = false;
            // 
            // LabelConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1251, 837);
            this.Controls.Add(this.txtWarning);
            this.Controls.Add(this.txtFinished);
            this.Controls.Add(this.picReset);
            this.Controls.Add(this.lblProps);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.chkConvFasta);
            this.Controls.Add(this.chkConvTree);
            this.Controls.Add(this.cboProps);
            this.Controls.Add(this.picSaveConversion);
            this.Controls.Add(this.picExcelOpen);
            this.Controls.Add(this.picTreeOpen);
            this.Controls.Add(this.picFastaOpen);
            this.Controls.Add(this.txtPiping);
            this.Controls.Add(this.txtConvertedFile);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtExcel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOpenTree);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFastaFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LabelConversion";
            this.Text = "LabelConversion";
            this.Load += new System.EventHandler(this.LabelConversion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFastaOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTreeOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExcelOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSaveConversion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox picFastaOpen;
        private System.Windows.Forms.TextBox txtFastaFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOpenTree;
        private System.Windows.Forms.PictureBox picTreeOpen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtExcel;
        private System.Windows.Forms.PictureBox picExcelOpen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConvertedFile;
        private System.Windows.Forms.PictureBox picSaveConversion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboProps;
        private System.Windows.Forms.CheckBox chkConvTree;
        private System.Windows.Forms.CheckBox chkConvFasta;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblProps;
        private System.Windows.Forms.PictureBox picReset;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPiping;
        private System.Windows.Forms.TextBox txtFinished;
        private System.Windows.Forms.TextBox txtWarning;
    }
}