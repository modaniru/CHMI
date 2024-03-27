namespace CHMI2.Forms
{
    partial class TransAddForm
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
            this.BackBtn3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTrType1 = new System.Windows.Forms.ComboBox();
            this.cbCtgry1 = new System.Windows.Forms.ComboBox();
            this.AddBtn1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BackBtn3
            // 
            this.BackBtn3.Location = new System.Drawing.Point(242, 407);
            this.BackBtn3.Name = "BackBtn3";
            this.BackBtn3.Size = new System.Drawing.Size(130, 42);
            this.BackBtn3.TabIndex = 0;
            this.BackBtn3.Text = "Назад";
            this.BackBtn3.UseVisualStyleBackColor = true;
            this.BackBtn3.Click += new System.EventHandler(this.BackBtn3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 1;
            // 
            // cbTrType1
            // 
            this.cbTrType1.FormattingEnabled = true;
            this.cbTrType1.Items.AddRange(new object[] {
            "Доход",
            "Расход"});
            this.cbTrType1.Location = new System.Drawing.Point(12, 28);
            this.cbTrType1.Name = "cbTrType1";
            this.cbTrType1.Size = new System.Drawing.Size(165, 23);
            this.cbTrType1.TabIndex = 2;
            this.cbTrType1.Text = "Выберите тип транзакции";
            // 
            // cbCtgry1
            // 
            this.cbCtgry1.FormattingEnabled = true;
            this.cbCtgry1.Location = new System.Drawing.Point(12, 66);
            this.cbCtgry1.Name = "cbCtgry1";
            this.cbCtgry1.Size = new System.Drawing.Size(165, 23);
            this.cbCtgry1.TabIndex = 3;
            this.cbCtgry1.Text = "Выберите категорию";
            // 
            // AddBtn1
            // 
            this.AddBtn1.Location = new System.Drawing.Point(80, 154);
            this.AddBtn1.Name = "AddBtn1";
            this.AddBtn1.Size = new System.Drawing.Size(131, 51);
            this.AddBtn1.TabIndex = 4;
            this.AddBtn1.Text = "Добавить";
            this.AddBtn1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введите сумму (в руб.):";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 23);
            this.textBox1.TabIndex = 6;
            // 
            // TransAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddBtn1);
            this.Controls.Add(this.cbCtgry1);
            this.Controls.Add(this.cbTrType1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackBtn3);
            this.Name = "TransAddForm";
            this.Text = "TransAddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BackBtn3;
        private Label label1;
        private ComboBox cbTrType1;
        private ComboBox cbCtgry1;
        private Button AddBtn1;
        private Label label2;
        private TextBox textBox1;
    }
}