namespace PhyloMain
{
    partial class MafftFF
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDirectoryPath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.picView = new System.Windows.Forms.PictureBox();
            this.picFtree = new System.Windows.Forms.PictureBox();
            this.picAlign = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnDirectoryPath = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.lblChoice = new System.Windows.Forms.Label();
            this.chkCommand = new System.Windows.Forms.CheckBox();
            this.lblRunning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFtree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDirectoryPath)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.LightGreen;
            this.treeView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.treeView1.FullRowSelect = true;
            this.treeView1.Location = new System.Drawing.Point(39, 72);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(390, 711);
            this.treeView1.TabIndex = 0;
            this.treeView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.TreeView1_ItemDrag);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            this.treeView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TreeView1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select directory";
            // 
            // txtDirectoryPath
            // 
            this.txtDirectoryPath.Location = new System.Drawing.Point(39, 46);
            this.txtDirectoryPath.Name = "txtDirectoryPath";
            this.txtDirectoryPath.Size = new System.Drawing.Size(358, 23);
            this.txtDirectoryPath.TabIndex = 2;
            this.txtDirectoryPath.TextChanged += new System.EventHandler(this.TxtDirectoryPath_TextChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(39, 789);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(390, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 5;
            // 
            // picView
            // 
            this.picView.Cursor = System.Windows.Forms.Cursors.No;
            this.picView.Image = global::PhyloMain.Properties.Resources.tree;
            this.picView.Location = new System.Drawing.Point(687, 220);
            this.picView.Name = "picView";
            this.picView.Size = new System.Drawing.Size(30, 32);
            this.picView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picView.TabIndex = 7;
            this.picView.TabStop = false;
            this.toolTip1.SetToolTip(this.picView, "View");
            this.picView.Visible = false;
            // 
            // picFtree
            // 
            this.picFtree.Cursor = System.Windows.Forms.Cursors.No;
            this.picFtree.Image = global::PhyloMain.Properties.Resources.network;
            this.picFtree.Location = new System.Drawing.Point(596, 220);
            this.picFtree.Name = "picFtree";
            this.picFtree.Size = new System.Drawing.Size(30, 32);
            this.picFtree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFtree.TabIndex = 7;
            this.picFtree.TabStop = false;
            this.toolTip1.SetToolTip(this.picFtree, "Build");
            this.picFtree.Visible = false;
            // 
            // picAlign
            // 
            this.picAlign.Cursor = System.Windows.Forms.Cursors.No;
            this.picAlign.Image = global::PhyloMain.Properties.Resources.application_form_edit;
            this.picAlign.Location = new System.Drawing.Point(495, 220);
            this.picAlign.Name = "picAlign";
            this.picAlign.Size = new System.Drawing.Size(32, 32);
            this.picAlign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picAlign.TabIndex = 7;
            this.picAlign.TabStop = false;
            this.picAlign.Tag = "";
            this.picAlign.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Location = new System.Drawing.Point(477, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(471, 23);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.textBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBox1_DragDrop);
            this.textBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.TextBox1_DragEnter);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(446, 268);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 544);
            this.panel1.TabIndex = 8;
            this.panel1.Visible = false;
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRun.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.ForeColor = System.Drawing.Color.MintCream;
            this.btnRun.Location = new System.Drawing.Point(645, 123);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(179, 42);
            this.btnRun.TabIndex = 9;
            this.btnRun.Text = "Execute Flowchart";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // btnDirectoryPath
            // 
            this.btnDirectoryPath.Image = global::PhyloMain.Properties.Resources.content_48;
            this.btnDirectoryPath.Location = new System.Drawing.Point(403, 46);
            this.btnDirectoryPath.Name = "btnDirectoryPath";
            this.btnDirectoryPath.Size = new System.Drawing.Size(26, 23);
            this.btnDirectoryPath.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDirectoryPath.TabIndex = 3;
            this.btnDirectoryPath.TabStop = false;
            this.btnDirectoryPath.Click += new System.EventHandler(this.BtnDirectoryPath_Click);
            this.btnDirectoryPath.MouseLeave += new System.EventHandler(this.BtnDirectoryPath_MouseLeave);
            this.btnDirectoryPath.MouseHover += new System.EventHandler(this.BtnDirectoryPath_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(474, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current file";
            // 
            // lblChoice
            // 
            this.lblChoice.AutoSize = true;
            this.lblChoice.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoice.Location = new System.Drawing.Point(676, 23);
            this.lblChoice.Name = "lblChoice";
            this.lblChoice.Size = new System.Drawing.Size(100, 22);
            this.lblChoice.TabIndex = 10;
            this.lblChoice.Text = "Flowchart";
            // 
            // chkCommand
            // 
            this.chkCommand.AutoSize = true;
            this.chkCommand.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCommand.Location = new System.Drawing.Point(645, 172);
            this.chkCommand.Name = "chkCommand";
            this.chkCommand.Size = new System.Drawing.Size(179, 22);
            this.chkCommand.TabIndex = 11;
            this.chkCommand.Text = "Show command window";
            this.chkCommand.UseVisualStyleBackColor = true;
            // 
            // lblRunning
            // 
            this.lblRunning.AutoSize = true;
            this.lblRunning.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunning.ForeColor = System.Drawing.Color.Red;
            this.lblRunning.Location = new System.Drawing.Point(831, 233);
            this.lblRunning.Name = "lblRunning";
            this.lblRunning.Size = new System.Drawing.Size(117, 19);
            this.lblRunning.TabIndex = 33;
            this.lblRunning.Text = "Running.....";
            this.lblRunning.Visible = false;
            // 
            // MafftFF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1251, 837);
            this.Controls.Add(this.lblRunning);
            this.Controls.Add(this.chkCommand);
            this.Controls.Add(this.lblChoice);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picView);
            this.Controls.Add(this.picFtree);
            this.Controls.Add(this.picAlign);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnDirectoryPath);
            this.Controls.Add(this.txtDirectoryPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MafftFF";
            this.Text = "MafftFF";
            ((System.ComponentModel.ISupportInitialize)(this.picView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFtree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDirectoryPath)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDirectoryPath;
        private System.Windows.Forms.PictureBox btnDirectoryPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox picAlign;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.PictureBox picFtree;
        private System.Windows.Forms.PictureBox picView;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblChoice;
        private System.Windows.Forms.CheckBox chkCommand;
        private System.Windows.Forms.Label lblRunning;
    }
}