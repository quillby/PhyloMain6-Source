namespace PhyloMain
{
    partial class Likelihood
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
            this.txtFastaFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picFastaOpen = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLikelihood = new System.Windows.Forms.Button();
            this.chkLogfile = new System.Windows.Forms.CheckBox();
            this.chkDiagram = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFastaOpen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(461, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Likelihood Mapping Analysis";
            // 
            // txtFastaFile
            // 
            this.txtFastaFile.AllowDrop = true;
            this.txtFastaFile.Location = new System.Drawing.Point(465, 149);
            this.txtFastaFile.Name = "txtFastaFile";
            this.txtFastaFile.Size = new System.Drawing.Size(469, 23);
            this.txtFastaFile.TabIndex = 27;
            this.txtFastaFile.TextChanged += new System.EventHandler(this.TxtFastaFile_TextChanged);
            this.txtFastaFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.TxtFastaFile_DragDrop);
            this.txtFastaFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxtFastaFile_DragEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Open Fasta file:";
            // 
            // picFastaOpen
            // 
            this.picFastaOpen.BackColor = System.Drawing.Color.Transparent;
            this.picFastaOpen.Image = global::PhyloMain.Properties.Resources.content_48;
            this.picFastaOpen.Location = new System.Drawing.Point(940, 149);
            this.picFastaOpen.Name = "picFastaOpen";
            this.picFastaOpen.Size = new System.Drawing.Size(24, 23);
            this.picFastaOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFastaOpen.TabIndex = 28;
            this.picFastaOpen.TabStop = false;
            this.picFastaOpen.Click += new System.EventHandler(this.PicFastaOpen_Click);
            this.picFastaOpen.MouseLeave += new System.EventHandler(this.PicFastaOpen_MouseLeave);
            this.picFastaOpen.MouseHover += new System.EventHandler(this.PicFastaOpen_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(296, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 313);
            this.panel1.TabIndex = 29;
            // 
            // btnLikelihood
            // 
            this.btnLikelihood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLikelihood.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLikelihood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLikelihood.Location = new System.Drawing.Point(397, 548);
            this.btnLikelihood.Name = "btnLikelihood";
            this.btnLikelihood.Size = new System.Drawing.Size(172, 34);
            this.btnLikelihood.TabIndex = 30;
            this.btnLikelihood.Text = "Start calculation";
            this.btnLikelihood.UseVisualStyleBackColor = false;
            this.btnLikelihood.Click += new System.EventHandler(this.BtnLikelihood_Click);
            // 
            // chkLogfile
            // 
            this.chkLogfile.AutoSize = true;
            this.chkLogfile.Location = new System.Drawing.Point(608, 558);
            this.chkLogfile.Name = "chkLogfile";
            this.chkLogfile.Size = new System.Drawing.Size(117, 19);
            this.chkLogfile.TabIndex = 31;
            this.chkLogfile.Text = "Open log file";
            this.chkLogfile.UseVisualStyleBackColor = true;
            // 
            // chkDiagram
            // 
            this.chkDiagram.AutoSize = true;
            this.chkDiagram.Location = new System.Drawing.Point(759, 558);
            this.chkDiagram.Name = "chkDiagram";
            this.chkDiagram.Size = new System.Drawing.Size(110, 19);
            this.chkDiagram.TabIndex = 31;
            this.chkDiagram.Text = "Open diagram";
            this.chkDiagram.UseVisualStyleBackColor = true;
            // 
            // Likelihood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1251, 837);
            this.Controls.Add(this.chkDiagram);
            this.Controls.Add(this.chkLogfile);
            this.Controls.Add(this.btnLikelihood);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picFastaOpen);
            this.Controls.Add(this.txtFastaFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Likelihood";
            this.Text = "Likelihood";
            ((System.ComponentModel.ISupportInitialize)(this.picFastaOpen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picFastaOpen;
        private System.Windows.Forms.TextBox txtFastaFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLikelihood;
        private System.Windows.Forms.CheckBox chkLogfile;
        private System.Windows.Forms.CheckBox chkDiagram;
    }
}