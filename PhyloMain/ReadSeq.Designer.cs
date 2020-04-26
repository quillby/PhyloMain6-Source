namespace PhyloMain
{
    partial class ReadSeq
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.picInput = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cboInput = new System.Windows.Forms.ComboBox();
            this.cboOutput = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.picOutput = new System.Windows.Forms.PictureBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lblParam = new System.Windows.Forms.Label();
            this.txtWarning = new System.Windows.Forms.TextBox();
            this.btnResetAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(417, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "ReadSeq: sequence format conversion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(244, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Input";
            // 
            // txtInput
            // 
            this.txtInput.AllowDrop = true;
            this.txtInput.Location = new System.Drawing.Point(454, 192);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(469, 23);
            this.txtInput.TabIndex = 13;
            this.txtInput.TextChanged += new System.EventHandler(this.TxtInput_TextChanged);
            this.txtInput.DragDrop += new System.Windows.Forms.DragEventHandler(this.TxtInput_DragDrop);
            this.txtInput.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxtInput_DragEnter);
            // 
            // picInput
            // 
            this.picInput.BackColor = System.Drawing.Color.Transparent;
            this.picInput.Image = global::PhyloMain.Properties.Resources.content_48;
            this.picInput.Location = new System.Drawing.Point(929, 192);
            this.picInput.Name = "picInput";
            this.picInput.Size = new System.Drawing.Size(24, 23);
            this.picInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picInput.TabIndex = 14;
            this.picInput.TabStop = false;
            this.picInput.Click += new System.EventHandler(this.PicInput_Click);
            this.picInput.MouseLeave += new System.EventHandler(this.PicInput_MouseLeave);
            this.picInput.MouseHover += new System.EventHandler(this.PicInput_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Output";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(309, 232);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(83, 23);
            this.comboBox1.TabIndex = 15;
            // 
            // cboInput
            // 
            this.cboInput.FormattingEnabled = true;
            this.cboInput.Items.AddRange(new object[] {
            "Fasta",
            "Clustal",
            "Nexus"});
            this.cboInput.Location = new System.Drawing.Point(309, 192);
            this.cboInput.Name = "cboInput";
            this.cboInput.Size = new System.Drawing.Size(83, 23);
            this.cboInput.TabIndex = 15;
            this.cboInput.Text = "Fasta";
            // 
            // cboOutput
            // 
            this.cboOutput.FormattingEnabled = true;
            this.cboOutput.Items.AddRange(new object[] {
            "Fasta",
            "Clustal",
            "Nexus"});
            this.cboOutput.Location = new System.Drawing.Point(309, 232);
            this.cboOutput.Name = "cboOutput";
            this.cboOutput.Size = new System.Drawing.Size(83, 23);
            this.cboOutput.TabIndex = 15;
            this.cboOutput.Text = "Nexus";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(398, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "file:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(398, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "file:";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(454, 232);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(469, 23);
            this.txtOutput.TabIndex = 13;
            this.txtOutput.TextChanged += new System.EventHandler(this.TxtOutput_TextChanged);
            this.txtOutput.DoubleClick += new System.EventHandler(this.TxtOutput_DoubleClick);
            // 
            // picOutput
            // 
            this.picOutput.BackColor = System.Drawing.Color.Transparent;
            this.picOutput.Image = global::PhyloMain.Properties.Resources.content_48;
            this.picOutput.Location = new System.Drawing.Point(929, 232);
            this.picOutput.Name = "picOutput";
            this.picOutput.Size = new System.Drawing.Size(24, 23);
            this.picOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOutput.TabIndex = 14;
            this.picOutput.TabStop = false;
            this.picOutput.Click += new System.EventHandler(this.PicOutput_Click);
            this.picOutput.MouseLeave += new System.EventHandler(this.PicOutput_MouseLeave);
            this.picOutput.MouseHover += new System.EventHandler(this.PicOutput_MouseHover);
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnConvert.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConvert.Location = new System.Drawing.Point(454, 452);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(172, 34);
            this.btnConvert.TabIndex = 16;
            this.btnConvert.Text = "Start conversion";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblParam
            // 
            this.lblParam.AutoSize = true;
            this.lblParam.Location = new System.Drawing.Point(30, 771);
            this.lblParam.Name = "lblParam";
            this.lblParam.Size = new System.Drawing.Size(133, 15);
            this.lblParam.TabIndex = 17;
            this.lblParam.Text = "parameters visible";
            // 
            // txtWarning
            // 
            this.txtWarning.BackColor = System.Drawing.Color.Black;
            this.txtWarning.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWarning.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWarning.ForeColor = System.Drawing.Color.Red;
            this.txtWarning.Location = new System.Drawing.Point(454, 344);
            this.txtWarning.Name = "txtWarning";
            this.txtWarning.Size = new System.Drawing.Size(382, 19);
            this.txtWarning.TabIndex = 19;
            this.txtWarning.Text = "Program is running. Wait to finish.......";
            this.txtWarning.Visible = false;
            // 
            // btnResetAll
            // 
            this.btnResetAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnResetAll.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnResetAll.Location = new System.Drawing.Point(664, 452);
            this.btnResetAll.Name = "btnResetAll";
            this.btnResetAll.Size = new System.Drawing.Size(172, 34);
            this.btnResetAll.TabIndex = 16;
            this.btnResetAll.Text = "Reset All";
            this.btnResetAll.UseVisualStyleBackColor = false;
            this.btnResetAll.Click += new System.EventHandler(this.BtnResetAll_Click);
            // 
            // ReadSeq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1251, 837);
            this.Controls.Add(this.txtWarning);
            this.Controls.Add(this.lblParam);
            this.Controls.Add(this.btnResetAll);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.cboInput);
            this.Controls.Add(this.cboOutput);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.picOutput);
            this.Controls.Add(this.picInput);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ReadSeq";
            this.Text = "ReadSeq";
            ((System.ComponentModel.ISupportInitialize)(this.picInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cboInput;
        private System.Windows.Forms.ComboBox cboOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.PictureBox picOutput;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lblParam;
        private System.Windows.Forms.TextBox txtWarning;
        private System.Windows.Forms.Button btnResetAll;
    }
}