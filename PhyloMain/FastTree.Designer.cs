namespace PhyloMain
{
    partial class FastTree
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
            this.txtFasttree = new System.Windows.Forms.TextBox();
            this.txtFastaFile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picSaveTree = new System.Windows.Forms.PictureBox();
            this.picFastaOpen = new System.Windows.Forms.PictureBox();
            this.lblParam = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnFastTree = new System.Windows.Forms.Button();
            this.chkViewTree = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRunning = new System.Windows.Forms.Label();
            this.chkCommand = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSaveTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFastaOpen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(465, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tree build with FastTree";
            // 
            // txtFasttree
            // 
            this.txtFasttree.Location = new System.Drawing.Point(442, 197);
            this.txtFasttree.Name = "txtFasttree";
            this.txtFasttree.Size = new System.Drawing.Size(469, 23);
            this.txtFasttree.TabIndex = 22;
            this.txtFasttree.TextChanged += new System.EventHandler(this.TxtFasttree_TextChanged);
            this.txtFasttree.DoubleClick += new System.EventHandler(this.TxtFasttree_DoubleClick);
            // 
            // txtFastaFile
            // 
            this.txtFastaFile.AllowDrop = true;
            this.txtFastaFile.Location = new System.Drawing.Point(442, 155);
            this.txtFastaFile.Name = "txtFastaFile";
            this.txtFastaFile.Size = new System.Drawing.Size(469, 23);
            this.txtFastaFile.TabIndex = 23;
            this.txtFastaFile.TextChanged += new System.EventHandler(this.TxtFastaFile_TextChanged);
            this.txtFastaFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.TxtFastaFile_DragDrop_1);
            this.txtFastaFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxtFastaFile_DragEnter_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(280, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Save FastTree As:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(296, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Open alignment:";
            // 
            // picSaveTree
            // 
            this.picSaveTree.BackColor = System.Drawing.Color.Transparent;
            this.picSaveTree.Image = global::PhyloMain.Properties.Resources.content_48;
            this.picSaveTree.Location = new System.Drawing.Point(917, 197);
            this.picSaveTree.Name = "picSaveTree";
            this.picSaveTree.Size = new System.Drawing.Size(24, 23);
            this.picSaveTree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSaveTree.TabIndex = 24;
            this.picSaveTree.TabStop = false;
            this.picSaveTree.Click += new System.EventHandler(this.PicSaveTree_Click);
            this.picSaveTree.MouseLeave += new System.EventHandler(this.PicSaveTree_MouseLeave);
            this.picSaveTree.MouseHover += new System.EventHandler(this.PicSaveTree_MouseHover);
            // 
            // picFastaOpen
            // 
            this.picFastaOpen.BackColor = System.Drawing.Color.Transparent;
            this.picFastaOpen.Image = global::PhyloMain.Properties.Resources.content_48;
            this.picFastaOpen.Location = new System.Drawing.Point(917, 155);
            this.picFastaOpen.Name = "picFastaOpen";
            this.picFastaOpen.Size = new System.Drawing.Size(24, 23);
            this.picFastaOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFastaOpen.TabIndex = 25;
            this.picFastaOpen.TabStop = false;
            this.picFastaOpen.Click += new System.EventHandler(this.PicFastaOpen_Click);
            this.picFastaOpen.MouseLeave += new System.EventHandler(this.PicFastaOpen_MouseLeave);
            this.picFastaOpen.MouseHover += new System.EventHandler(this.PicFastaOpen_MouseHover);
            // 
            // lblParam
            // 
            this.lblParam.AutoSize = true;
            this.lblParam.Location = new System.Drawing.Point(27, 790);
            this.lblParam.Name = "lblParam";
            this.lblParam.Size = new System.Drawing.Size(133, 15);
            this.lblParam.TabIndex = 26;
            this.lblParam.Text = "parameters visible";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnNew.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNew.Location = new System.Drawing.Point(651, 569);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(162, 34);
            this.btnNew.TabIndex = 27;
            this.btnNew.Text = "New Calculation";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // btnFastTree
            // 
            this.btnFastTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnFastTree.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFastTree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnFastTree.Location = new System.Drawing.Point(442, 569);
            this.btnFastTree.Name = "btnFastTree";
            this.btnFastTree.Size = new System.Drawing.Size(172, 34);
            this.btnFastTree.TabIndex = 28;
            this.btnFastTree.Text = "Start FastTree";
            this.btnFastTree.UseVisualStyleBackColor = false;
            this.btnFastTree.Click += new System.EventHandler(this.BtnFastTree_Click);
            // 
            // chkViewTree
            // 
            this.chkViewTree.AutoSize = true;
            this.chkViewTree.Location = new System.Drawing.Point(442, 622);
            this.chkViewTree.Name = "chkViewTree";
            this.chkViewTree.Size = new System.Drawing.Size(166, 19);
            this.chkViewTree.TabIndex = 29;
            this.chkViewTree.Text = "View tree in FigTree";
            this.chkViewTree.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(184, 226);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 318);
            this.panel1.TabIndex = 30;
            this.panel1.Visible = false;
            // 
            // lblRunning
            // 
            this.lblRunning.AutoSize = true;
            this.lblRunning.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunning.ForeColor = System.Drawing.Color.Red;
            this.lblRunning.Location = new System.Drawing.Point(791, 645);
            this.lblRunning.Name = "lblRunning";
            this.lblRunning.Size = new System.Drawing.Size(117, 19);
            this.lblRunning.TabIndex = 32;
            this.lblRunning.Text = "Running.....";
            this.lblRunning.Visible = false;
            // 
            // chkCommand
            // 
            this.chkCommand.AutoSize = true;
            this.chkCommand.Checked = true;
            this.chkCommand.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCommand.Location = new System.Drawing.Point(442, 647);
            this.chkCommand.Name = "chkCommand";
            this.chkCommand.Size = new System.Drawing.Size(152, 19);
            this.chkCommand.TabIndex = 31;
            this.chkCommand.Text = "Show output window";
            this.chkCommand.UseVisualStyleBackColor = true;
            // 
            // FastTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1251, 837);
            this.Controls.Add(this.lblRunning);
            this.Controls.Add(this.chkCommand);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chkViewTree);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnFastTree);
            this.Controls.Add(this.lblParam);
            this.Controls.Add(this.picSaveTree);
            this.Controls.Add(this.picFastaOpen);
            this.Controls.Add(this.txtFasttree);
            this.Controls.Add(this.txtFastaFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FastTree";
            this.Text = "FastTree";
            this.Load += new System.EventHandler(this.FastTree_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSaveTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFastaOpen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picSaveTree;
        private System.Windows.Forms.PictureBox picFastaOpen;
        private System.Windows.Forms.TextBox txtFasttree;
        private System.Windows.Forms.TextBox txtFastaFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblParam;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnFastTree;
        private System.Windows.Forms.CheckBox chkViewTree;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRunning;
        private System.Windows.Forms.CheckBox chkCommand;
    }
}