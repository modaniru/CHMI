namespace CHMI2.Forms
{
    partial class ReservatForm
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
            this.BackBtn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackBtn2
            // 
            this.BackBtn2.Location = new System.Drawing.Point(277, 410);
            this.BackBtn2.Name = "BackBtn2";
            this.BackBtn2.Size = new System.Drawing.Size(95, 39);
            this.BackBtn2.TabIndex = 0;
            this.BackBtn2.Text = "Назад";
            this.BackBtn2.UseVisualStyleBackColor = true;
            this.BackBtn2.Click += new System.EventHandler(this.BackBtn2_Click);
            // 
            // ReservatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.BackBtn2);
            this.Name = "ReservatForm";
            this.Text = "ReservatForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button BackBtn2;
    }
}