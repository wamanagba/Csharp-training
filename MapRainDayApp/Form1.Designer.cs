
namespace MapRainDayApp
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
            this.BtnMap = new System.Windows.Forms.Button();
            this.BtnProcessing = new System.Windows.Forms.Button();
            this.BtnDisplayMap = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbJan = new System.Windows.Forms.CheckBox();
            this.cbFeb = new System.Windows.Forms.CheckBox();
            this.cbMar = new System.Windows.Forms.CheckBox();
            this.cbApr = new System.Windows.Forms.CheckBox();
            this.cbMay = new System.Windows.Forms.CheckBox();
            this.cbJun = new System.Windows.Forms.CheckBox();
            this.tbProcessing = new System.Windows.Forms.TextBox();
            this.tbGenerate = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnMap
            // 
            this.BtnMap.BackColor = System.Drawing.Color.LightSalmon;
            this.BtnMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMap.Location = new System.Drawing.Point(501, 12);
            this.BtnMap.Name = "BtnMap";
            this.BtnMap.Size = new System.Drawing.Size(211, 42);
            this.BtnMap.TabIndex = 0;
            this.BtnMap.Text = "Generate Map";
            this.BtnMap.UseVisualStyleBackColor = false;
            this.BtnMap.Click += new System.EventHandler(this.BtnMap_Click);
            // 
            // BtnProcessing
            // 
            this.BtnProcessing.BackColor = System.Drawing.Color.LightSalmon;
            this.BtnProcessing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProcessing.Location = new System.Drawing.Point(12, 12);
            this.BtnProcessing.Name = "BtnProcessing";
            this.BtnProcessing.Size = new System.Drawing.Size(348, 42);
            this.BtnProcessing.TabIndex = 1;
            this.BtnProcessing.Text = "Download and Processing";
            this.BtnProcessing.UseVisualStyleBackColor = false;
            this.BtnProcessing.Click += new System.EventHandler(this.BtnProcessing_Click);
            // 
            // BtnDisplayMap
            // 
            this.BtnDisplayMap.BackColor = System.Drawing.Color.LightSalmon;
            this.BtnDisplayMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDisplayMap.Location = new System.Drawing.Point(888, 12);
            this.BtnDisplayMap.Name = "BtnDisplayMap";
            this.BtnDisplayMap.Size = new System.Drawing.Size(273, 42);
            this.BtnDisplayMap.TabIndex = 2;
            this.BtnDisplayMap.Text = "Display Map";
            this.BtnDisplayMap.UseVisualStyleBackColor = false;
            this.BtnDisplayMap.Click += new System.EventHandler(this.BtnDisplayMap_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbJun);
            this.groupBox1.Controls.Add(this.cbMay);
            this.groupBox1.Controls.Add(this.cbApr);
            this.groupBox1.Controls.Add(this.cbMar);
            this.groupBox1.Controls.Add(this.cbFeb);
            this.groupBox1.Controls.Add(this.cbJan);
            this.groupBox1.Location = new System.Drawing.Point(345, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 60);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // cbJan
            // 
            this.cbJan.AutoSize = true;
            this.cbJan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJan.Location = new System.Drawing.Point(6, 25);
            this.cbJan.Name = "cbJan";
            this.cbJan.Size = new System.Drawing.Size(74, 29);
            this.cbJan.TabIndex = 0;
            this.cbJan.Text = "Jan";
            this.cbJan.UseVisualStyleBackColor = true;
            // 
            // cbFeb
            // 
            this.cbFeb.AutoSize = true;
            this.cbFeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFeb.Location = new System.Drawing.Point(86, 25);
            this.cbFeb.Name = "cbFeb";
            this.cbFeb.Size = new System.Drawing.Size(75, 29);
            this.cbFeb.TabIndex = 1;
            this.cbFeb.Text = "Feb";
            this.cbFeb.UseVisualStyleBackColor = true;
            // 
            // cbMar
            // 
            this.cbMar.AutoSize = true;
            this.cbMar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMar.Location = new System.Drawing.Point(166, 25);
            this.cbMar.Name = "cbMar";
            this.cbMar.Size = new System.Drawing.Size(75, 29);
            this.cbMar.TabIndex = 2;
            this.cbMar.Text = "Mar";
            this.cbMar.UseVisualStyleBackColor = true;
            // 
            // cbApr
            // 
            this.cbApr.AutoSize = true;
            this.cbApr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbApr.Location = new System.Drawing.Point(246, 25);
            this.cbApr.Name = "cbApr";
            this.cbApr.Size = new System.Drawing.Size(72, 29);
            this.cbApr.TabIndex = 3;
            this.cbApr.Text = "Apr";
            this.cbApr.UseVisualStyleBackColor = true;
            // 
            // cbMay
            // 
            this.cbMay.AutoSize = true;
            this.cbMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMay.Location = new System.Drawing.Point(338, 25);
            this.cbMay.Name = "cbMay";
            this.cbMay.Size = new System.Drawing.Size(79, 29);
            this.cbMay.TabIndex = 4;
            this.cbMay.Text = "May";
            this.cbMay.UseVisualStyleBackColor = true;
            // 
            // cbJun
            // 
            this.cbJun.AutoSize = true;
            this.cbJun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJun.Location = new System.Drawing.Point(414, 25);
            this.cbJun.Name = "cbJun";
            this.cbJun.Size = new System.Drawing.Size(74, 29);
            this.cbJun.TabIndex = 5;
            this.cbJun.Text = "Jun";
            this.cbJun.UseVisualStyleBackColor = true;
            // 
            // tbProcessing
            // 
            this.tbProcessing.Location = new System.Drawing.Point(366, 23);
            this.tbProcessing.Name = "tbProcessing";
            this.tbProcessing.Size = new System.Drawing.Size(100, 26);
            this.tbProcessing.TabIndex = 4;
            // 
            // tbGenerate
            // 
            this.tbGenerate.Location = new System.Drawing.Point(736, 23);
            this.tbGenerate.Name = "tbGenerate";
            this.tbGenerate.Size = new System.Drawing.Size(100, 26);
            this.tbGenerate.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 650);
            this.Controls.Add(this.tbGenerate);
            this.Controls.Add(this.tbProcessing);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnDisplayMap);
            this.Controls.Add(this.BtnProcessing);
            this.Controls.Add(this.BtnMap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnMap;
        private System.Windows.Forms.Button BtnProcessing;
        private System.Windows.Forms.Button BtnDisplayMap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbJun;
        private System.Windows.Forms.CheckBox cbMay;
        private System.Windows.Forms.CheckBox cbApr;
        private System.Windows.Forms.CheckBox cbMar;
        private System.Windows.Forms.CheckBox cbFeb;
        private System.Windows.Forms.CheckBox cbJan;
        private System.Windows.Forms.TextBox tbProcessing;
        private System.Windows.Forms.TextBox tbGenerate;
    }
}

