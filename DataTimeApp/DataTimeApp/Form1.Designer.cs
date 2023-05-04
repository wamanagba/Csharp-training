
namespace DataTimeApp
{
    partial class Form1
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
            this.dtpicker = new System.Windows.Forms.DateTimePicker();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lbl3DateDay = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTimeSeconds = new System.Windows.Forms.Label();
            this.lbl4Time = new System.Windows.Forms.Label();
            this.BtnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpicker
            // 
            this.dtpicker.CalendarFont = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpicker.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpicker.Location = new System.Drawing.Point(301, 65);
            this.dtpicker.Name = "dtpicker";
            this.dtpicker.Size = new System.Drawing.Size(404, 44);
            this.dtpicker.TabIndex = 0;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.Red;
            this.lblDateTime.Location = new System.Drawing.Point(295, 169);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(93, 32);
            this.lblDateTime.TabIndex = 1;
            this.lblDateTime.Text = "label1";
            // 
            // lbl3DateDay
            // 
            this.lbl3DateDay.AutoSize = true;
            this.lbl3DateDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3DateDay.ForeColor = System.Drawing.Color.Red;
            this.lbl3DateDay.Location = new System.Drawing.Point(295, 300);
            this.lbl3DateDay.Name = "lbl3DateDay";
            this.lbl3DateDay.Size = new System.Drawing.Size(99, 32);
            this.lbl3DateDay.TabIndex = 2;
            this.lbl3DateDay.Text = "label2";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Red;
            this.lblDate.Location = new System.Drawing.Point(295, 237);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(99, 32);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "label3";
            // 
            // lblTimeSeconds
            // 
            this.lblTimeSeconds.AutoSize = true;
            this.lblTimeSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeSeconds.ForeColor = System.Drawing.Color.Red;
            this.lblTimeSeconds.Location = new System.Drawing.Point(295, 447);
            this.lblTimeSeconds.Name = "lblTimeSeconds";
            this.lblTimeSeconds.Size = new System.Drawing.Size(99, 32);
            this.lblTimeSeconds.TabIndex = 4;
            this.lblTimeSeconds.Text = "label4";
            // 
            // lbl4Time
            // 
            this.lbl4Time.AutoSize = true;
            this.lbl4Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Time.ForeColor = System.Drawing.Color.Red;
            this.lbl4Time.Location = new System.Drawing.Point(295, 374);
            this.lbl4Time.Name = "lbl4Time";
            this.lbl4Time.Size = new System.Drawing.Size(99, 32);
            this.lbl4Time.TabIndex = 5;
            this.lbl4Time.Text = "label5";
            // 
            // BtnShow
            // 
            this.BtnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShow.Location = new System.Drawing.Point(762, 560);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(188, 64);
            this.BtnShow.TabIndex = 6;
            this.BtnShow.Text = "Show";
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 636);
            this.Controls.Add(this.BtnShow);
            this.Controls.Add(this.lbl4Time);
            this.Controls.Add(this.lblTimeSeconds);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lbl3DateDay);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.dtpicker);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpicker;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lbl3DateDay;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTimeSeconds;
        private System.Windows.Forms.Label lbl4Time;
        private System.Windows.Forms.Button BtnShow;
    }
}

