﻿
namespace WF_App_Python
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnMean = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(174, 82);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 26);
            this.txtA.TabIndex = 0;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(560, 82);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 26);
            this.txtB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(486, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "B";
            // 
            // BtnMean
            // 
            this.BtnMean.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMean.Location = new System.Drawing.Point(300, 182);
            this.BtnMean.Name = "BtnMean";
            this.BtnMean.Size = new System.Drawing.Size(181, 49);
            this.BtnMean.TabIndex = 4;
            this.BtnMean.Text = "Mean";
            this.BtnMean.UseVisualStyleBackColor = true;
            this.BtnMean.Click += new System.EventHandler(this.BtnMean_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(590, 389);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(181, 49);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnMean);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnMean;
        private System.Windows.Forms.Button BtnCancel;
    }
}

