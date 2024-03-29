using CHMI2.Forms;
using System.Windows.Forms;
//using static CHMI2.Forms.TransAddForm;


namespace CHMI2
{
    public partial class TransViewForm : Form
    {

        public static Wallet wallet = new Wallet();

        

        public TransViewForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
           // int c = dgv1.ColumnCount;
            int count = wallet.GetCount();
            List<Transaction> transaction = wallet.GetList();
            if (count != 0) {
                //dgv1.DataSource = transaction;
                dgv1["TrType",0].Value = transaction[0].type;
                dgv1[0, 1].Value = transaction[0].category;
                dgv1[0, 2].Value = transaction[0].name;
                dgv1[0, 3].Value = transaction[0].date;
                dgv1[0, 4].Value = transaction[0].value;
                //    List<Transaction> transaction = wallet.transactions;


                //    //dgv1.Rows[0].Cells[0].Value = transaction[0].type;
                //    //for (int i =0; i < transaction.Count; i++)
                //    //{
                //    //    for (int j = 0; j < 4; j++)
                //    //    {
                //    //        dgv1.Rows[i].Cells[j].Value = transaction[i].type;
                //    //    }
                //    //}
            }
            //dgv1.DataSource = transaction;
            InitializeComponent();
        }



        private void PlanBtn1_Click_1(object sender, EventArgs e)
        {
            PlanningForm frm1 = new PlanningForm();
            this.Hide();
            frm1.ShowDialog();
            this.Show();
            this.Close();
        }

        private void ReservBtn1_Click(object sender, EventArgs e)
        {
            ReservatForm frm1 = new ReservatForm();
            this.Hide();
            frm1.ShowDialog();
            this.Show();
            this.Close();
        }



        private void BalanceLabel1_Click(object sender, EventArgs e)
        {

        }

        private void AddTrBtn1_Click(object sender, EventArgs e)
        {
            TransAddForm frm1 = new TransAddForm();
            this.Hide();
            frm1.ShowDialog();
            this.Show();
            this.Close();
        }

        private void RepBtn1_Click(object sender, EventArgs e)
        {
            ReportForm frm1 = new ReportForm();
            this.Hide();
            frm1.ShowDialog();
            this.Show();
            this.Close();

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}