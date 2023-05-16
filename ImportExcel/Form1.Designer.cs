
namespace ImportExcel
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
            this.Data_GRD = new System.Windows.Forms.DataGridView();
            this.BtnLoadExcel = new System.Windows.Forms.Button();
            this.BtnImport = new System.Windows.Forms.Button();
            this.FileName_LBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Data_GRD)).BeginInit();
            this.SuspendLayout();
            // 
            // Data_GRD
            // 
            this.Data_GRD.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.Data_GRD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Data_GRD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_GRD.Location = new System.Drawing.Point(30, 4);
            this.Data_GRD.Name = "Data_GRD";
            this.Data_GRD.RowHeadersWidth = 62;
            this.Data_GRD.RowTemplate.Height = 28;
            this.Data_GRD.Size = new System.Drawing.Size(632, 504);
            this.Data_GRD.TabIndex = 0;
            // 
            // BtnLoadExcel
            // 
            this.BtnLoadExcel.BackColor = System.Drawing.Color.SandyBrown;
            this.BtnLoadExcel.Location = new System.Drawing.Point(30, 538);
            this.BtnLoadExcel.Name = "BtnLoadExcel";
            this.BtnLoadExcel.Size = new System.Drawing.Size(169, 55);
            this.BtnLoadExcel.TabIndex = 1;
            this.BtnLoadExcel.Text = "LoadExcel";
            this.BtnLoadExcel.UseVisualStyleBackColor = false;
            this.BtnLoadExcel.Click += new System.EventHandler(this.BtnLoadExcel_Click);
            // 
            // BtnImport
            // 
            this.BtnImport.BackColor = System.Drawing.Color.SandyBrown;
            this.BtnImport.Location = new System.Drawing.Point(432, 538);
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.Size = new System.Drawing.Size(192, 55);
            this.BtnImport.TabIndex = 2;
            this.BtnImport.Text = "Import";
            this.BtnImport.UseVisualStyleBackColor = false;
            this.BtnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // FileName_LBL
            // 
            this.FileName_LBL.AutoSize = true;
            this.FileName_LBL.BackColor = System.Drawing.Color.Honeydew;
            this.FileName_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileName_LBL.Location = new System.Drawing.Point(26, 610);
            this.FileName_LBL.Name = "FileName_LBL";
            this.FileName_LBL.Size = new System.Drawing.Size(24, 20);
            this.FileName_LBL.TabIndex = 3;
            this.FileName_LBL.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1308, 639);
            this.Controls.Add(this.FileName_LBL);
            this.Controls.Add(this.BtnImport);
            this.Controls.Add(this.BtnLoadExcel);
            this.Controls.Add(this.Data_GRD);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Data_GRD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Data_GRD;
        private System.Windows.Forms.Button BtnLoadExcel;
        private System.Windows.Forms.Button BtnImport;
        private System.Windows.Forms.Label FileName_LBL;
    }
}

