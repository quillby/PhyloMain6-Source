namespace PhyloMain
{
    partial class PhyloMain
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Assign programs");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("EXIT PhyloMain");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Disclaimer");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Application", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Start alignment");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Export selection");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Likelihood analysis");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Merge sequence files");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Convert sequence format");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Alignment", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Create IQ-tree");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Run RaxML");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Start MrBayes");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("FastTree");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Build tree", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Open existing tree");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("View tree", new System.Windows.Forms.TreeNode[] {
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("SequenceMatrix");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Similarity/Identity");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("DnaSP->PopArt");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Start PaupUp");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Start SATé");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("GBlocks");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Tools", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("1-Click");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Create partition file");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Partition", new System.Windows.Forms.TreeNode[] {
            treeNode26});
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Change strain label");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Genbank search");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("MAFFT-FastTree-FigTree");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("MAFFT-IQtree-FigTree");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Muscle-FastTree-FigTree");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Muscle-IQtree-FigTree");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Flowchart", new System.Windows.Forms.TreeNode[] {
            treeNode30,
            treeNode31,
            treeNode32,
            treeNode33});
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Create canu cmd line");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhyloMain));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.Header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Header.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.treeView1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.treeView1.Location = new System.Drawing.Point(0, 67);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Assign programs";
            treeNode2.Name = "Node3";
            treeNode2.Text = "EXIT PhyloMain";
            treeNode3.Name = "Node36";
            treeNode3.Text = "Disclaimer";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Application";
            treeNode5.Name = "Node5";
            treeNode5.Text = "Start alignment";
            treeNode6.Name = "Node6";
            treeNode6.Text = "Export selection";
            treeNode7.Name = "Node7";
            treeNode7.Text = "Likelihood analysis";
            treeNode8.Name = "Node8";
            treeNode8.Text = "Merge sequence files";
            treeNode9.Name = "Node9";
            treeNode9.Text = "Convert sequence format";
            treeNode10.Name = "Node4";
            treeNode10.Text = "Alignment";
            treeNode11.Name = "Node11";
            treeNode11.Text = "Create IQ-tree";
            treeNode12.Name = "Node12";
            treeNode12.Text = "Run RaxML";
            treeNode13.Name = "Node13";
            treeNode13.Text = "Start MrBayes";
            treeNode14.Name = "Node14";
            treeNode14.Text = "FastTree";
            treeNode15.Name = "Node10";
            treeNode15.Text = "Build tree";
            treeNode16.Name = "Node16";
            treeNode16.Text = "Open existing tree";
            treeNode17.Name = "Node15";
            treeNode17.Text = "View tree";
            treeNode18.Name = "Node18";
            treeNode18.Text = "SequenceMatrix";
            treeNode19.Name = "Node19";
            treeNode19.Text = "Similarity/Identity";
            treeNode20.Name = "Node20";
            treeNode20.Text = "DnaSP->PopArt";
            treeNode21.Name = "Node21";
            treeNode21.Text = "Start PaupUp";
            treeNode22.Name = "Node22";
            treeNode22.Text = "Start SATé";
            treeNode23.Name = "Node29";
            treeNode23.Text = "GBlocks";
            treeNode24.Name = "Node17";
            treeNode24.Text = "Tools";
            treeNode25.Name = "Node23";
            treeNode25.Text = "1-Click";
            treeNode26.Name = "Node25";
            treeNode26.Text = "Create partition file";
            treeNode27.Name = "Node24";
            treeNode27.Text = "Partition";
            treeNode28.Name = "Node27";
            treeNode28.Text = "Change strain label";
            treeNode29.Name = "Node28";
            treeNode29.Text = "Genbank search";
            treeNode30.Name = "Node31";
            treeNode30.Text = "MAFFT-FastTree-FigTree";
            treeNode31.Name = "Node32";
            treeNode31.Text = "MAFFT-IQtree-FigTree";
            treeNode32.Name = "Node33";
            treeNode32.Text = "Muscle-FastTree-FigTree";
            treeNode33.Name = "Node34";
            treeNode33.Text = "Muscle-IQtree-FigTree";
            treeNode34.Name = "Node30";
            treeNode34.Text = "Flowchart";
            treeNode35.Name = "Node35";
            treeNode35.Text = "Create canu cmd line";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode10,
            treeNode15,
            treeNode17,
            treeNode24,
            treeNode25,
            treeNode27,
            treeNode28,
            treeNode29,
            treeNode34,
            treeNode35});
            this.treeView1.Size = new System.Drawing.Size(218, 874);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Header.Controls.Add(this.pictureBox2);
            this.Header.Controls.Add(this.label1);
            this.Header.Controls.Add(this.pictureBox1);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1484, 66);
            this.Header.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(505, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(579, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phylogenetics with PhyloMain";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = global::PhyloMain.Properties.Resources.Tree_3;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(217, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1267, 876);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1016, 850);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "c2019 - Bert Gerrits van den Ende";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::PhyloMain.Properties.Resources.shutdown;
            this.pictureBox2.Location = new System.Drawing.Point(1432, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.PictureBox2_MouseLeave);
            this.pictureBox2.MouseHover += new System.EventHandler(this.PictureBox2_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PhyloMain.Properties.Resources.tree;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PhyloMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 941);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.treeView1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1500, 980);
            this.MinimumSize = new System.Drawing.Size(1500, 980);
            this.Name = "PhyloMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhyloMain";
            this.Load += new System.EventHandler(this.PhyloMain_Load);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}

