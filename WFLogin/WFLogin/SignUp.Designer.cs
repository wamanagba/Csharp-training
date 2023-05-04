
namespace WFLogin
{
    partial class SignUp
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTransactionMessage = new System.Windows.Forms.Label();
            this.lblSMSMessage = new System.Windows.Forms.Label();
            this.chkTransaction = new System.Windows.Forms.CheckBox();
            this.chkReports = new System.Windows.Forms.CheckBox();
            this.chkSMS = new System.Windows.Forms.CheckBox();
            this.BtnSignUp = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(267, 89);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(834, 26);
            this.txtFirstName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(267, 203);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(834, 26);
            this.txtLastName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email Address:";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(267, 302);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(834, 26);
            this.txtEmailAddress.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTransactionMessage);
            this.groupBox1.Controls.Add(this.lblSMSMessage);
            this.groupBox1.Controls.Add(this.chkTransaction);
            this.groupBox1.Controls.Add(this.chkReports);
            this.groupBox1.Controls.Add(this.chkSMS);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 376);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1073, 179);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Services";
            // 
            // lblTransactionMessage
            // 
            this.lblTransactionMessage.AutoSize = true;
            this.lblTransactionMessage.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionMessage.ForeColor = System.Drawing.Color.Blue;
            this.lblTransactionMessage.Location = new System.Drawing.Point(464, 132);
            this.lblTransactionMessage.Name = "lblTransactionMessage";
            this.lblTransactionMessage.Size = new System.Drawing.Size(54, 28);
            this.lblTransactionMessage.TabIndex = 4;
            this.lblTransactionMessage.Text = "......";
            // 
            // lblSMSMessage
            // 
            this.lblSMSMessage.AutoSize = true;
            this.lblSMSMessage.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSMSMessage.ForeColor = System.Drawing.Color.Blue;
            this.lblSMSMessage.Location = new System.Drawing.Point(464, 47);
            this.lblSMSMessage.Name = "lblSMSMessage";
            this.lblSMSMessage.Size = new System.Drawing.Size(54, 28);
            this.lblSMSMessage.TabIndex = 3;
            this.lblSMSMessage.Text = "......";
            // 
            // chkTransaction
            // 
            this.chkTransaction.AutoSize = true;
            this.chkTransaction.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTransaction.Location = new System.Drawing.Point(92, 132);
            this.chkTransaction.Name = "chkTransaction";
            this.chkTransaction.Size = new System.Drawing.Size(284, 33);
            this.chkTransaction.TabIndex = 2;
            this.chkTransaction.Text = "Transactions Reports";
            this.chkTransaction.UseVisualStyleBackColor = true;
            this.chkTransaction.CheckedChanged += new System.EventHandler(this.chkTransaction_CheckedChanged);
            // 
            // chkReports
            // 
            this.chkReports.AutoSize = true;
            this.chkReports.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkReports.Location = new System.Drawing.Point(92, 89);
            this.chkReports.Name = "chkReports";
            this.chkReports.Size = new System.Drawing.Size(129, 33);
            this.chkReports.TabIndex = 1;
            this.chkReports.Text = "Reports";
            this.chkReports.UseVisualStyleBackColor = true;
            this.chkReports.CheckedChanged += new System.EventHandler(this.chkReports_CheckedChanged);
            // 
            // chkSMS
            // 
            this.chkSMS.AutoSize = true;
            this.chkSMS.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSMS.Location = new System.Drawing.Point(92, 49);
            this.chkSMS.Name = "chkSMS";
            this.chkSMS.Size = new System.Drawing.Size(232, 33);
            this.chkSMS.TabIndex = 0;
            this.chkSMS.Text = "SMS Notification";
            this.chkSMS.UseVisualStyleBackColor = true;
            this.chkSMS.CheckedChanged += new System.EventHandler(this.chkSMS_CheckedChanged);
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignUp.Location = new System.Drawing.Point(881, 585);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.Size = new System.Drawing.Size(152, 47);
            this.BtnSignUp.TabIndex = 7;
            this.BtnSignUp.Text = "Sign Up";
            this.BtnSignUp.UseVisualStyleBackColor = true;
            this.BtnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 644);
            this.Controls.Add(this.BtnSignUp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFirstName);
            this.Name = "SignUp";
            this.Text = "Sign Up";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTransactionMessage;
        private System.Windows.Forms.Label lblSMSMessage;
        private System.Windows.Forms.CheckBox chkTransaction;
        private System.Windows.Forms.CheckBox chkReports;
        private System.Windows.Forms.CheckBox chkSMS;
        private System.Windows.Forms.Button BtnSignUp;
    }
}

