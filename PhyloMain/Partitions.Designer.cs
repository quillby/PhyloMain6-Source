namespace PhyloMain
{
    partial class Partitions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Partitions));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNrGenes = new System.Windows.Forms.TextBox();
            this.txtMarker = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.dgvPartitions = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClear = new System.Windows.Forms.Button();
            this.chkChar = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkShow = new System.Windows.Forms.CheckBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtMyChar = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.picFileOpen = new System.Windows.Forms.PictureBox();
            this.txtNexusFile = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHomPart = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartitions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFileOpen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(496, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Partitions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(313, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Number of genes concatenated:";
            // 
            // txtNrGenes
            // 
            this.txtNrGenes.Location = new System.Drawing.Point(559, 175);
            this.txtNrGenes.Name = "txtNrGenes";
            this.txtNrGenes.Size = new System.Drawing.Size(54, 23);
            this.txtNrGenes.TabIndex = 0;
            // 
            // txtMarker
            // 
            this.txtMarker.Location = new System.Drawing.Point(316, 267);
            this.txtMarker.Name = "txtMarker";
            this.txtMarker.Size = new System.Drawing.Size(99, 23);
            this.txtMarker.TabIndex = 1;
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(482, 267);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(54, 23);
            this.txtFrom.TabIndex = 2;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(572, 267);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(54, 23);
            this.txtTo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(319, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Marker name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(436, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "from";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(542, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "to";
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddItem.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddItem.Location = new System.Drawing.Point(651, 259);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(114, 34);
            this.btnAddItem.TabIndex = 4;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.BtnAddItem_Click);
            // 
            // dgvPartitions
            // 
            this.dgvPartitions.AllowUserToAddRows = false;
            this.dgvPartitions.AllowUserToDeleteRows = false;
            this.dgvPartitions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPartitions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPartitions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPartitions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvPartitions.Location = new System.Drawing.Point(316, 319);
            this.dgvPartitions.MultiSelect = false;
            this.dgvPartitions.Name = "dgvPartitions";
            this.dgvPartitions.Size = new System.Drawing.Size(310, 186);
            this.dgvPartitions.TabIndex = 27;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Marker name";
            this.Column1.Name = "Column1";
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "From";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "To";
            this.Column3.Name = "Column3";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnClear.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnClear.Location = new System.Drawing.Point(651, 319);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(114, 34);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Clear List";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // chkChar
            // 
            this.chkChar.AutoSize = true;
            this.chkChar.Location = new System.Drawing.Point(316, 513);
            this.chkChar.Name = "chkChar";
            this.chkChar.Size = new System.Drawing.Size(159, 19);
            this.chkChar.TabIndex = 28;
            this.chkChar.Text = "Add \'charpartition\'";
            this.chkChar.UseVisualStyleBackColor = true;
            this.chkChar.CheckedChanged += new System.EventHandler(this.ChkChar_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSave.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSave.Location = new System.Drawing.Point(316, 549);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(206, 34);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save partition file";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // chkShow
            // 
            this.chkShow.AutoSize = true;
            this.chkShow.Location = new System.Drawing.Point(316, 589);
            this.chkShow.Name = "chkShow";
            this.chkShow.Size = new System.Drawing.Size(180, 19);
            this.chkShow.TabIndex = 28;
            this.chkShow.Text = "Open file after saving";
            this.chkShow.UseVisualStyleBackColor = true;
            // 
            // txtMyChar
            // 
            this.txtMyChar.Location = new System.Drawing.Point(482, 511);
            this.txtMyChar.Name = "txtMyChar";
            this.txtMyChar.Size = new System.Drawing.Size(99, 23);
            this.txtMyChar.TabIndex = 1;
            this.txtMyChar.Text = "markers";
            this.txtMyChar.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(771, 511);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(412, 118);
            this.textBox1.TabIndex = 29;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // picFileOpen
            // 
            this.picFileOpen.BackColor = System.Drawing.Color.Transparent;
            this.picFileOpen.Image = global::PhyloMain.Properties.Resources.content_48;
            this.picFileOpen.Location = new System.Drawing.Point(771, 681);
            this.picFileOpen.Name = "picFileOpen";
            this.picFileOpen.Size = new System.Drawing.Size(24, 23);
            this.picFileOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFileOpen.TabIndex = 32;
            this.picFileOpen.TabStop = false;
            this.picFileOpen.Click += new System.EventHandler(this.PicFileOpen_Click);
            this.picFileOpen.MouseLeave += new System.EventHandler(this.PicFileOpen_MouseLeave);
            this.picFileOpen.MouseHover += new System.EventHandler(this.PicFileOpen_MouseHover);
            // 
            // txtNexusFile
            // 
            this.txtNexusFile.AllowDrop = true;
            this.txtNexusFile.Location = new System.Drawing.Point(379, 681);
            this.txtNexusFile.Name = "txtNexusFile";
            this.txtNexusFile.Size = new System.Drawing.Size(386, 23);
            this.txtNexusFile.TabIndex = 31;
            this.txtNexusFile.TextChanged += new System.EventHandler(this.TxtNexusFile_TextChanged);
            this.txtNexusFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.TxtNexusFile_DragDrop);
            this.txtNexusFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxtNexusFile_DragEnter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(221, 682);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 18);
            this.label6.TabIndex = 30;
            this.label6.Text = "Choose Nexus file:";
            // 
            // btnHomPart
            // 
            this.btnHomPart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnHomPart.Enabled = false;
            this.btnHomPart.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomPart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnHomPart.Location = new System.Drawing.Point(559, 736);
            this.btnHomPart.Name = "btnHomPart";
            this.btnHomPart.Size = new System.Drawing.Size(206, 34);
            this.btnHomPart.TabIndex = 26;
            this.btnHomPart.Text = "Save PAUP file";
            this.btnHomPart.UseVisualStyleBackColor = false;
            this.btnHomPart.Click += new System.EventHandler(this.BtnHomPart_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Partitions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1267, 876);
            this.Controls.Add(this.picFileOpen);
            this.Controls.Add(this.txtNexusFile);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chkShow);
            this.Controls.Add(this.chkChar);
            this.Controls.Add(this.dgvPartitions);
            this.Controls.Add(this.btnHomPart);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.txtMyChar);
            this.Controls.Add(this.txtMarker);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.txtNrGenes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Partitions";
            this.Text = "Partitions";
            this.Load += new System.EventHandler(this.Partitions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartitions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFileOpen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNrGenes;
        private System.Windows.Forms.TextBox txtMarker;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.DataGridView dgvPartitions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox chkChar;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkShow;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtMyChar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox picFileOpen;
        private System.Windows.Forms.TextBox txtNexusFile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHomPart;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}