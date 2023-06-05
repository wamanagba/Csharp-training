
namespace Map03
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbJFM = new System.Windows.Forms.CheckBox();
            this.cbMAM = new System.Windows.Forms.CheckBox();
            this.cbMJJ = new System.Windows.Forms.CheckBox();
            this.cbJAS = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnGenerateMap = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(460, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Map with Rainffal Data ";
            // 
            // cbJFM
            // 
            this.cbJFM.AutoSize = true;
            this.cbJFM.Location = new System.Drawing.Point(6, 12);
            this.cbJFM.Name = "cbJFM";
            this.cbJFM.Size = new System.Drawing.Size(66, 24);
            this.cbJFM.TabIndex = 0;
            this.cbJFM.Text = "JFM";
            this.cbJFM.UseVisualStyleBackColor = true;
            // 
            // cbMAM
            // 
            this.cbMAM.AutoSize = true;
            this.cbMAM.Location = new System.Drawing.Point(137, 12);
            this.cbMAM.Name = "cbMAM";
            this.cbMAM.Size = new System.Drawing.Size(72, 24);
            this.cbMAM.TabIndex = 1;
            this.cbMAM.Text = "MAM";
            this.cbMAM.UseVisualStyleBackColor = true;
            // 
            // cbMJJ
            // 
            this.cbMJJ.AutoSize = true;
            this.cbMJJ.Location = new System.Drawing.Point(274, 12);
            this.cbMJJ.Name = "cbMJJ";
            this.cbMJJ.Size = new System.Drawing.Size(64, 24);
            this.cbMJJ.TabIndex = 2;
            this.cbMJJ.Text = "MJJ";
            this.cbMJJ.UseVisualStyleBackColor = true;
            // 
            // cbJAS
            // 
            this.cbJAS.AutoSize = true;
            this.cbJAS.Location = new System.Drawing.Point(410, 12);
            this.cbJAS.Name = "cbJAS";
            this.cbJAS.Size = new System.Drawing.Size(65, 24);
            this.cbJAS.TabIndex = 3;
            this.cbJAS.Text = "JAS";
            this.cbJAS.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.NavajoWhite;
            this.groupBox1.Controls.Add(this.cbJAS);
            this.groupBox1.Controls.Add(this.cbMJJ);
            this.groupBox1.Controls.Add(this.cbMAM);
            this.groupBox1.Controls.Add(this.cbJFM);
            this.groupBox1.Location = new System.Drawing.Point(108, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 48);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // BtnGenerateMap
            // 
            this.BtnGenerateMap.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnGenerateMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerateMap.Location = new System.Drawing.Point(691, 78);
            this.BtnGenerateMap.Name = "BtnGenerateMap";
            this.BtnGenerateMap.Size = new System.Drawing.Size(244, 47);
            this.BtnGenerateMap.TabIndex = 2;
            this.BtnGenerateMap.Text = "Processing";
            this.BtnGenerateMap.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(955, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "Display the Maps";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 636);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnGenerateMap);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbJFM;
        private System.Windows.Forms.CheckBox cbMAM;
        private System.Windows.Forms.CheckBox cbMJJ;
        private System.Windows.Forms.CheckBox cbJAS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnGenerateMap;
        private System.Windows.Forms.Button button1;
    }
}

