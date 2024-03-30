using CHMI2.Forms;
using System.Transactions;
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
            InitializeComponent();
            // int c = dgv1.ColumnCount;
            int count = wallet.GetCount();
            List<Transaction> transaction = wallet.GetList();
            //dgv1.RowCount = count;
            
            if (count != 0)
            {

                foreach (Transaction trans in transaction)
                {
                    dgv1.Rows.Add(trans.type, trans.category, trans.name,  trans.date, trans.value);
                }
            }
            //dgv1.DataSource = transaction;

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