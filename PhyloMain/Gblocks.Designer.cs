namespace PhyloMain
{
    partial class Gblocks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gblocks));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cboGaps = new System.Windows.Forms.ComboBox();
            this.txtB4 = new System.Windows.Forms.TextBox();
            this.txtB3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.picFileOpen = new System.Windows.Forms.PictureBox();
            this.txtAlignment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnGblocks = new System.Windows.Forms.Button();
            this.btnOpenGb = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picFileOpen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(585, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "GBlocks";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(417, 95);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(454, 103);
            this.textBox1.TabIndex = 3;
            this.textBox1.TabStop = false;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // cboGaps
            // 
            this.cboGaps.Enabled = false;
            this.cboGaps.FormattingEnabled = true;
            this.cboGaps.Items.AddRange(new object[] {
            "None",
            "With Half",
            "All"});
            this.cboGaps.Location = new System.Drawing.Point(605, 402);
            this.cboGaps.Name = "cboGaps";
            this.cboGaps.Size = new System.Drawing.Size(87, 23);
            this.cboGaps.TabIndex = 28;
            this.cboGaps.Text = "None";
            // 
            // txtB4
            // 
            this.txtB4.Enabled = false;
            this.txtB4.Location = new System.Drawing.Point(633, 369);
            this.txtB4.Name = "txtB4";
            this.txtB4.Size = new System.Drawing.Size(33, 23);
            this.txtB4.TabIndex = 27;
            this.txtB4.Text = "10";
            this.toolTip1.SetToolTip(this.txtB4, "Bigger values of this parameter DECREASE the selected number of positions");
            this.txtB4.TextChanged += new System.EventHandler(this.TxtB4_TextChanged);
            // 
            // txtB3
            // 
            this.txtB3.Enabled = false;
            this.txtB3.Location = new System.Drawing.Point(815, 334);
            this.txtB3.Name = "txtB3";
            this.txtB3.Size = new System.Drawing.Size(33, 23);
            this.txtB3.TabIndex = 26;
            this.txtB3.Text = "8";
            this.toolTip1.SetToolTip(this.txtB3, "Bigger values of this parameter INCREASE the selected number of positions");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(438, 405);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "Allowed Gap Positions:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(438, 372);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "Minimum Length Of A Block:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(438, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(371, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Maximum Number Of Contiguous Nonconserved Positions:";
            // 
            // picFileOpen
            // 
            this.picFileOpen.BackColor = System.Drawing.Color.Transparent;
            this.picFileOpen.Image = global::PhyloMain.Properties.Resources.content_48;
            this.picFileOpen.Location = new System.Drawing.Point(892, 249);
            this.picFileOpen.Name = "picFileOpen";
            this.picFileOpen.Size = new System.Drawing.Size(24, 23);
            this.picFileOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFileOpen.TabIndex = 31;
            this.picFileOpen.TabStop = false;
            this.picFileOpen.Click += new System.EventHandler(this.PicFileOpen_Click);
            this.picFileOpen.MouseLeave += new System.EventHandler(this.PicFileOpen_MouseLeave);
            this.picFileOpen.MouseHover += new System.EventHandler(this.PicFileOpen_MouseHover);
            // 
            // txtAlignment
            // 
            this.txtAlignment.AllowDrop = true;
            this.txtAlignment.Location = new System.Drawing.Point(417, 249);
            this.txtAlignment.Name = "txtAlignment";
            this.txtAlignment.Size = new System.Drawing.Size(469, 23);
            this.txtAlignment.TabIndex = 30;
            this.txtAlignment.TextChanged += new System.EventHandler(this.TxtAlignment_TextChanged);
            this.txtAlignment.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtAlignment_DragDrop);
            this.txtAlignment.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtAlignment_DragEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 18);
            this.label3.TabIndex = 29;
            this.label3.Text = "Open Fasta alignment:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnClearAll.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnClearAll.Location = new System.Drawing.Point(543, 515);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(136, 34);
            this.btnClearAll.TabIndex = 33;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.BtnClearAll_Click);
            // 
            // btnGblocks
            // 
            this.btnGblocks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnGblocks.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGblocks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGblocks.Location = new System.Drawing.Point(334, 515);
            this.btnGblocks.Name = "btnGblocks";
            this.btnGblocks.Size = new System.Drawing.Size(172, 34);
            this.btnGblocks.TabIndex = 32;
            this.btnGblocks.Text = "Start Gblocks";
            this.btnGblocks.UseVisualStyleBackColor = false;
            this.btnGblocks.Click += new System.EventHandler(this.BtnGblocks_Click);
            // 
            // btnOpenGb
            // 
            this.btnOpenGb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnOpenGb.Enabled = false;
            this.btnOpenGb.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenGb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOpenGb.Location = new System.Drawing.Point(713, 515);
            this.btnOpenGb.Name = "btnOpenGb";
            this.btnOpenGb.Size = new System.Drawing.Size(230, 34);
            this.btnOpenGb.TabIndex = 32;
            this.btnOpenGb.Text = "Open Gblocks alignment";
            this.btnOpenGb.UseVisualStyleBackColor = false;
            this.btnOpenGb.Click += new System.EventHandler(this.BtnOpenGb_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(110, 699);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 34;
            this.panel1.Visible = false;
            // 
            // Gblocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1251, 837);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnOpenGb);
            this.Controls.Add(this.btnGblocks);
            this.Controls.Add(this.picFileOpen);
            this.Controls.Add(this.txtAlignment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboGaps);
            this.Controls.Add(this.txtB4);
            this.Controls.Add(this.txtB3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Gblocks";
            this.Text = "Gblocks";
            this.Load += new System.EventHandler(this.Gblocks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFileOpen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cboGaps;
        private System.Windows.Forms.TextBox txtB4;
        private System.Windows.Forms.TextBox txtB3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picFileOpen;
        private System.Windows.Forms.TextBox txtAlignment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnGblocks;
        private System.Windows.Forms.Button btnOpenGb;
        private System.Windows.Forms.Panel panel1;
    }
}