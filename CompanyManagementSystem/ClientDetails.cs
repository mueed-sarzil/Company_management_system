using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyManagementSystem
{
    public partial class ClientDetails : Form
    {
        public ClientDetails()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            ClientPanel cp = new ClientPanel();
            cp.Show();
        }

        private void buttonCalculator_Click(object sender, EventArgs e)
        {
            CalculatorPanel cp = new CalculatorPanel();
            cp.Show();
        }
    }
}
