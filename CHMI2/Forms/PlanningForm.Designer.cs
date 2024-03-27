namespace CHMI2.Forms
{
    partial class PlanningForm
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
            this.BackBtn4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackBtn4
            // 
            this.BackBtn4.Location = new System.Drawing.Point(284, 414);
            this.BackBtn4.Name = "BackBtn4";
            this.BackBtn4.Size = new System.Drawing.Size(88, 35);
            this.BackBtn4.TabIndex = 0;
            this.BackBtn4.Text = "Назад";
            this.BackBtn4.UseVisualStyleBackColor = true;
            this.BackBtn4.Click += new System.EventHandler(this.BackBtn4_Click);
            // 
            // PlanningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.BackBtn4);
            this.Name = "PlanningForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button BackBtn4;
    }
}