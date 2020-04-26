namespace PhyloMain
{
    partial class Genbank
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
            this.label2 = new System.Windows.Forms.Label();
            this.chkOpenOutput = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtWarning = new System.Windows.Forms.TextBox();
            this.lblParam = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboProduct = new System.Windows.Forms.ComboBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaxLength = new System.Windows.Forms.TextBox();
            this.txtMinLength = new System.Windows.Forms.TextBox();
            this.txtOrganism = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtACCN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnACCN = new System.Windows.Forms.Button();
            this.picACCNOpen = new System.Windows.Forms.PictureBox();
            this.picFileSave = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbNucleotide = new System.Windows.Forms.RadioButton();
            this.rdbPubMed = new System.Windows.Forms.RadioButton();
            this.txtMaxItems = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picACCNOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFileSave)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(543, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Genbank Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(318, 483);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Genbank Search by ACCN-file";
            // 
            // chkOpenOutput
            // 
            this.chkOpenOutput.AutoSize = true;
            this.chkOpenOutput.Location = new System.Drawing.Point(445, 652);
            this.chkOpenOutput.Name = "chkOpenOutput";
            this.chkOpenOutput.Size = new System.Drawing.Size(299, 19);
            this.chkOpenOutput.TabIndex = 15;
            this.chkOpenOutput.Text = "Open collected information after search";
            this.chkOpenOutput.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnReset.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnReset.Location = new System.Drawing.Point(823, 587);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(172, 34);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset values";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // txtWarning
            // 
            this.txtWarning.BackColor = System.Drawing.Color.Black;
            this.txtWarning.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWarning.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWarning.ForeColor = System.Drawing.Color.Red;
            this.txtWarning.Location = new System.Drawing.Point(434, 726);
            this.txtWarning.Name = "txtWarning";
            this.txtWarning.Size = new System.Drawing.Size(412, 19);
            this.txtWarning.TabIndex = 22;
            this.txtWarning.Text = " Collecting search results from Genbank .....";
            this.txtWarning.Visible = false;
            // 
            // lblParam
            // 
            this.lblParam.AutoSize = true;
            this.lblParam.Location = new System.Drawing.Point(32, 811);
            this.lblParam.Name = "lblParam";
            this.lblParam.Size = new System.Drawing.Size(133, 15);
            this.lblParam.TabIndex = 30;
            this.lblParam.Text = "parameters visible";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSearch.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSearch.Location = new System.Drawing.Point(445, 378);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(172, 34);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Start search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click_1);
            // 
            // cboProduct
            // 
            this.cboProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboProduct.FormattingEnabled = true;
            this.cboProduct.Items.AddRange(new object[] {
            "internal transcribed spacer 1",
            "18S ribosomal RNA",
            "26S ribosomal RNA",
            "actin",
            "calmodulin",
            "beta-tubulin",
            "elongation factor 1",
            "ADP-ribosylation factor",
            "delta-9 fatty acid desaturase",
            "lanosterol 14-alpha-demethylase",
            "60S ribosomal protein",
            "Hc220",
            "Hc230"});
            this.cboProduct.Location = new System.Drawing.Point(444, 185);
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(357, 23);
            this.cboProduct.TabIndex = 1;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(444, 295);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(469, 23);
            this.txtOutput.TabIndex = 40;
            this.txtOutput.TextChanged += new System.EventHandler(this.TxtOutput_TextChanged_1);
            this.txtOutput.DoubleClick += new System.EventHandler(this.TxtOutput_DoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(278, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 18);
            this.label6.TabIndex = 39;
            this.label6.Text = "Save Output As:";
            // 
            // txtMaxLength
            // 
            this.txtMaxLength.Location = new System.Drawing.Point(676, 233);
            this.txtMaxLength.Name = "txtMaxLength";
            this.txtMaxLength.Size = new System.Drawing.Size(87, 23);
            this.txtMaxLength.TabIndex = 3;
            // 
            // txtMinLength
            // 
            this.txtMinLength.Location = new System.Drawing.Point(524, 233);
            this.txtMinLength.Name = "txtMinLength";
            this.txtMinLength.Size = new System.Drawing.Size(87, 23);
            this.txtMinLength.TabIndex = 2;
            // 
            // txtOrganism
            // 
            this.txtOrganism.Location = new System.Drawing.Point(444, 136);
            this.txtOrganism.Name = "txtOrganism";
            this.txtOrganism.Size = new System.Drawing.Size(357, 23);
            this.txtOrganism.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(780, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 18);
            this.label8.TabIndex = 31;
            this.label8.Text = "bp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(628, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 18);
            this.label7.TabIndex = 32;
            this.label7.Text = "and";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(326, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 18);
            this.label5.TabIndex = 33;
            this.label5.Text = "Sequence length between";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(326, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 34;
            this.label4.Text = "Product:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(326, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "Organism:";
            // 
            // txtACCN
            // 
            this.txtACCN.AllowDrop = true;
            this.txtACCN.Location = new System.Drawing.Point(444, 525);
            this.txtACCN.Name = "txtACCN";
            this.txtACCN.Size = new System.Drawing.Size(467, 23);
            this.txtACCN.TabIndex = 46;
            this.txtACCN.TextChanged += new System.EventHandler(this.TxtACCN_TextChanged_1);
            this.txtACCN.DragDrop += new System.Windows.Forms.DragEventHandler(this.TxtACCN_DragDrop_1);
            this.txtACCN.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxtACCN_DragEnter_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(310, 526);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 18);
            this.label9.TabIndex = 45;
            this.label9.Text = "Open accn-file:";
            // 
            // btnACCN
            // 
            this.btnACCN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnACCN.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnACCN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnACCN.Location = new System.Drawing.Point(444, 587);
            this.btnACCN.Name = "btnACCN";
            this.btnACCN.Size = new System.Drawing.Size(208, 34);
            this.btnACCN.TabIndex = 5;
            this.btnACCN.Text = "Start file contents";
            this.btnACCN.UseVisualStyleBackColor = false;
            this.btnACCN.Click += new System.EventHandler(this.BtnACCN_Click);
            // 
            // picACCNOpen
            // 
            this.picACCNOpen.BackColor = System.Drawing.Color.Transparent;
            this.picACCNOpen.Image = global::PhyloMain.Properties.Resources.content_48;
            this.picACCNOpen.Location = new System.Drawing.Point(917, 526);
            this.picACCNOpen.Name = "picACCNOpen";
            this.picACCNOpen.Size = new System.Drawing.Size(24, 23);
            this.picACCNOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picACCNOpen.TabIndex = 47;
            this.picACCNOpen.TabStop = false;
            this.picACCNOpen.Click += new System.EventHandler(this.PicACCNOpen_Click);
            this.picACCNOpen.MouseLeave += new System.EventHandler(this.PicACCNOpen_MouseLeave);
            this.picACCNOpen.MouseHover += new System.EventHandler(this.PicACCNOpen_MouseHover);
            // 
            // picFileSave
            // 
            this.picFileSave.BackColor = System.Drawing.Color.Transparent;
            this.picFileSave.ErrorImage = global::PhyloMain.Properties.Resources.file_select;
            this.picFileSave.Image = global::PhyloMain.Properties.Resources.content_48;
            this.picFileSave.Location = new System.Drawing.Point(919, 295);
            this.picFileSave.Name = "picFileSave";
            this.picFileSave.Size = new System.Drawing.Size(24, 23);
            this.picFileSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFileSave.TabIndex = 41;
            this.picFileSave.TabStop = false;
            this.picFileSave.Click += new System.EventHandler(this.PicFileSave_Click_1);
            this.picFileSave.MouseLeave += new System.EventHandler(this.PicFileSave_MouseLeave);
            this.picFileSave.MouseHover += new System.EventHandler(this.PicFileSave_MouseHover);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(35, 696);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(65, 49);
            this.panel1.TabIndex = 48;
            this.panel1.Visible = false;
            // 
            // rdbNucleotide
            // 
            this.rdbNucleotide.AutoSize = true;
            this.rdbNucleotide.Checked = true;
            this.rdbNucleotide.Location = new System.Drawing.Point(623, 102);
            this.rdbNucleotide.Name = "rdbNucleotide";
            this.rdbNucleotide.Size = new System.Drawing.Size(102, 19);
            this.rdbNucleotide.TabIndex = 49;
            this.rdbNucleotide.TabStop = true;
            this.rdbNucleotide.Text = "nucleotides";
            this.rdbNucleotide.UseVisualStyleBackColor = true;
            this.rdbNucleotide.CheckedChanged += new System.EventHandler(this.RdbNucleotide_CheckedChanged);
            // 
            // rdbPubMed
            // 
            this.rdbPubMed.AutoSize = true;
            this.rdbPubMed.Location = new System.Drawing.Point(731, 102);
            this.rdbPubMed.Name = "rdbPubMed";
            this.rdbPubMed.Size = new System.Drawing.Size(67, 19);
            this.rdbPubMed.TabIndex = 50;
            this.rdbPubMed.TabStop = true;
            this.rdbPubMed.Text = "PubMed";
            this.rdbPubMed.UseVisualStyleBackColor = true;
            // 
            // txtMaxItems
            // 
            this.txtMaxItems.Location = new System.Drawing.Point(623, 335);
            this.txtMaxItems.Name = "txtMaxItems";
            this.txtMaxItems.Size = new System.Drawing.Size(66, 23);
            this.txtMaxItems.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(441, 336);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 18);
            this.label10.TabIndex = 39;
            this.label10.Text = "Max. items to export:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(695, 339);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 15);
            this.label11.TabIndex = 52;
            this.label11.Text = "(empty = no limit)";
            // 
            // Genbank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1267, 876);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtMaxItems);
            this.Controls.Add(this.rdbPubMed);
            this.Controls.Add(this.rdbNucleotide);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picACCNOpen);
            this.Controls.Add(this.txtACCN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnACCN);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboProduct);
            this.Controls.Add(this.picFileSave);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaxLength);
            this.Controls.Add(this.txtMinLength);
            this.Controls.Add(this.txtOrganism);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblParam);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtWarning);
            this.Controls.Add(this.chkOpenOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Genbank";
            this.Text = "Genbank Search";
            this.Load += new System.EventHandler(this.Genbank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picACCNOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFileSave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkOpenOutput;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtWarning;
        private System.Windows.Forms.Label lblParam;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboProduct;
        private System.Windows.Forms.PictureBox picFileSave;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaxLength;
        private System.Windows.Forms.TextBox txtMinLength;
        private System.Windows.Forms.TextBox txtOrganism;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picACCNOpen;
        private System.Windows.Forms.TextBox txtACCN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnACCN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbNucleotide;
        private System.Windows.Forms.RadioButton rdbPubMed;
        private System.Windows.Forms.TextBox txtMaxItems;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}