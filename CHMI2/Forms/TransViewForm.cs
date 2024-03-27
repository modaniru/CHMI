using CHMI2.Forms;


namespace CHMI2
{
    public partial class TransViewForm : Form
    {
        public TransViewForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void PlanBtn1_Click(object sender, EventArgs e)
        {
            //PlanningForm frm1 = new PlanningForm();
            //this.Hide();
            //frm1.ShowDialog();
            //this.Show();
            //this.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            TransAddForm frm1 = new TransAddForm();
            this.Hide();
            frm1.ShowDialog();
            this.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReportForm frm1 = new ReportForm();
            this.Hide();
            frm1.ShowDialog();
            this.Show();
            this.Close();
        }
    }
}