namespace PhyloMain
{
    partial class Export
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
            this.txtFastaFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSelection = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.chkAppend = new System.Windows.Forms.CheckBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.chkReduce = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboSplit = new System.Windows.Forms.ComboBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalExported = new System.Windows.Forms.TextBox();
            this.lstItems = new System.Windows.Forms.CheckedListBox();
            this.lstShowExport = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chkIDonly = new System.Windows.Forms.CheckBox();
            this.lblShow = new System.Windows.Forms.Label();
            this.picShow = new System.Windows.Forms.PictureBox();
            this.picSelSave = new System.Windows.Forms.PictureBox();
            this.picFileOpen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFileOpen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(399, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Export sequences by filter";
            // 
            // txtFastaFile
            // 
            this.txtFastaFile.AllowDrop = true;
            this.txtFastaFile.Location = new System.Drawing.Point(374, 133);
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
            this.label3.Location = new System.Drawing.Point(212, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Open Fasta file:";
            // 
            // txtSelection
            // 
            this.txtSelection.Location = new System.Drawing.Point(374, 172);
            this.txtSelection.Name = "txtSelection";
            this.txtSelection.Size = new System.Drawing.Size(469, 23);
            this.txtSelection.TabIndex = 14;
            this.txtSelection.TextChanged += new System.EventHandler(this.TxtSelection_TextChanged);
            this.txtSelection.DoubleClick += new System.EventHandler(this.TxtSelection_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(212, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Save Selection As:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Export sequences (search):";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(155, 297);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(281, 25);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSearch_KeyPress);
            // 
            // chkAppend
            // 
            this.chkAppend.AutoSize = true;
            this.chkAppend.Location = new System.Drawing.Point(155, 336);
            this.chkAppend.Name = "chkAppend";
            this.chkAppend.Size = new System.Drawing.Size(124, 19);
            this.chkAppend.TabIndex = 17;
            this.chkAppend.Text = "Append to list";
            this.chkAppend.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnShow.Enabled = false;
            this.btnShow.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnShow.Location = new System.Drawing.Point(155, 373);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(66, 28);
            this.btnShow.TabIndex = 18;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // chkReduce
            // 
            this.chkReduce.AutoSize = true;
            this.chkReduce.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkReduce.Location = new System.Drawing.Point(472, 275);
            this.chkReduce.Name = "chkReduce";
            this.chkReduce.Size = new System.Drawing.Size(171, 22);
            this.chkReduce.TabIndex = 19;
            this.chkReduce.Text = "Reduce strain info";
            this.chkReduce.UseVisualStyleBackColor = true;
            this.chkReduce.CheckedChanged += new System.EventHandler(this.ChkReduce_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(664, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Split character";
            // 
            // cboSplit
            // 
            this.cboSplit.FormattingEnabled = true;
            this.cboSplit.Items.AddRange(new object[] {
            "|",
            ",",
            "_",
            "#"});
            this.cboSplit.Location = new System.Drawing.Point(798, 275);
            this.cboSplit.Name = "cboSplit";
            this.cboSplit.Size = new System.Drawing.Size(44, 23);
            this.cboSplit.TabIndex = 20;
            this.cboSplit.SelectedIndexChanged += new System.EventHandler(this.CboSplit_SelectedIndexChanged);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExport.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnExport.Location = new System.Drawing.Point(155, 480);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(168, 28);
            this.btnExport.TabIndex = 18;
            this.btnExport.Text = "Export selection";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnReset.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnReset.Location = new System.Drawing.Point(330, 480);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(168, 28);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset All";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(469, 697);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(288, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total number of sequences exported:";
            // 
            // txtTotalExported
            // 
            this.txtTotalExported.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTotalExported.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalExported.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalExported.Location = new System.Drawing.Point(763, 699);
            this.txtTotalExported.Name = "txtTotalExported";
            this.txtTotalExported.ReadOnly = true;
            this.txtTotalExported.Size = new System.Drawing.Size(80, 16);
            this.txtTotalExported.TabIndex = 21;
            this.txtTotalExported.Text = "0";
            // 
            // lstItems
            // 
            this.lstItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lstItems.CheckOnClick = true;
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(472, 307);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(370, 130);
            this.lstItems.TabIndex = 22;
            // 
            // lstShowExport
            // 
            this.lstShowExport.BackColor = System.Drawing.Color.Honeydew;
            this.lstShowExport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstShowExport.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstShowExport.FullRowSelect = true;
            this.lstShowExport.HideSelection = false;
            this.lstShowExport.Location = new System.Drawing.Point(472, 266);
            this.lstShowExport.Name = "lstShowExport";
            this.lstShowExport.Size = new System.Drawing.Size(730, 421);
            this.lstShowExport.TabIndex = 25;
            this.lstShowExport.TabStop = false;
            this.lstShowExport.UseCompatibleStateImageBehavior = false;
            this.lstShowExport.View = System.Windows.Forms.View.Details;
            this.lstShowExport.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Exported sequences";
            this.columnHeader1.Width = 722;
            // 
            // chkIDonly
            // 
            this.chkIDonly.AutoSize = true;
            this.chkIDonly.Checked = true;
            this.chkIDonly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIDonly.Location = new System.Drawing.Point(155, 407);
            this.chkIDonly.Name = "chkIDonly";
            this.chkIDonly.Size = new System.Drawing.Size(124, 19);
            this.chkIDonly.TabIndex = 23;
            this.chkIDonly.Text = "Only \'>\' lines";
            this.chkIDonly.UseVisualStyleBackColor = true;
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Location = new System.Drawing.Point(504, 240);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(77, 15);
            this.lblShow.TabIndex = 26;
            this.lblShow.Text = "Close view";
            this.lblShow.Visible = false;
            this.lblShow.Click += new System.EventHandler(this.LblShow_Click);
            this.lblShow.MouseLeave += new System.EventHandler(this.LblShow_MouseLeave);
            this.lblShow.MouseHover += new System.EventHandler(this.LblShow_MouseHover);
            // 
            // picShow
            // 
            this.picShow.Image = global::PhyloMain.Properties.Resources.cancel;
            this.picShow.Location = new System.Drawing.Point(472, 235);
            this.picShow.Name = "picShow";
            this.picShow.Size = new System.Drawing.Size(26, 25);
            this.picShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShow.TabIndex = 24;
            this.picShow.TabStop = false;
            this.picShow.Visible = false;
            this.picShow.Click += new System.EventHandler(this.PictureBox1_Click);
            this.picShow.MouseLeave += new System.EventHandler(this.PicShow_MouseLeave);
            this.picShow.MouseHover += new System.EventHandler(this.PicShow_MouseHover);
            // 
            // picSelSave
            // 
            this.picSelSave.BackColor = System.Drawing.Color.Transparent;
            this.picSelSave.Image = global::PhyloMain.Properties.Resources.content_48;
            this.picSelSave.Location = new System.Drawing.Point(849, 172);
            this.picSelSave.Name = "picSelSave";
            this.picSelSave.Size = new System.Drawing.Size(24, 23);
            this.picSelSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSelSave.TabIndex = 15;
            this.picSelSave.TabStop = false;
            this.picSelSave.Click += new System.EventHandler(this.PicSelSave_Click);
            this.picSelSave.MouseLeave += new System.EventHandler(this.PicSelSave_MouseLeave);
            this.picSelSave.MouseHover += new System.EventHandler(this.PicSelSave_MouseHover);
            // 
            // picFileOpen
            // 
            this.picFileOpen.BackColor = System.Drawing.Color.Transparent;
            this.picFileOpen.Image = global::PhyloMain.Properties.Resources.content_48;
            this.picFileOpen.Location = new System.Drawing.Point(849, 133);
            this.picFileOpen.Name = "picFileOpen";
            this.picFileOpen.Size = new System.Drawing.Size(24, 23);
            this.picFileOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFileOpen.TabIndex = 12;
            this.picFileOpen.TabStop = false;
            this.picFileOpen.Click += new System.EventHandler(this.PicFileOpen_Click);
            this.picFileOpen.MouseLeave += new System.EventHandler(this.PicFileOpen_MouseLeave);
            this.picFileOpen.MouseHover += new System.EventHandler(this.PicFileOpen_MouseHover);
            // 
            // Export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1267, 876);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.picShow);
            this.Controls.Add(this.lstShowExport);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.txtTotalExported);
            this.Controls.Add(this.cboSplit);
            this.Controls.Add(this.chkReduce);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.chkAppend);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.picSelSave);
            this.Controls.Add(this.txtSelection);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picFileOpen);
            this.Controls.Add(this.txtFastaFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkIDonly);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Export";
            this.Text = "Export";
            this.Load += new System.EventHandler(this.Export_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFileOpen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picFileOpen;
        private System.Windows.Forms.TextBox txtFastaFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picSelSave;
        private System.Windows.Forms.TextBox txtSelection;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.CheckBox chkAppend;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.CheckBox chkReduce;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboSplit;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalExported;
        private System.Windows.Forms.CheckedListBox lstItems;
        private System.Windows.Forms.ListView lstShowExport;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.PictureBox picShow;
        private System.Windows.Forms.CheckBox chkIDonly;
        private System.Windows.Forms.Label lblShow;
    }
}