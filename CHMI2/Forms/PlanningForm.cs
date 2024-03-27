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
    public partial class PlanningForm : Form
    {
        public PlanningForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void BackBtn4_Click(object sender, EventArgs e)
        {
            TransViewForm frm1 = new TransViewForm();
            this.Hide();
            frm1.ShowDialog();
            this.Show();
            this.Close();
        }
    }
}
