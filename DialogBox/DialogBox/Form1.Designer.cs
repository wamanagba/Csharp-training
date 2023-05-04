
namespace DialogBox
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
            this.BtnYes = new System.Windows.Forms.Button();
            this.lblCancel = new System.Windows.Forms.Label();
            this.lblYesNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnYes
            // 
            this.BtnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnYes.Location = new System.Drawing.Point(180, 60);
            this.BtnYes.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.BtnYes.Name = "BtnYes";
            this.BtnYes.Size = new System.Drawing.Size(210, 58);
            this.BtnYes.TabIndex = 0;
            this.BtnYes.Text = "Yes";
            this.BtnYes.UseVisualStyleBackColor = true;
            this.BtnYes.Click += new System.EventHandler(this.BtnYes_Click);
            // 
            // lblCancel
            // 
            this.lblCancel.AutoSize = true;
            this.lblCancel.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCancel.Location = new System.Drawing.Point(49, 226);
            this.lblCancel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(47, 26);
            this.lblCancel.TabIndex = 1;
            this.lblCancel.Text = ".....";
            // 
            // lblYesNo
            // 
            this.lblYesNo.AutoSize = true;
            this.lblYesNo.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblYesNo.Location = new System.Drawing.Point(49, 293);
            this.lblYesNo.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblYesNo.Name = "lblYesNo";
            this.lblYesNo.Size = new System.Drawing.Size(47, 26);
            this.lblYesNo.TabIndex = 2;
            this.lblYesNo.Text = ".....";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 387);
            this.Controls.Add(this.lblYesNo);
            this.Controls.Add(this.lblCancel);
            this.Controls.Add(this.BtnYes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnYes;
        private System.Windows.Forms.Label lblCancel;
        private System.Windows.Forms.Label lblYesNo;
    }
}

