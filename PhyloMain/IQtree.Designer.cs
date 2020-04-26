namespace PhyloMain
{
    partial class IQtree
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picPartitionFile = new System.Windows.Forms.PictureBox();
            this.txtPartition = new System.Windows.Forms.TextBox();
            this.chkNNI = new System.Windows.Forms.CheckBox();
            this.chkBranch = new System.Windows.Forms.CheckBox();
            this.chkTest = new System.Windows.Forms.CheckBox();
            this.chkShort = new System.Windows.Forms.CheckBox();
            this.chkModel = new System.Windows.Forms.CheckBox();
            this.chkPartition = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNonBS = new System.Windows.Forms.TextBox();
            this.txtBootstraps = new System.Windows.Forms.TextBox();
            this.txtLRTiterations = new System.Windows.Forms.TextBox();
            this.txtMaxIterations = new System.Windows.Forms.TextBox();
            this.chkBayes = new System.Windows.Forms.CheckBox();
            this.chkNonBS = new System.Windows.Forms.CheckBox();
            this.chkBootstraps = new System.Windows.Forms.CheckBox();
            this.chkLRT = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboModels = new System.Windows.Forms.ComboBox();
            this.chkSubstitution = new System.Windows.Forms.CheckBox();
            this.rdbBIC = new System.Windows.Forms.RadioButton();
            this.rdbAICc = new System.Windows.Forms.RadioButton();
            this.rdbAIC = new System.Windows.Forms.RadioButton();
            this.chkViewTree = new System.Windows.Forms.CheckBox();
            this.txtIQtree = new System.Windows.Forms.TextBox();
            this.txtFastaFile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStartIQ = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblParam = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picSaveTree = new System.Windows.Forms.PictureBox();
            this.picFastaOpen = new System.Windows.Forms.PictureBox();
            this.lblRunning = new System.Windows.Forms.Label();
            this.chkCommand = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPartitionFile)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSaveTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFastaOpen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(470, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tree build with IQ-tree";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picPartitionFile);
            this.groupBox1.Controls.Add(this.txtPartition);
            this.groupBox1.Controls.Add(this.chkNNI);
            this.groupBox1.Controls.Add(this.chkBranch);
            this.groupBox1.Controls.Add(this.chkTest);
            this.groupBox1.Controls.Add(this.chkShort);
            this.groupBox1.Controls.Add(this.chkModel);
            this.groupBox1.Controls.Add(this.chkPartition);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(300, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 327);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tree building parameters";
            // 
            // picPartitionFile
            // 
            this.picPartitionFile.BackColor = System.Drawing.Color.Transparent;
            this.picPartitionFile.Image = global::PhyloMain.Properties.Resources.content_48;
            this.picPartitionFile.Location = new System.Drawing.Point(533, 219);
            this.picPartitionFile.Name = "picPartitionFile";
            this.picPartitionFile.Size = new System.Drawing.Size(24, 23);
            this.picPartitionFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPartitionFile.TabIndex = 24;
            this.picPartitionFile.TabStop = false;
            this.picPartitionFile.Click += new System.EventHandler(this.PicPartitionFile_Click);
            // 
            // txtPartition
            // 
            this.txtPartition.Location = new System.Drawing.Point(247, 219);
            this.txtPartition.Name = "txtPartition";
            this.txtPartition.ReadOnly = true;
            this.txtPartition.Size = new System.Drawing.Size(280, 23);
            this.txtPartition.TabIndex = 4;
            // 
            // chkNNI
            // 
            this.chkNNI.AutoSize = true;
            this.chkNNI.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNNI.Location = new System.Drawing.Point(242, 296);
            this.chkNNI.Name = "chkNNI";
            this.chkNNI.Size = new System.Drawing.Size(243, 19);
            this.chkNNI.TabIndex = 3;
            this.chkNNI.Text = "Thorough NNI search (very slow)";
            this.chkNNI.UseVisualStyleBackColor = true;
            // 
            // chkBranch
            // 
            this.chkBranch.AutoSize = true;
            this.chkBranch.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBranch.Location = new System.Drawing.Point(242, 271);
            this.chkBranch.Name = "chkBranch";
            this.chkBranch.Size = new System.Drawing.Size(285, 19);
            this.chkBranch.TabIndex = 3;
            this.chkBranch.Text = "Prevent overestimating branch support";
            this.chkBranch.UseVisualStyleBackColor = true;
            // 
            // chkTest
            // 
            this.chkTest.AutoSize = true;
            this.chkTest.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTest.Location = new System.Drawing.Point(32, 296);
            this.chkTest.Name = "chkTest";
            this.chkTest.Size = new System.Drawing.Size(145, 19);
            this.chkTest.TabIndex = 3;
            this.chkTest.Text = "wSH- and wKH-test";
            this.chkTest.UseVisualStyleBackColor = true;
            // 
            // chkShort
            // 
            this.chkShort.AutoSize = true;
            this.chkShort.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShort.Location = new System.Drawing.Point(32, 271);
            this.chkShort.Name = "chkShort";
            this.chkShort.Size = new System.Drawing.Size(187, 19);
            this.chkShort.TabIndex = 3;
            this.chkShort.Text = "Short sequences present";
            this.chkShort.UseVisualStyleBackColor = true;
            // 
            // chkModel
            // 
            this.chkModel.AutoSize = true;
            this.chkModel.Enabled = false;
            this.chkModel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkModel.Location = new System.Drawing.Point(32, 246);
            this.chkModel.Name = "chkModel";
            this.chkModel.Size = new System.Drawing.Size(208, 19);
            this.chkModel.TabIndex = 3;
            this.chkModel.Text = "Contains model definitions";
            this.chkModel.UseVisualStyleBackColor = true;
            // 
            // chkPartition
            // 
            this.chkPartition.AutoSize = true;
            this.chkPartition.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPartition.Location = new System.Drawing.Point(32, 221);
            this.chkPartition.Name = "chkPartition";
            this.chkPartition.Size = new System.Drawing.Size(208, 19);
            this.chkPartition.TabIndex = 3;
            this.chkPartition.Text = "Use partition file (nexus)";
            this.chkPartition.UseVisualStyleBackColor = true;
            this.chkPartition.CheckedChanged += new System.EventHandler(this.ChkPartition_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox3.Controls.Add(this.txtNonBS);
            this.groupBox3.Controls.Add(this.txtBootstraps);
            this.groupBox3.Controls.Add(this.txtLRTiterations);
            this.groupBox3.Controls.Add(this.txtMaxIterations);
            this.groupBox3.Controls.Add(this.chkBayes);
            this.groupBox3.Controls.Add(this.chkNonBS);
            this.groupBox3.Controls.Add(this.chkBootstraps);
            this.groupBox3.Controls.Add(this.chkLRT);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(219, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 167);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "IQ-tree parameters";
            // 
            // txtNonBS
            // 
            this.txtNonBS.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNonBS.Location = new System.Drawing.Point(164, 104);
            this.txtNonBS.Name = "txtNonBS";
            this.txtNonBS.Size = new System.Drawing.Size(54, 23);
            this.txtNonBS.TabIndex = 16;
            this.txtNonBS.Text = "100";
            // 
            // txtBootstraps
            // 
            this.txtBootstraps.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBootstraps.Location = new System.Drawing.Point(164, 77);
            this.txtBootstraps.Name = "txtBootstraps";
            this.txtBootstraps.Size = new System.Drawing.Size(54, 23);
            this.txtBootstraps.TabIndex = 16;
            this.txtBootstraps.Text = "1000";
            // 
            // txtLRTiterations
            // 
            this.txtLRTiterations.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLRTiterations.Location = new System.Drawing.Point(164, 51);
            this.txtLRTiterations.Name = "txtLRTiterations";
            this.txtLRTiterations.Size = new System.Drawing.Size(54, 23);
            this.txtLRTiterations.TabIndex = 16;
            this.txtLRTiterations.Text = "1000";
            // 
            // txtMaxIterations
            // 
            this.txtMaxIterations.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxIterations.Location = new System.Drawing.Point(164, 25);
            this.txtMaxIterations.Name = "txtMaxIterations";
            this.txtMaxIterations.Size = new System.Drawing.Size(54, 23);
            this.txtMaxIterations.TabIndex = 16;
            this.txtMaxIterations.Text = "1000";
            // 
            // chkBayes
            // 
            this.chkBayes.AutoSize = true;
            this.chkBayes.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBayes.Location = new System.Drawing.Point(9, 131);
            this.chkBayes.Name = "chkBayes";
            this.chkBayes.Size = new System.Drawing.Size(152, 19);
            this.chkBayes.TabIndex = 15;
            this.chkBayes.Text = "Bayesian inference";
            this.chkBayes.UseVisualStyleBackColor = true;
            // 
            // chkNonBS
            // 
            this.chkNonBS.AutoSize = true;
            this.chkNonBS.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNonBS.Location = new System.Drawing.Point(9, 106);
            this.chkNonBS.Name = "chkNonBS";
            this.chkNonBS.Size = new System.Drawing.Size(110, 19);
            this.chkNonBS.TabIndex = 15;
            this.chkNonBS.Text = "Nonparam BS:";
            this.chkNonBS.UseVisualStyleBackColor = true;
            this.chkNonBS.CheckedChanged += new System.EventHandler(this.ChkNonBS_CheckedChanged);
            // 
            // chkBootstraps
            // 
            this.chkBootstraps.AutoSize = true;
            this.chkBootstraps.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBootstraps.Location = new System.Drawing.Point(9, 81);
            this.chkBootstraps.Name = "chkBootstraps";
            this.chkBootstraps.Size = new System.Drawing.Size(103, 19);
            this.chkBootstraps.TabIndex = 15;
            this.chkBootstraps.Text = "Bootstraps:";
            this.chkBootstraps.UseVisualStyleBackColor = true;
            this.chkBootstraps.CheckedChanged += new System.EventHandler(this.ChkBootstraps_CheckedChanged);
            // 
            // chkLRT
            // 
            this.chkLRT.AutoSize = true;
            this.chkLRT.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLRT.Location = new System.Drawing.Point(9, 56);
            this.chkLRT.Name = "chkLRT";
            this.chkLRT.Size = new System.Drawing.Size(138, 19);
            this.chkLRT.TabIndex = 15;
            this.chkLRT.Text = "aLRT iterations:";
            this.chkLRT.UseVisualStyleBackColor = true;
            this.chkLRT.CheckedChanged += new System.EventHandler(this.ChkLRT_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Max. iterations: ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.cboModels);
            this.groupBox2.Controls.Add(this.chkSubstitution);
            this.groupBox2.Controls.Add(this.rdbBIC);
            this.groupBox2.Controls.Add(this.rdbAICc);
            this.groupBox2.Controls.Add(this.rdbAIC);
            this.groupBox2.Location = new System.Drawing.Point(19, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(171, 167);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Model criterion";
            // 
            // cboModels
            // 
            this.cboModels.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboModels.FormattingEnabled = true;
            this.cboModels.Items.AddRange(new object[] {
            "JC",
            "F81",
            "K81",
            "HKY",
            "TN",
            "TPM",
            "TIM",
            "TVM",
            "SYM",
            "GTR"});
            this.cboModels.Location = new System.Drawing.Point(67, 131);
            this.cboModels.Name = "cboModels";
            this.cboModels.Size = new System.Drawing.Size(91, 23);
            this.cboModels.TabIndex = 2;
            this.cboModels.Text = "JC";
            // 
            // chkSubstitution
            // 
            this.chkSubstitution.AutoSize = true;
            this.chkSubstitution.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSubstitution.Location = new System.Drawing.Point(13, 106);
            this.chkSubstitution.Name = "chkSubstitution";
            this.chkSubstitution.Size = new System.Drawing.Size(152, 19);
            this.chkSubstitution.TabIndex = 1;
            this.chkSubstitution.Text = "Substitution model";
            this.chkSubstitution.UseVisualStyleBackColor = true;
            this.chkSubstitution.CheckedChanged += new System.EventHandler(this.ChkSubstitution_CheckedChanged);
            // 
            // rdbBIC
            // 
            this.rdbBIC.AutoSize = true;
            this.rdbBIC.Checked = true;
            this.rdbBIC.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbBIC.Location = new System.Drawing.Point(13, 78);
            this.rdbBIC.Name = "rdbBIC";
            this.rdbBIC.Size = new System.Drawing.Size(46, 19);
            this.rdbBIC.TabIndex = 0;
            this.rdbBIC.TabStop = true;
            this.rdbBIC.Text = "BIC";
            this.rdbBIC.UseVisualStyleBackColor = true;
            // 
            // rdbAICc
            // 
            this.rdbAICc.AutoSize = true;
            this.rdbAICc.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAICc.Location = new System.Drawing.Point(13, 52);
            this.rdbAICc.Name = "rdbAICc";
            this.rdbAICc.Size = new System.Drawing.Size(53, 19);
            this.rdbAICc.TabIndex = 0;
            this.rdbAICc.Text = "AICc";
            this.rdbAICc.UseVisualStyleBackColor = true;
            // 
            // rdbAIC
            // 
            this.rdbAIC.AutoSize = true;
            this.rdbAIC.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAIC.Location = new System.Drawing.Point(13, 27);
            this.rdbAIC.Name = "rdbAIC";
            this.rdbAIC.Size = new System.Drawing.Size(46, 19);
            this.rdbAIC.TabIndex = 0;
            this.rdbAIC.Text = "AIC";
            this.rdbAIC.UseVisualStyleBackColor = true;
            // 
            // chkViewTree
            // 
            this.chkViewTree.AutoSize = true;
            this.chkViewTree.Location = new System.Drawing.Point(468, 684);
            this.chkViewTree.Name = "chkViewTree";
            this.chkViewTree.Size = new System.Drawing.Size(166, 19);
            this.chkViewTree.TabIndex = 2;
            this.chkViewTree.Text = "View tree in FigTree";
            this.chkViewTree.UseVisualStyleBackColor = true;
            // 
            // txtIQtree
            // 
            this.txtIQtree.Location = new System.Drawing.Point(464, 600);
            this.txtIQtree.Name = "txtIQtree";
            this.txtIQtree.Size = new System.Drawing.Size(469, 23);
            this.txtIQtree.TabIndex = 16;
            this.txtIQtree.TextChanged += new System.EventHandler(this.TxtIQtree_TextChanged);
            this.txtIQtree.DoubleClick += new System.EventHandler(this.TxtIQtree_DoubleClick);
            // 
            // txtFastaFile
            // 
            this.txtFastaFile.AllowDrop = true;
            this.txtFastaFile.Location = new System.Drawing.Point(464, 558);
            this.txtFastaFile.Name = "txtFastaFile";
            this.txtFastaFile.Size = new System.Drawing.Size(469, 23);
            this.txtFastaFile.TabIndex = 17;
            this.txtFastaFile.TextChanged += new System.EventHandler(this.TxtFastaFile_TextChanged);
            this.txtFastaFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.TxtFastaFile_DragDrop);
            this.txtFastaFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxtFastaFile_DragEnter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(323, 603);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Save IQ-tree As:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(331, 559);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Open alignment:";
            // 
            // btnStartIQ
            // 
            this.btnStartIQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnStartIQ.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartIQ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnStartIQ.Location = new System.Drawing.Point(464, 644);
            this.btnStartIQ.Name = "btnStartIQ";
            this.btnStartIQ.Size = new System.Drawing.Size(172, 34);
            this.btnStartIQ.TabIndex = 21;
            this.btnStartIQ.Text = "Build tree";
            this.btnStartIQ.UseVisualStyleBackColor = false;
            this.btnStartIQ.Click += new System.EventHandler(this.BtnStartIQ_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnNew.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNew.Location = new System.Drawing.Point(718, 644);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(172, 34);
            this.btnNew.TabIndex = 21;
            this.btnNew.Text = "New calculation";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // lblParam
            // 
            this.lblParam.AutoSize = true;
            this.lblParam.Location = new System.Drawing.Point(32, 812);
            this.lblParam.Name = "lblParam";
            this.lblParam.Size = new System.Drawing.Size(133, 15);
            this.lblParam.TabIndex = 23;
            this.lblParam.Text = "parameters visible";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(148, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 427);
            this.panel1.TabIndex = 24;
            this.panel1.Visible = false;
            // 
            // picSaveTree
            // 
            this.picSaveTree.BackColor = System.Drawing.Color.Transparent;
            this.picSaveTree.Image = global::PhyloMain.Properties.Resources.content_48;
            this.picSaveTree.Location = new System.Drawing.Point(939, 600);
            this.picSaveTree.Name = "picSaveTree";
            this.picSaveTree.Size = new System.Drawing.Size(24, 23);
            this.picSaveTree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSaveTree.TabIndex = 18;
            this.picSaveTree.TabStop = false;
            this.picSaveTree.Click += new System.EventHandler(this.PicSaveTree_Click);
            this.picSaveTree.MouseLeave += new System.EventHandler(this.PicSaveTree_MouseLeave);
            this.picSaveTree.MouseHover += new System.EventHandler(this.PicSaveTree_MouseHover);
            // 
            // picFastaOpen
            // 
            this.picFastaOpen.BackColor = System.Drawing.Color.Transparent;
            this.picFastaOpen.Image = global::PhyloMain.Properties.Resources.content_48;
            this.picFastaOpen.Location = new System.Drawing.Point(939, 558);
            this.picFastaOpen.Name = "picFastaOpen";
            this.picFastaOpen.Size = new System.Drawing.Size(24, 23);
            this.picFastaOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFastaOpen.TabIndex = 19;
            this.picFastaOpen.TabStop = false;
            this.picFastaOpen.Click += new System.EventHandler(this.PicFastaOpen_Click);
            this.picFastaOpen.MouseLeave += new System.EventHandler(this.PicFastaOpen_MouseLeave);
            this.picFastaOpen.MouseHover += new System.EventHandler(this.PicFastaOpen_MouseHover);
            // 
            // lblRunning
            // 
            this.lblRunning.AutoSize = true;
            this.lblRunning.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunning.ForeColor = System.Drawing.Color.Red;
            this.lblRunning.Location = new System.Drawing.Point(817, 707);
            this.lblRunning.Name = "lblRunning";
            this.lblRunning.Size = new System.Drawing.Size(117, 19);
            this.lblRunning.TabIndex = 34;
            this.lblRunning.Text = "Running.....";
            this.lblRunning.Visible = false;
            // 
            // chkCommand
            // 
            this.chkCommand.AutoSize = true;
            this.chkCommand.Checked = true;
            this.chkCommand.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCommand.Location = new System.Drawing.Point(468, 709);
            this.chkCommand.Name = "chkCommand";
            this.chkCommand.Size = new System.Drawing.Size(152, 19);
            this.chkCommand.TabIndex = 33;
            this.chkCommand.Text = "Show output window";
            this.chkCommand.UseVisualStyleBackColor = true;
            // 
            // IQtree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1267, 876);
            this.Controls.Add(this.lblRunning);
            this.Controls.Add(this.chkCommand);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblParam);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnStartIQ);
            this.Controls.Add(this.picSaveTree);
            this.Controls.Add(this.picFastaOpen);
            this.Controls.Add(this.txtIQtree);
            this.Controls.Add(this.txtFastaFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkViewTree);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IQtree";
            this.Text = "IQtree";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPartitionFile)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSaveTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFastaOpen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBootstraps;
        private System.Windows.Forms.TextBox txtLRTiterations;
        private System.Windows.Forms.TextBox txtMaxIterations;
        private System.Windows.Forms.CheckBox chkBayes;
        private System.Windows.Forms.CheckBox chkBootstraps;
        private System.Windows.Forms.CheckBox chkLRT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkNNI;
        private System.Windows.Forms.CheckBox chkBranch;
        private System.Windows.Forms.CheckBox chkTest;
        private System.Windows.Forms.CheckBox chkShort;
        private System.Windows.Forms.CheckBox chkModel;
        private System.Windows.Forms.CheckBox chkPartition;
        private System.Windows.Forms.CheckBox chkViewTree;
        private System.Windows.Forms.ComboBox cboModels;
        private System.Windows.Forms.CheckBox chkSubstitution;
        private System.Windows.Forms.RadioButton rdbBIC;
        private System.Windows.Forms.RadioButton rdbAICc;
        private System.Windows.Forms.RadioButton rdbAIC;
        private System.Windows.Forms.PictureBox picSaveTree;
        private System.Windows.Forms.PictureBox picFastaOpen;
        private System.Windows.Forms.TextBox txtIQtree;
        private System.Windows.Forms.TextBox txtFastaFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStartIQ;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblParam;
        private System.Windows.Forms.PictureBox picPartitionFile;
        private System.Windows.Forms.TextBox txtPartition;
        private System.Windows.Forms.TextBox txtNonBS;
        private System.Windows.Forms.CheckBox chkNonBS;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRunning;
        private System.Windows.Forms.CheckBox chkCommand;
    }
}