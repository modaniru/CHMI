using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CHMI2.Forms
{
    

    public partial class TransAddForm : Form
    {
        
        public TransAddForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            
        }

        private void BackBtn3_Click(object sender, EventArgs e)
        {
            TransViewForm frm1 = new TransViewForm();
            this.Hide();
            frm1.ShowDialog();
            this.Show();
            this.Close();
        }

        private void AddBtn1_Click(object sender, EventArgs e)
        {
            int Val = Convert.ToInt32(SumTb1.Text);

            Transaction trans = new Transaction(cbTrType1.Text, tbName1.Text, cbCtgry1.Text, dtp1.Text, Val);
            TransViewForm.wallet.AddTransaction(trans);


           // TransViewForm.wallet.AddTransaction(cbTrType1.Text, tbName1.Text, cbCtgry1.Text, dtp1.Text, Val);

            cbTrType1.Text = "";
            tbName1.Clear();
            cbCtgry1.Text = "";
            dtp1.Value = DateTime.Today;
            SumTb1.Clear();


 
        }
    }
}
