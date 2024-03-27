namespace CHMI2
{
    partial class TransViewForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        //smth
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PlanBtn1 = new System.Windows.Forms.Button();
            this.ReservBtn1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.PlanBtn1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ReservBtn1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 395);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(350, 54);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // PlanBtn1
            // 
            this.PlanBtn1.Location = new System.Drawing.Point(3, 3);
            this.PlanBtn1.Name = "PlanBtn1";
            this.PlanBtn1.Size = new System.Drawing.Size(169, 48);
            this.PlanBtn1.TabIndex = 0;
            this.PlanBtn1.Text = "Планирование бюджета";
            this.PlanBtn1.UseVisualStyleBackColor = true;
            this.PlanBtn1.Click += new System.EventHandler(this.PlanBtn1_Click_1);
            // 
            // ReservBtn1
            // 
            this.ReservBtn1.Location = new System.Drawing.Point(178, 3);
            this.ReservBtn1.Name = "ReservBtn1";
            this.ReservBtn1.Size = new System.Drawing.Size(169, 48);
            this.ReservBtn1.TabIndex = 1;
            this.ReservBtn1.Text = "Резервирование средств";
            this.ReservBtn1.UseVisualStyleBackColor = true;
            this.ReservBtn1.Click += new System.EventHandler(this.ReservBtn1_Click);
            // 
            // button1
            // 
            this.button1.Image = global::CHMI2.Properties.Resources.pngegg;
            this.button1.Location = new System.Drawing.Point(278, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 85);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TransViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TransViewForm";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button PlanBtn1;
        private Button ReservBtn1;
        private Button button1;
    }
}