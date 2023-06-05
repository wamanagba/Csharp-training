
namespace Map2
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
            this.btnGenerateMap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerateMap
            // 
            this.btnGenerateMap.Location = new System.Drawing.Point(775, 23);
            this.btnGenerateMap.Name = "btnGenerateMap";
            this.btnGenerateMap.Size = new System.Drawing.Size(242, 60);
            this.btnGenerateMap.TabIndex = 0;
            this.btnGenerateMap.Text = "Generate Map";
            this.btnGenerateMap.UseVisualStyleBackColor = true;
            this.btnGenerateMap.Click += new System.EventHandler(this.btnGenerateMap_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1029, 622);
            this.Controls.Add(this.btnGenerateMap);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateMap;
    }
}

