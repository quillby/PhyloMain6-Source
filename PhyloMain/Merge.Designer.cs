namespace PhyloMain
{
    partial class Merge
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
            this.txtFastaFile1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblParam = new System.Windows.Forms.Label();
            this.chkOpenAlignment = new System.Windows.Forms.CheckBox();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnMerge = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFastaFile2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSaveAs = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.picSaveNew = new System.Windows.Forms.PictureBox();
            this.picFileOpen2 = new System.Windows.Forms.PictureBox();
            this.picFileOpen1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSaveNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFileOpen2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFileOpen1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(444, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Merge two alignments and re-align";
            // 
            // txtFastaFile1
            // 
            this.txtFastaFile1.AllowDrop = true;
            this.txtFastaFile1.Location = new System.Drawing.Point(448, 188);
            this.txtFastaFile1.Name = "txtFastaFile1";
            this.txtFastaFile1.Size = new System.Drawing.Size(469, 23);
            this.txtFastaFile1.TabIndex = 11;
            this.txtFastaFile1.TextChanged += new System.EventHandler(this.TxtFastaFile1_TextChanged);
            this.txtFastaFile1.DragDrop += new System.Windows.Forms.DragEventHandler(this.TxtFastaFile1_DragDrop_1);
            this.txtFastaFile1.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxtFastaFile1_DragEnter_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(274, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Open 1st alignment:";
            // 
            // lblParam
            // 
            this.lblParam.AutoSize = true;
            this.lblParam.Location = new System.Drawing.Point(33, 773);
            this.lblParam.Name = "lblParam";
            this.lblParam.Size = new System.Drawing.Size(133, 15);
            this.lblParam.TabIndex = 16;
            this.lblParam.Text = "parameters visible";
            // 
            // chkOpenAlignment
            // 
            this.chkOpenAlignment.AutoSize = true;
            this.chkOpenAlignment.Location = new System.Drawing.Point(494, 611);
            this.chkOpenAlignment.Name = "chkOpenAlignment";
            this.chkOpenAlignment.Size = new System.Drawing.Size(215, 19);
            this.chkOpenAlignment.TabIndex = 15;
            this.chkOpenAlignment.Text = "Open alignment with BioEdit";
            this.chkOpenAlignment.UseVisualStyleBackColor = true;
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnClearAll.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnClearAll.Location = new System.Drawing.Point(703, 562);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(136, 34);
            this.btnClearAll.TabIndex = 13;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.BtnClearAll_Click);
            // 
            // btnMerge
            // 
            this.btnMerge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnMerge.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMerge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMerge.Location = new System.Drawing.Point(494, 562);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(172, 34);
            this.btnMerge.TabIndex = 14;
            this.btnMerge.Text = "Start merging";
            this.btnMerge.UseVisualStyleBackColor = false;
            this.btnMerge.Click += new System.EventHandler(this.BtnMerge_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Open 2nd alignment:";
            // 
            // txtFastaFile2
            // 
            this.txtFastaFile2.AllowDrop = true;
            this.txtFastaFile2.Location = new System.Drawing.Point(448, 227);
            this.txtFastaFile2.Name = "txtFastaFile2";
            this.txtFastaFile2.Size = new System.Drawing.Size(469, 23);
            this.txtFastaFile2.TabIndex = 11;
            this.txtFastaFile2.TextChanged += new System.EventHandler(this.TxtFastaFile2_TextChanged);
            this.txtFastaFile2.DragDrop += new System.Windows.Forms.DragEventHandler(this.TxtFastaFile2_DragDrop_1);
            this.txtFastaFile2.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxtFastaFile2_DragEnter_1);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(329, 305);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 237);
            this.panel1.TabIndex = 17;
            this.panel1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(274, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Save new alignment:";
            // 
            // txtSaveAs
            // 
            this.txtSaveAs.Location = new System.Drawing.Point(448, 267);
            this.txtSaveAs.Name = "txtSaveAs";
            this.txtSaveAs.Size = new System.Drawing.Size(469, 23);
            this.txtSaveAs.TabIndex = 11;
            this.txtSaveAs.TextChanged += new System.EventHandler(this.TxtSaveAs_TextChanged);
            this.txtSaveAs.DoubleClick += new System.EventHandler(this.TxtSaveAs_DoubleClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // picSaveNew
            // 
            this.picSaveNew.BackColor = System.Drawing.Color.Transparent;
            this.picSaveNew.Image = global::PhyloMain.Properties.Resources.content_48;
            this.picSaveNew.Location = new System.Drawing.Point(923, 267);
            this.picSaveNew.Name = "picSaveNew";
            this.picSaveNew.Size = new System.Drawing.Size(24, 23);
            this.picSaveNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSaveNew.TabIndex = 12;
            this.picSaveNew.TabStop = false;
            this.picSaveNew.Click += new System.EventHandler(this.PicSaveNew_Click);
            this.picSaveNew.MouseLeave += new System.EventHandler(this.PicSaveNew_MouseLeave);
            this.picSaveNew.MouseHover += new System.EventHandler(this.PicSaveNew_MouseHover);
            // 
            // picFileOpen2
            // 
            this.picFileOpen2.BackColor = System.Drawing.Color.Transparent;
            this.picFileOpen2.Image = global::PhyloMain.Properties.Resources.content_48;
            this.picFileOpen2.Location = new System.Drawing.Point(923, 227);
            this.picFileOpen2.Name = "picFileOpen2";
            this.picFileOpen2.Size = new System.Drawing.Size(24, 23);
            this.picFileOpen2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFileOpen2.TabIndex = 12;
            this.picFileOpen2.TabStop = false;
            this.picFileOpen2.Click += new System.EventHandler(this.PicFileOpen2_Click);
            this.picFileOpen2.MouseLeave += new System.EventHandler(this.PicFileOpen2_MouseLeave);
            this.picFileOpen2.MouseHover += new System.EventHandler(this.PicFileOpen2_MouseHover);
            // 
            // picFileOpen1
            // 
            this.picFileOpen1.BackColor = System.Drawing.Color.Transparent;
            this.picFileOpen1.Image = global::PhyloMain.Properties.Resources.content_48;
            this.picFileOpen1.Location = new System.Drawing.Point(923, 188);
            this.picFileOpen1.Name = "picFileOpen1";
            this.picFileOpen1.Size = new System.Drawing.Size(24, 23);
            this.picFileOpen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFileOpen1.TabIndex = 12;
            this.picFileOpen1.TabStop = false;
            this.picFileOpen1.Click += new System.EventHandler(this.PicFileOpen1_Click);
            this.picFileOpen1.MouseLeave += new System.EventHandler(this.PicFileOpen1_MouseLeave);
            this.picFileOpen1.MouseHover += new System.EventHandler(this.PicFileOpen1_MouseHover);
            // 
            // Merge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1251, 837);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblParam);
            this.Controls.Add(this.chkOpenAlignment);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.picSaveNew);
            this.Controls.Add(this.picFileOpen2);
            this.Controls.Add(this.picFileOpen1);
            this.Controls.Add(this.txtSaveAs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFastaFile2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFastaFile1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Merge";
            this.Text = "Merge";
            this.Load += new System.EventHandler(this.Merge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSaveNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFileOpen2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFileOpen1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picFileOpen1;
        private System.Windows.Forms.TextBox txtFastaFile1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblParam;
        private System.Windows.Forms.CheckBox chkOpenAlignment;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFastaFile2;
        private System.Windows.Forms.PictureBox picFileOpen2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSaveAs;
        private System.Windows.Forms.PictureBox picSaveNew;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}