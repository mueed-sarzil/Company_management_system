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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void buttonManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagmentPanel mp = new ManagmentPanel();
            mp.Show();
        }

        private void buttonSoftware_Click(object sender, EventArgs e)
        {
            this.Hide();
            SoftwarePanel sp = new SoftwarePanel();
            sp.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void buttonAcccounts_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountsPanel accp = new AccountsPanel();
            accp.Show();
        }

        private void buttonHRDept_Click(object sender, EventArgs e)
        {
            this.Hide();
            HRPanel hp = new HRPanel();
            hp.Show();
        }

        private void buttonAttendance_Click(object sender, EventArgs e)
        {
            AttendancePanel attp = new AttendancePanel();
            attp.Show();
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientPanel cp = new ClientPanel();
            cp.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
