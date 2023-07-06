
namespace RunPythonRApp
{
    partial class ScriptForm
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
            this.Btncsp = new System.Windows.Forms.Button();
            this.rdbPython = new System.Windows.Forms.RadioButton();
            this.rdbR = new System.Windows.Forms.RadioButton();
            this.BtnCalcul = new System.Windows.Forms.Button();
            this.txtFirstNumber = new System.Windows.Forms.TextBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblSoustraction = new System.Windows.Forms.Label();
            this.lblMean = new System.Windows.Forms.Label();
            this.txtSecondNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btncsp
            // 
            this.Btncsp.BackColor = System.Drawing.Color.Red;
            this.Btncsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btncsp.Location = new System.Drawing.Point(786, 587);
            this.Btncsp.Name = "Btncsp";
            this.Btncsp.Size = new System.Drawing.Size(205, 52);
            this.Btncsp.TabIndex = 33;
            this.Btncsp.Text = "Cancel";
            this.Btncsp.UseVisualStyleBackColor = false;
            this.Btncsp.Click += new System.EventHandler(this.Btncsp_Click);
            // 
            // rdbPython
            // 
            this.rdbPython.AutoSize = true;
            this.rdbPython.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPython.Location = new System.Drawing.Point(116, 10);
            this.rdbPython.Name = "rdbPython";
            this.rdbPython.Size = new System.Drawing.Size(135, 36);
            this.rdbPython.TabIndex = 8;
            this.rdbPython.TabStop = true;
            this.rdbPython.Text = "Python";
            this.rdbPython.UseVisualStyleBackColor = true;
            // 
            // rdbR
            // 
            this.rdbR.AutoSize = true;
            this.rdbR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbR.Location = new System.Drawing.Point(27, 10);
            this.rdbR.Name = "rdbR";
            this.rdbR.Size = new System.Drawing.Size(61, 36);
            this.rdbR.TabIndex = 0;
            this.rdbR.TabStop = true;
            this.rdbR.Text = "R";
            this.rdbR.UseVisualStyleBackColor = true;
            // 
            // BtnCalcul
            // 
            this.BtnCalcul.BackColor = System.Drawing.Color.Green;
            this.BtnCalcul.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcul.Location = new System.Drawing.Point(174, 316);
            this.BtnCalcul.Name = "BtnCalcul";
            this.BtnCalcul.Size = new System.Drawing.Size(205, 52);
            this.BtnCalcul.TabIndex = 32;
            this.BtnCalcul.Text = "Calcul";
            this.BtnCalcul.UseVisualStyleBackColor = false;
            this.BtnCalcul.Click += new System.EventHandler(this.BtnCalcul_Click);
            // 
            // txtFirstNumber
            // 
            this.txtFirstNumber.Location = new System.Drawing.Point(298, 111);
            this.txtFirstNumber.Name = "txtFirstNumber";
            this.txtFirstNumber.Size = new System.Drawing.Size(125, 26);
            this.txtFirstNumber.TabIndex = 31;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSum.ForeColor = System.Drawing.Color.Green;
            this.lblSum.Location = new System.Drawing.Point(325, 492);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(44, 37);
            this.lblSum.TabIndex = 30;
            this.lblSum.Text = "...";
            // 
            // lblSoustraction
            // 
            this.lblSoustraction.AutoSize = true;
            this.lblSoustraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoustraction.ForeColor = System.Drawing.Color.Green;
            this.lblSoustraction.Location = new System.Drawing.Point(753, 492);
            this.lblSoustraction.Name = "lblSoustraction";
            this.lblSoustraction.Size = new System.Drawing.Size(44, 37);
            this.lblSoustraction.TabIndex = 29;
            this.lblSoustraction.Text = "...";
            // 
            // lblMean
            // 
            this.lblMean.AutoSize = true;
            this.lblMean.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMean.ForeColor = System.Drawing.Color.Green;
            this.lblMean.Location = new System.Drawing.Point(40, 492);
            this.lblMean.Name = "lblMean";
            this.lblMean.Size = new System.Drawing.Size(44, 37);
            this.lblMean.TabIndex = 28;
            this.lblMean.Text = "...";
            // 
            // txtSecondNumber
            // 
            this.txtSecondNumber.Location = new System.Drawing.Point(815, 110);
            this.txtSecondNumber.Name = "txtSecondNumber";
            this.txtSecondNumber.Size = new System.Drawing.Size(125, 26);
            this.txtSecondNumber.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(508, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(272, 37);
            this.label7.TabIndex = 26;
            this.label7.Text = "Second Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 37);
            this.label6.TabIndex = 25;
            this.label6.Text = "First Number:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbPython);
            this.groupBox1.Controls.Add(this.rdbR);
            this.groupBox1.Location = new System.Drawing.Point(491, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 58);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(327, 37);
            this.label5.TabIndex = 23;
            this.label5.Text = "Select the language:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(703, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 37);
            this.label4.TabIndex = 22;
            this.label4.Text = "Subtraction";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(325, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 37);
            this.label3.TabIndex = 21;
            this.label3.Text = "Sum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 37);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mean";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "Calculation of average and sum";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GreenYellow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(549, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 52);
            this.button1.TabIndex = 34;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ScriptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 651);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btncsp);
            this.Controls.Add(this.BtnCalcul);
            this.Controls.Add(this.txtFirstNumber);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.lblSoustraction);
            this.Controls.Add(this.lblMean);
            this.Controls.Add(this.txtSecondNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ScriptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScriptForm";
            this.Load += new System.EventHandler(this.ScriptForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btncsp;
        private System.Windows.Forms.RadioButton rdbPython;
        private System.Windows.Forms.RadioButton rdbR;
        private System.Windows.Forms.Button BtnCalcul;
        private System.Windows.Forms.TextBox txtFirstNumber;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblSoustraction;
        private System.Windows.Forms.Label lblMean;
        private System.Windows.Forms.TextBox txtSecondNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}