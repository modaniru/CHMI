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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransAddForm));
            this.BackBtn3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTrType1 = new System.Windows.Forms.ComboBox();
            this.cbCtgry1 = new System.Windows.Forms.ComboBox();
            this.AddBtn1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SumTb1 = new System.Windows.Forms.TextBox();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackBtn3
            // 
            this.BackBtn3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.BackBtn3.Image = ((System.Drawing.Image)(resources.GetObject("BackBtn3.Image")));
            this.BackBtn3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BackBtn3.Location = new System.Drawing.Point(280, 407);
            this.BackBtn3.Name = "BackBtn3";
            this.BackBtn3.Size = new System.Drawing.Size(92, 42);
            this.BackBtn3.TabIndex = 0;
            this.BackBtn3.Text = "Назад";
            this.BackBtn3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.cbTrType1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbTrType1.FormattingEnabled = true;
            this.cbTrType1.Items.AddRange(new object[] {
            "Доход",
            "Расход"});
            this.cbTrType1.Location = new System.Drawing.Point(12, 28);
            this.cbTrType1.Name = "cbTrType1";
            this.cbTrType1.Size = new System.Drawing.Size(217, 28);
            this.cbTrType1.TabIndex = 2;
            this.cbTrType1.Text = "Выберите тип транзакции";
            // 
            // cbCtgry1
            // 
            this.cbCtgry1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbCtgry1.FormattingEnabled = true;
            this.cbCtgry1.Items.AddRange(new object[] {
            "Продукты питания",
            "Одежда и обувь",
            "Здоровье",
            "Транспорт",
            "Равзлечения",
            "Автоуслуги",
            "Другое"});
            this.cbCtgry1.Location = new System.Drawing.Point(12, 66);
            this.cbCtgry1.Name = "cbCtgry1";
            this.cbCtgry1.Size = new System.Drawing.Size(217, 28);
            this.cbCtgry1.TabIndex = 3;
            this.cbCtgry1.Text = "Выберите категорию";
            // 
            // AddBtn1
            // 
            this.AddBtn1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.AddBtn1.Location = new System.Drawing.Point(140, 200);
            this.AddBtn1.Name = "AddBtn1";
            this.AddBtn1.Size = new System.Drawing.Size(126, 40);
            this.AddBtn1.TabIndex = 4;
            this.AddBtn1.Text = "Добавить";
            this.AddBtn1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введите сумму (в руб.):";
            // 
            // SumTb1
            // 
            this.SumTb1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SumTb1.Location = new System.Drawing.Point(184, 153);
            this.SumTb1.Name = "SumTb1";
            this.SumTb1.Size = new System.Drawing.Size(175, 27);
            this.SumTb1.TabIndex = 6;
            // 
            // dtp1
            // 
            this.dtp1.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtp1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtp1.Location = new System.Drawing.Point(126, 108);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(233, 29);
            this.dtp1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Укажите дату:";
            // 
            // TransAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.SumTb1);
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
        private TextBox SumTb1;
        private DateTimePicker dtp1;
        private Label label3;
    }
}