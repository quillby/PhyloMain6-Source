namespace PhyloMain
{
    partial class DnaSP
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.numTraits = new System.Windows.Forms.NumericUpDown();
            this.picFileSave = new System.Windows.Forms.PictureBox();
            this.picFileOpen = new System.Windows.Forms.PictureBox();
            this.txtPopArt = new System.Windows.Forms.TextBox();
            this.txtDnaSP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTraits = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTraitName = new System.Windows.Forms.TextBox();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnWritePopArt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTraits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFileSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFileOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraits)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(532, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "DnaSP -> PopArt";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // numTraits
            // 
            this.numTraits.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTraits.Location = new System.Drawing.Point(438, 244);
            this.numTraits.Name = "numTraits";
            this.numTraits.Size = new System.Drawing.Size(46, 26);
            this.numTraits.TabIndex = 3;
            this.numTraits.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // picFileSave
            // 
            this.picFileSave.BackColor = System.Drawing.Color.Transparent;
            this.picFileSave.Image = global::PhyloMain.Properties.Resources.content_48;
            this.picFileSave.Location = new System.Drawing.Point(933, 190);
            this.picFileSave.Name = "picFileSave";
            this.picFileSave.Size = new System.Drawing.Size(24, 23);
            this.picFileSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFileSave.TabIndex = 14;
            this.picFileSave.TabStop = false;
            this.picFileSave.Click += new System.EventHandler(this.PicFileSave_Click);
            this.picFileSave.MouseLeave += new System.EventHandler(this.PicFileSave_MouseLeave);
            this.picFileSave.MouseHover += new System.EventHandler(this.PicFileSave_MouseHover);
            // 
            // picFileOpen
            // 
            this.picFileOpen.BackColor = System.Drawing.Color.Transparent;
            this.picFileOpen.Image = global::PhyloMain.Properties.Resources.content_48;
            this.picFileOpen.Location = new System.Drawing.Point(933, 148);
            this.picFileOpen.Name = "picFileOpen";
            this.picFileOpen.Size = new System.Drawing.Size(24, 23);
            this.picFileOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFileOpen.TabIndex = 15;
            this.picFileOpen.TabStop = false;
            this.picFileOpen.Click += new System.EventHandler(this.PicFileOpen_Click);
            this.picFileOpen.MouseLeave += new System.EventHandler(this.PicFileOpen_MouseLeave);
            this.picFileOpen.MouseHover += new System.EventHandler(this.PicFileOpen_MouseHover);
            // 
            // txtPopArt
            // 
            this.txtPopArt.Location = new System.Drawing.Point(458, 190);
            this.txtPopArt.Name = "txtPopArt";
            this.txtPopArt.Size = new System.Drawing.Size(469, 23);
            this.txtPopArt.TabIndex = 12;
            this.txtPopArt.DoubleClick += new System.EventHandler(this.TxtPopArt_DoubleClick);
            // 
            // txtDnaSP
            // 
            this.txtDnaSP.AllowDrop = true;
            this.txtDnaSP.Location = new System.Drawing.Point(458, 148);
            this.txtDnaSP.Name = "txtDnaSP";
            this.txtDnaSP.Size = new System.Drawing.Size(469, 23);
            this.txtDnaSP.TabIndex = 13;
            this.txtDnaSP.DragDrop += new System.Windows.Forms.DragEventHandler(this.TxtDnaSP_DragDrop);
            this.txtDnaSP.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxtDnaSP_DragEnter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(304, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Save PopArt As:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(296, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Open DnaSP file:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Number of traits to define:";
            // 
            // dgvTraits
            // 
            this.dgvTraits.AllowUserToAddRows = false;
            this.dgvTraits.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvTraits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvTraits.Location = new System.Drawing.Point(211, 300);
            this.dgvTraits.Name = "dgvTraits";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTraits.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgvTraits.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTraits.Size = new System.Drawing.Size(716, 331);
            this.dgvTraits.TabIndex = 17;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Haplotype";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // txtTraitName
            // 
            this.txtTraitName.Location = new System.Drawing.Point(499, 246);
            this.txtTraitName.Name = "txtTraitName";
            this.txtTraitName.Size = new System.Drawing.Size(166, 23);
            this.txtTraitName.TabIndex = 18;
            this.txtTraitName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtTraitName_KeyDown);
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnClearAll.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnClearAll.Location = new System.Drawing.Point(791, 661);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(136, 34);
            this.btnClearAll.TabIndex = 19;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.BtnClearAll_Click);
            // 
            // btnWritePopArt
            // 
            this.btnWritePopArt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnWritePopArt.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWritePopArt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnWritePopArt.Location = new System.Drawing.Point(564, 661);
            this.btnWritePopArt.Name = "btnWritePopArt";
            this.btnWritePopArt.Size = new System.Drawing.Size(178, 34);
            this.btnWritePopArt.TabIndex = 19;
            this.btnWritePopArt.Text = "Write to PopArt";
            this.btnWritePopArt.UseVisualStyleBackColor = false;
            this.btnWritePopArt.Click += new System.EventHandler(this.BtnWritePopArt_Click);
            // 
            // DnaSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1267, 876);
            this.Controls.Add(this.btnWritePopArt);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.txtTraitName);
            this.Controls.Add(this.dgvTraits);
            this.Controls.Add(this.picFileSave);
            this.Controls.Add(this.picFileOpen);
            this.Controls.Add(this.txtPopArt);
            this.Controls.Add(this.txtDnaSP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numTraits);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DnaSP";
            this.Text = "DnaSP";
            this.Load += new System.EventHandler(this.DnaSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTraits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFileSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFileOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.NumericUpDown numTraits;
        private System.Windows.Forms.PictureBox picFileSave;
        private System.Windows.Forms.PictureBox picFileOpen;
        private System.Windows.Forms.TextBox txtPopArt;
        private System.Windows.Forms.TextBox txtDnaSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTraits;
        private System.Windows.Forms.TextBox txtTraitName;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btnWritePopArt;
    }
}