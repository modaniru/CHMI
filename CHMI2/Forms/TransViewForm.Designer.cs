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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransViewForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PlanBtn1 = new System.Windows.Forms.Button();
            this.ReservBtn1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BalanceLabel1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
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
            this.PlanBtn1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlanBtn1.Image = ((System.Drawing.Image)(resources.GetObject("PlanBtn1.Image")));
            this.PlanBtn1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PlanBtn1.Location = new System.Drawing.Point(3, 3);
            this.PlanBtn1.Name = "PlanBtn1";
            this.PlanBtn1.Size = new System.Drawing.Size(169, 48);
            this.PlanBtn1.TabIndex = 0;
            this.PlanBtn1.Text = "Планирование бюджета";
            this.PlanBtn1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PlanBtn1.UseVisualStyleBackColor = true;
            this.PlanBtn1.Click += new System.EventHandler(this.PlanBtn1_Click_1);
            // 
            // ReservBtn1
            // 
            this.ReservBtn1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReservBtn1.Image = global::CHMI2.Properties.Resources.рез;
            this.ReservBtn1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReservBtn1.Location = new System.Drawing.Point(178, 3);
            this.ReservBtn1.Name = "ReservBtn1";
            this.ReservBtn1.Size = new System.Drawing.Size(169, 48);
            this.ReservBtn1.TabIndex = 1;
            this.ReservBtn1.Text = "Резервирование средств";
            this.ReservBtn1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReservBtn1.UseVisualStyleBackColor = true;
            this.ReservBtn1.Click += new System.EventHandler(this.ReservBtn1_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(298, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 64);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Баланс:";
            // 
            // BalanceLabel1
            // 
            this.BalanceLabel1.AutoSize = true;
            this.BalanceLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.BalanceLabel1.Location = new System.Drawing.Point(100, 9);
            this.BalanceLabel1.Name = "BalanceLabel1";
            this.BalanceLabel1.Size = new System.Drawing.Size(72, 25);
            this.BalanceLabel1.TabIndex = 3;
            this.BalanceLabel1.Text = "5.542P";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(287, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "Отчёт";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TransViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BalanceLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TransViewForm";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button PlanBtn1;
        private Button ReservBtn1;
        private Button button1;
        private Label label1;
        private Label BalanceLabel1;
        private Button button2;
    }
}