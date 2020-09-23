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
    public partial class ClientPanel : Form
    {
        public ClientPanel()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
        }

        private void buttonaddClient_Click(object sender, EventArgs e)
        {
            ClientAdd cadd = new ClientAdd();
            cadd.Show();
        }

        private void buttonClientDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientDetails cd = new ClientDetails();
            cd.Show();
        }
    }
}
