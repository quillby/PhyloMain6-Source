namespace PhyloMain
{
    partial class RaxML
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
            this.txtRaxMLtree = new System.Windows.Forms.TextBox();
            this.txtFastaFile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStartRaxML = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.chkViewTree = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBootstraps = new System.Windows.Forms.TextBox();
            this.chkDefault = new System.Windows.Forms.CheckBox();
            this.chkThreads = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtThreads = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblParam = new System.Windows.Forms.Label();
            this.picSaveTree = new System.Windows.Forms.PictureBox();
            this.picFastaOpen = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkAmountTaxa = new System.Windows.Forms.CheckBox();
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
            this.label1.Location = new System.Drawing.Point(498, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tree build with RaxML";
            // 
            // txtRaxMLtree
            // 
            this.txtRaxMLtree.Location = new System.Drawing.Point(463, 198);
            this.txtRaxMLtree.Name = "txtRaxMLtree";
            this.txtRaxMLtree.Size = new System.Drawing.Size(469, 23);
            this.txtRaxMLtree.TabIndex = 22;
            this.txtRaxMLtree.TextChanged += new System.EventHandler(this.TxtRaxMLtree_TextChanged);
            this.txtRaxMLtree.DoubleClick += new System.EventHandler(this.TxtRaxMLtree_DoubleClick);
            // 
            // txtFastaFile
            // 
            this.txtFastaFile.AllowDrop = true;
            this.txtFastaFile.Location = new System.Drawing.Point(463, 156);
            this.txtFastaFile.Name = "txtFastaFile";
            this.txtFastaFile.Size = new System.Drawing.Size(469, 23);
            this.txtFastaFile.TabIndex = 23;
            this.txtFastaFile.TextChanged += new System.EventHandler(this.TxtFastaFile_TextChanged);
            this.txtFastaFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.TxtFastaFile_DragDrop);
            this.txtFastaFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxtFastaFile_DragEnter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(331, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Save tree As:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(315, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Open alignment:";
            // 
            // btnStartRaxML
            // 
            this.btnStartRaxML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnStartRaxML.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartRaxML.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnStartRaxML.Location = new System.Drawing.Point(480, 475);
            this.btnStartRaxML.Name = "btnStartRaxML";
            this.btnStartRaxML.Size = new System.Drawing.Size(172, 34);
            this.btnStartRaxML.TabIndex = 26;
            this.btnStartRaxML.Text = "Build tree";
            this.btnStartRaxML.UseVisualStyleBackColor = false;
            this.btnStartRaxML.Click += new System.EventHandler(this.BtnStartRaxML_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnNew.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNew.Location = new System.Drawing.Point(712, 475);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(172, 34);
            this.btnNew.TabIndex = 26;
            this.btnNew.Text = "New calculation";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // chkViewTree
            // 
            this.chkViewTree.AutoSize = true;
            this.chkViewTree.Location = new System.Drawing.Point(480, 524);
            this.chkViewTree.Name = "chkViewTree";
            this.chkViewTree.Size = new System.Drawing.Size(166, 19);
            this.chkViewTree.TabIndex = 27;
            this.chkViewTree.Text = "View tree in FigTree";
            this.chkViewTree.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(361, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Bootstraps:";
            // 
            // txtBootstraps
            // 
            this.txtBootstraps.Enabled = false;
            this.txtBootstraps.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBootstraps.Location = new System.Drawing.Point(463, 279);
            this.txtBootstraps.Name = "txtBootstraps";
            this.txtBootstraps.Size = new System.Drawing.Size(54, 26);
            this.txtBootstraps.TabIndex = 22;
            this.txtBootstraps.Text = "1000";
            // 
            // chkDefault
            // 
            this.chkDefault.AutoSize = true;
            this.chkDefault.Checked = true;
            this.chkDefault.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDefault.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDefault.Location = new System.Drawing.Point(557, 280);
            this.chkDefault.Name = "chkDefault";
            this.chkDefault.Size = new System.Drawing.Size(363, 22);
            this.chkDefault.TabIndex = 28;
            this.chkDefault.Text = "Use bootstrap convergence instead of value";
            this.chkDefault.UseVisualStyleBackColor = true;
            this.chkDefault.CheckedChanged += new System.EventHandler(this.ChkDefault_CheckedChanged);
            // 
            // chkThreads
            // 
            this.chkThreads.AutoSize = true;
            this.chkThreads.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkThreads.Location = new System.Drawing.Point(557, 405);
            this.chkThreads.Name = "chkThreads";
            this.chkThreads.Size = new System.Drawing.Size(203, 22);
            this.chkThreads.TabIndex = 29;
            this.chkThreads.Text = "Use RaxML with threads";
            this.chkThreads.UseVisualStyleBackColor = true;
            this.chkThreads.CheckedChanged += new System.EventHandler(this.ChkThreads_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(788, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Threads:";
            // 
            // txtThreads
            // 
            this.txtThreads.Enabled = false;
            this.txtThreads.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThreads.Location = new System.Drawing.Point(866, 402);
            this.txtThreads.Name = "txtThreads";
            this.txtThreads.Size = new System.Drawing.Size(31, 26);
            this.txtThreads.TabIndex = 22;
            this.txtThreads.Text = "2";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(557, 308);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(369, 52);
            this.richTextBox1.TabIndex = 30;
            this.richTextBox1.Text = "This will run 1000 replicates in order to reach convergence.\nIf convergence wasn\'" +
    "t reach, run the analysis with more than\n1000 replicates by unchecking this opti" +
    "on.";
            // 
            // lblParam
            // 
            this.lblParam.AutoSize = true;
            this.lblParam.Location = new System.Drawing.Point(36, 811);
            this.lblParam.Name = "lblParam";
            this.lblParam.Size = new System.Drawing.Size(133, 15);
            this.lblParam.TabIndex = 32;
            this.lblParam.Text = "parameters visible";
            // 
            // picSaveTree
            // 
            this.picSaveTree.BackColor = System.Drawing.Color.Transparent;
            this.picSaveTree.Image = global::PhyloMain.Properties.Resources.content_48;
            this.picSaveTree.Location = new System.Drawing.Point(938, 198);
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
            this.picFastaOpen.Location = new System.Drawing.Point(938, 156);
            this.picFastaOpen.Name = "picFastaOpen";
            this.picFastaOpen.Size = new System.Drawing.Size(24, 23);
            this.picFastaOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFastaOpen.TabIndex = 25;
            this.picFastaOpen.TabStop = false;
            this.picFastaOpen.Click += new System.EventHandler(this.PicFastaOpen_Click);
            this.picFastaOpen.MouseLeave += new System.EventHandler(this.PicFastaOpen_MouseLeave);
            this.picFastaOpen.MouseHover += new System.EventHandler(this.PicFastaOpen_MouseHover);
            // 
            // panel1
            // 
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(152, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 655);
            this.panel1.TabIndex = 33;
            this.panel1.Visible = false;
            // 
            // chkAmountTaxa
            // 
            this.chkAmountTaxa.AutoSize = true;
            this.chkAmountTaxa.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAmountTaxa.Location = new System.Drawing.Point(557, 367);
            this.chkAmountTaxa.Name = "chkAmountTaxa";
            this.chkAmountTaxa.Size = new System.Drawing.Size(235, 22);
            this.chkAmountTaxa.TabIndex = 34;
            this.chkAmountTaxa.Text = "dataset contains >500 taxa";
            this.chkAmountTaxa.UseVisualStyleBackColor = true;
            // 
            // lblRunning
            // 
            this.lblRunning.AutoSize = true;
            this.lblRunning.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunning.ForeColor = System.Drawing.Color.Red;
            this.lblRunning.Location = new System.Drawing.Point(829, 547);
            this.lblRunning.Name = "lblRunning";
            this.lblRunning.Size = new System.Drawing.Size(117, 19);
            this.lblRunning.TabIndex = 36;
            this.lblRunning.Text = "Running.....";
            this.lblRunning.Visible = false;
            // 
            // chkCommand
            // 
            this.chkCommand.AutoSize = true;
            this.chkCommand.Checked = true;
            this.chkCommand.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCommand.Location = new System.Drawing.Point(480, 549);
            this.chkCommand.Name = "chkCommand";
            this.chkCommand.Size = new System.Drawing.Size(152, 19);
            this.chkCommand.TabIndex = 35;
            this.chkCommand.Text = "Show output window";
            this.chkCommand.UseVisualStyleBackColor = true;
            // 
            // RaxML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1267, 876);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblParam);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.chkThreads);
            this.Controls.Add(this.chkDefault);
            this.Controls.Add(this.chkViewTree);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnStartRaxML);
            this.Controls.Add(this.picSaveTree);
            this.Controls.Add(this.picFastaOpen);
            this.Controls.Add(this.txtThreads);
            this.Controls.Add(this.txtBootstraps);
            this.Controls.Add(this.txtRaxMLtree);
            this.Controls.Add(this.txtFastaFile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkAmountTaxa);
            this.Controls.Add(this.lblRunning);
            this.Controls.Add(this.chkCommand);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RaxML";
            this.Text = "RaxML";
            ((System.ComponentModel.ISupportInitialize)(this.picSaveTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFastaOpen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picSaveTree;
        private System.Windows.Forms.PictureBox picFastaOpen;
        private System.Windows.Forms.TextBox txtRaxMLtree;
        private System.Windows.Forms.TextBox txtFastaFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStartRaxML;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.CheckBox chkViewTree;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBootstraps;
        private System.Windows.Forms.CheckBox chkDefault;
        private System.Windows.Forms.CheckBox chkThreads;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtThreads;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblParam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkAmountTaxa;
        private System.Windows.Forms.Label lblRunning;
        private System.Windows.Forms.CheckBox chkCommand;
    }
}