namespace PhyloMain
{
    partial class Bayes
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chkInteractive = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picBayesOpen = new System.Windows.Forms.PictureBox();
            this.txtMrBayes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNewBayes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSeqLength = new System.Windows.Forms.TextBox();
            this.txtNrStrains = new System.Windows.Forms.TextBox();
            this.txtFasta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.picSaveNexus = new System.Windows.Forms.PictureBox();
            this.txtNexus = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.picFastaOpen = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picNexusOpen = new System.Windows.Forms.PictureBox();
            this.chkViewTree = new System.Windows.Forms.CheckBox();
            this.btnStartBayes = new System.Windows.Forms.Button();
            this.lblParam = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnNewCalculation = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtChains = new System.Windows.Forms.TextBox();
            this.txtGenerations = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.chkCommand = new System.Windows.Forms.CheckBox();
            this.lblRunning = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBurnin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBayesOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSaveNexus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFastaOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNexusOpen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(404, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tree build with MrBayes";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(146, 122);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.splitContainer1.Panel1.Controls.Add(this.chkInteractive);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.picBayesOpen);
            this.splitContainer1.Panel1.Controls.Add(this.txtMrBayes);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.txtNewBayes);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.txtSeqLength);
            this.splitContainer1.Panel2.Controls.Add(this.txtNrStrains);
            this.splitContainer1.Panel2.Controls.Add(this.txtFasta);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.picSaveNexus);
            this.splitContainer1.Panel2.Controls.Add(this.txtNexus);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.picFastaOpen);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.picNexusOpen);
            this.splitContainer1.Size = new System.Drawing.Size(760, 391);
            this.splitContainer1.SplitterDistance = 195;
            this.splitContainer1.TabIndex = 23;
            // 
            // chkInteractive
            // 
            this.chkInteractive.AutoSize = true;
            this.chkInteractive.Location = new System.Drawing.Point(218, 93);
            this.chkInteractive.Name = "chkInteractive";
            this.chkInteractive.Size = new System.Drawing.Size(138, 19);
            this.chkInteractive.TabIndex = 26;
            this.chkInteractive.Text = "Interactive mode";
            this.chkInteractive.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(581, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "The nexus file should contain a Bayes parameter block; otherwise use options belo" +
    "w";
            // 
            // picBayesOpen
            // 
            this.picBayesOpen.BackColor = System.Drawing.Color.Transparent;
            this.picBayesOpen.Image = global::PhyloMain.Properties.Resources.content_48;
            this.picBayesOpen.Location = new System.Drawing.Point(693, 55);
            this.picBayesOpen.Name = "picBayesOpen";
            this.picBayesOpen.Size = new System.Drawing.Size(24, 23);
            this.picBayesOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBayesOpen.TabIndex = 25;
            this.picBayesOpen.TabStop = false;
            this.picBayesOpen.Click += new System.EventHandler(this.PicBayesOpen_Click);
            this.picBayesOpen.MouseLeave += new System.EventHandler(this.PicBayesOpen_MouseLeave);
            this.picBayesOpen.MouseHover += new System.EventHandler(this.PicBayesOpen_MouseHover);
            // 
            // txtMrBayes
            // 
            this.txtMrBayes.AllowDrop = true;
            this.txtMrBayes.Location = new System.Drawing.Point(218, 55);
            this.txtMrBayes.Name = "txtMrBayes";
            this.txtMrBayes.Size = new System.Drawing.Size(469, 23);
            this.txtMrBayes.TabIndex = 24;
            this.txtMrBayes.TextChanged += new System.EventHandler(this.TxtMrBayes_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Open Bayes nexus file:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(413, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "When a fasta file is used provide the following variables:";
            // 
            // txtNewBayes
            // 
            this.txtNewBayes.Location = new System.Drawing.Point(218, 73);
            this.txtNewBayes.Name = "txtNewBayes";
            this.txtNewBayes.Size = new System.Drawing.Size(469, 23);
            this.txtNewBayes.TabIndex = 24;
            this.txtNewBayes.TextChanged += new System.EventHandler(this.TxtNewBayes_TextChanged);
            this.txtNewBayes.DoubleClick += new System.EventHandler(this.TxtNewBayes_DoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "Save Bayes nexus file:";
            // 
            // txtSeqLength
            // 
            this.txtSeqLength.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeqLength.Location = new System.Drawing.Point(421, 155);
            this.txtSeqLength.Name = "txtSeqLength";
            this.txtSeqLength.Size = new System.Drawing.Size(50, 23);
            this.txtSeqLength.TabIndex = 24;
            this.txtSeqLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNrStrains
            // 
            this.txtNrStrains.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNrStrains.Location = new System.Drawing.Point(186, 154);
            this.txtNrStrains.Name = "txtNrStrains";
            this.txtNrStrains.Size = new System.Drawing.Size(50, 23);
            this.txtNrStrains.TabIndex = 24;
            this.txtNrStrains.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFasta
            // 
            this.txtFasta.AllowDrop = true;
            this.txtFasta.Location = new System.Drawing.Point(218, 44);
            this.txtFasta.Name = "txtFasta";
            this.txtFasta.Size = new System.Drawing.Size(469, 23);
            this.txtFasta.TabIndex = 24;
            this.txtFasta.TextChanged += new System.EventHandler(this.TxtFasta_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "Open Fasta file:";
            // 
            // picSaveNexus
            // 
            this.picSaveNexus.BackColor = System.Drawing.Color.Transparent;
            this.picSaveNexus.Image = global::PhyloMain.Properties.Resources.content_48;
            this.picSaveNexus.Location = new System.Drawing.Point(693, 73);
            this.picSaveNexus.Name = "picSaveNexus";
            this.picSaveNexus.Size = new System.Drawing.Size(24, 23);
            this.picSaveNexus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSaveNexus.TabIndex = 25;
            this.picSaveNexus.TabStop = false;
            this.picSaveNexus.Click += new System.EventHandler(this.PicSaveNexus_Click);
            this.picSaveNexus.MouseLeave += new System.EventHandler(this.PicSaveNexus_MouseLeave);
            this.picSaveNexus.MouseHover += new System.EventHandler(this.PicSaveNexus_MouseHover);
            // 
            // txtNexus
            // 
            this.txtNexus.AllowDrop = true;
            this.txtNexus.Location = new System.Drawing.Point(218, 15);
            this.txtNexus.Name = "txtNexus";
            this.txtNexus.Size = new System.Drawing.Size(469, 23);
            this.txtNexus.TabIndex = 24;
            this.txtNexus.TextChanged += new System.EventHandler(this.TxtNexus_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(279, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 18);
            this.label9.TabIndex = 23;
            this.label9.Text = "Sequence length:";
            // 
            // picFastaOpen
            // 
            this.picFastaOpen.BackColor = System.Drawing.Color.Transparent;
            this.picFastaOpen.Image = global::PhyloMain.Properties.Resources.content_48;
            this.picFastaOpen.Location = new System.Drawing.Point(693, 44);
            this.picFastaOpen.Name = "picFastaOpen";
            this.picFastaOpen.Size = new System.Drawing.Size(24, 23);
            this.picFastaOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFastaOpen.TabIndex = 25;
            this.picFastaOpen.TabStop = false;
            this.picFastaOpen.Click += new System.EventHandler(this.PicFastaOpen_Click);
            this.picFastaOpen.MouseLeave += new System.EventHandler(this.PicFastaOpen_MouseLeave);
            this.picFastaOpen.MouseHover += new System.EventHandler(this.PicFastaOpen_MouseHover);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 18);
            this.label8.TabIndex = 23;
            this.label8.Text = "Number of strains:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Open Nexus file:";
            // 
            // picNexusOpen
            // 
            this.picNexusOpen.BackColor = System.Drawing.Color.Transparent;
            this.picNexusOpen.Image = global::PhyloMain.Properties.Resources.content_48;
            this.picNexusOpen.Location = new System.Drawing.Point(693, 15);
            this.picNexusOpen.Name = "picNexusOpen";
            this.picNexusOpen.Size = new System.Drawing.Size(24, 23);
            this.picNexusOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNexusOpen.TabIndex = 25;
            this.picNexusOpen.TabStop = false;
            this.picNexusOpen.Click += new System.EventHandler(this.PicNexusOpen_Click);
            this.picNexusOpen.MouseLeave += new System.EventHandler(this.PicNexusOpen_MouseLeave);
            this.picNexusOpen.MouseHover += new System.EventHandler(this.PicNexusOpen_MouseHover);
            // 
            // chkViewTree
            // 
            this.chkViewTree.AutoSize = true;
            this.chkViewTree.Location = new System.Drawing.Point(364, 648);
            this.chkViewTree.Name = "chkViewTree";
            this.chkViewTree.Size = new System.Drawing.Size(166, 19);
            this.chkViewTree.TabIndex = 26;
            this.chkViewTree.Text = "View tree in FigTree";
            this.chkViewTree.UseVisualStyleBackColor = true;
            // 
            // btnStartBayes
            // 
            this.btnStartBayes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnStartBayes.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartBayes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnStartBayes.Location = new System.Drawing.Point(364, 606);
            this.btnStartBayes.Name = "btnStartBayes";
            this.btnStartBayes.Size = new System.Drawing.Size(172, 34);
            this.btnStartBayes.TabIndex = 27;
            this.btnStartBayes.Text = "Start MrBayes";
            this.btnStartBayes.UseVisualStyleBackColor = false;
            this.btnStartBayes.Click += new System.EventHandler(this.BtnStartBayes_Click);
            // 
            // lblParam
            // 
            this.lblParam.AutoSize = true;
            this.lblParam.Location = new System.Drawing.Point(32, 776);
            this.lblParam.Name = "lblParam";
            this.lblParam.Size = new System.Drawing.Size(133, 15);
            this.lblParam.TabIndex = 24;
            this.lblParam.Text = "parameters visible";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnNewCalculation
            // 
            this.btnNewCalculation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnNewCalculation.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCalculation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNewCalculation.Location = new System.Drawing.Point(603, 606);
            this.btnNewCalculation.Name = "btnNewCalculation";
            this.btnNewCalculation.Size = new System.Drawing.Size(172, 34);
            this.btnNewCalculation.TabIndex = 27;
            this.btnNewCalculation.Text = "New calculation";
            this.btnNewCalculation.UseVisualStyleBackColor = false;
            this.btnNewCalculation.Click += new System.EventHandler(this.BtnNewCalculation_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(184, 532);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 18);
            this.label10.TabIndex = 23;
            this.label10.Text = "Number of chains:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(405, 532);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(184, 18);
            this.label11.TabIndex = 23;
            this.label11.Text = "Number of generations:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(146, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 652);
            this.panel1.TabIndex = 28;
            this.panel1.Visible = false;
            // 
            // txtChains
            // 
            this.txtChains.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChains.Location = new System.Drawing.Point(333, 529);
            this.txtChains.Name = "txtChains";
            this.txtChains.Size = new System.Drawing.Size(42, 25);
            this.txtChains.TabIndex = 24;
            this.txtChains.Text = "4";
            // 
            // txtGenerations
            // 
            this.txtGenerations.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenerations.Location = new System.Drawing.Point(595, 529);
            this.txtGenerations.Name = "txtGenerations";
            this.txtGenerations.Size = new System.Drawing.Size(42, 25);
            this.txtGenerations.TabIndex = 24;
            this.txtGenerations.Text = "1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(639, 532);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 18);
            this.label12.TabIndex = 23;
            this.label12.Text = "million";
            // 
            // chkCommand
            // 
            this.chkCommand.AutoSize = true;
            this.chkCommand.Checked = true;
            this.chkCommand.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCommand.Location = new System.Drawing.Point(365, 673);
            this.chkCommand.Name = "chkCommand";
            this.chkCommand.Size = new System.Drawing.Size(152, 19);
            this.chkCommand.TabIndex = 29;
            this.chkCommand.Text = "Show output window";
            this.chkCommand.UseVisualStyleBackColor = true;
            // 
            // lblRunning
            // 
            this.lblRunning.AutoSize = true;
            this.lblRunning.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunning.ForeColor = System.Drawing.Color.Red;
            this.lblRunning.Location = new System.Drawing.Point(599, 671);
            this.lblRunning.Name = "lblRunning";
            this.lblRunning.Size = new System.Drawing.Size(117, 19);
            this.lblRunning.TabIndex = 30;
            this.lblRunning.Text = "Running.....";
            this.lblRunning.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(720, 532);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 18);
            this.label13.TabIndex = 23;
            this.label13.Text = "burnin fraction: ";
            // 
            // txtBurnin
            // 
            this.txtBurnin.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBurnin.Location = new System.Drawing.Point(864, 529);
            this.txtBurnin.Name = "txtBurnin";
            this.txtBurnin.Size = new System.Drawing.Size(42, 25);
            this.txtBurnin.TabIndex = 24;
            this.txtBurnin.Text = "0.25";
            this.txtBurnin.Leave += new System.EventHandler(this.txtBurnin_Leave);
            // 
            // Bayes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1251, 837);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblParam);
            this.Controls.Add(this.chkViewTree);
            this.Controls.Add(this.txtBurnin);
            this.Controls.Add(this.txtGenerations);
            this.Controls.Add(this.txtChains);
            this.Controls.Add(this.btnNewCalculation);
            this.Controls.Add(this.btnStartBayes);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRunning);
            this.Controls.Add(this.chkCommand);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Bayes";
            this.Text = "Bayes";
            this.Load += new System.EventHandler(this.Bayes_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBayesOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSaveNexus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFastaOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNexusOpen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnStartBayes;
        private System.Windows.Forms.CheckBox chkViewTree;
        private System.Windows.Forms.PictureBox picBayesOpen;
        private System.Windows.Forms.TextBox txtMrBayes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblParam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNewBayes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSeqLength;
        private System.Windows.Forms.TextBox txtNrStrains;
        private System.Windows.Forms.TextBox txtFasta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picSaveNexus;
        private System.Windows.Forms.TextBox txtNexus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox picFastaOpen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picNexusOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnNewCalculation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkInteractive;
        private System.Windows.Forms.TextBox txtChains;
        private System.Windows.Forms.TextBox txtGenerations;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox chkCommand;
        private System.Windows.Forms.Label lblRunning;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBurnin;
    }
}