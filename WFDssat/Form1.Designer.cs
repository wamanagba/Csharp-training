
namespace WFDssat
{
    partial class Form1
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
            this.Btn_Infile = new System.Windows.Forms.Button();
            this.Btn_OutputWth = new System.Windows.Forms.Button();
            this.txb_InFile = new System.Windows.Forms.TextBox();
            this.txb_OuputWth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbStartDate = new System.Windows.Forms.TextBox();
            this.txbEndDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDownload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Infile
            // 
            this.Btn_Infile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Infile.Location = new System.Drawing.Point(41, 35);
            this.Btn_Infile.Name = "Btn_Infile";
            this.Btn_Infile.Size = new System.Drawing.Size(190, 39);
            this.Btn_Infile.TabIndex = 0;
            this.Btn_Infile.Text = "In_Files";
            this.Btn_Infile.UseVisualStyleBackColor = true;
            this.Btn_Infile.Click += new System.EventHandler(this.Btn_Infile_Click);
            // 
            // Btn_OutputWth
            // 
            this.Btn_OutputWth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_OutputWth.Location = new System.Drawing.Point(41, 109);
            this.Btn_OutputWth.Name = "Btn_OutputWth";
            this.Btn_OutputWth.Size = new System.Drawing.Size(190, 39);
            this.Btn_OutputWth.TabIndex = 1;
            this.Btn_OutputWth.Text = "Output wht File";
            this.Btn_OutputWth.UseVisualStyleBackColor = true;
            this.Btn_OutputWth.Click += new System.EventHandler(this.Btn_OutputWth_Click);
            // 
            // txb_InFile
            // 
            this.txb_InFile.Location = new System.Drawing.Point(283, 35);
            this.txb_InFile.Name = "txb_InFile";
            this.txb_InFile.Size = new System.Drawing.Size(727, 26);
            this.txb_InFile.TabIndex = 3;
            // 
            // txb_OuputWth
            // 
            this.txb_OuputWth.Location = new System.Drawing.Point(283, 122);
            this.txb_OuputWth.Name = "txb_OuputWth";
            this.txb_OuputWth.Size = new System.Drawing.Size(727, 26);
            this.txb_OuputWth.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(652, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "End Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(457, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "YYMMDD";
            // 
            // txbStartDate
            // 
            this.txbStartDate.Location = new System.Drawing.Point(432, 198);
            this.txbStartDate.Name = "txbStartDate";
            this.txbStartDate.Size = new System.Drawing.Size(139, 26);
            this.txbStartDate.TabIndex = 8;
            // 
            // txbEndDate
            // 
            this.txbEndDate.Location = new System.Drawing.Point(818, 196);
            this.txbEndDate.Name = "txbEndDate";
            this.txbEndDate.Size = new System.Drawing.Size(139, 26);
            this.txbEndDate.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(844, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "YYMMDD";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnUpdate.Location = new System.Drawing.Point(805, 373);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(152, 39);
            this.BtnUpdate.TabIndex = 11;
            this.BtnUpdate.Text = "Update The Data";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            // 
            // BtnDownload
            // 
            this.BtnDownload.BackColor = System.Drawing.Color.Coral;
            this.BtnDownload.Location = new System.Drawing.Point(313, 361);
            this.BtnDownload.Name = "BtnDownload";
            this.BtnDownload.Size = new System.Drawing.Size(152, 39);
            this.BtnDownload.TabIndex = 12;
            this.BtnDownload.Text = "Download Data";
            this.BtnDownload.UseVisualStyleBackColor = false;
            this.BtnDownload.Click += new System.EventHandler(this.BtnDownload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 572);
            this.Controls.Add(this.BtnDownload);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbEndDate);
            this.Controls.Add(this.txbStartDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_OuputWth);
            this.Controls.Add(this.txb_InFile);
            this.Controls.Add(this.Btn_OutputWth);
            this.Controls.Add(this.Btn_Infile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Infile;
        private System.Windows.Forms.Button Btn_OutputWth;
        private System.Windows.Forms.TextBox txb_InFile;
        private System.Windows.Forms.TextBox txb_OuputWth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbStartDate;
        private System.Windows.Forms.TextBox txbEndDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDownload;
    }
}

