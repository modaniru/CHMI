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
    public partial class BudgetAddForm : Form
    {
        public BudgetAddForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void BackBtn2_Click(object sender, EventArgs e)
        {
            PlanningForm frm1 = new PlanningForm();
            this.Hide();
            frm1.ShowDialog();
            this.Show();
            this.Close();
        }
    }
}
