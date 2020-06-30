using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTiana
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonAgents_Click(object sender, EventArgs e)
        {
            Agents agents = new Agents();
            agents.Show();
        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
        }

        private void buttonServices_Click(object sender, EventArgs e)
        {
            FormServices services = new FormServices();
            services.Show();
        }

        private void buttonContracts_Click(object sender, EventArgs e)
        {
            FormContracts contracts = new FormContracts();
            contracts.Show();
        }

        private void buttonAddedClients_Click(object sender, EventArgs e)
        {
            FormAddedClients addedClients = new FormAddedClients();
            addedClients.Show();
        }

        private void buttonSalary_Click(object sender, EventArgs e)
        {
            FormSalary formSalary = new FormSalary();
            formSalary.Show();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            FormAddUser addUser = new FormAddUser();
            addUser.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.9;
            if (FormAutorization.user.type != "admin")
            {
                buttonAddUser.Enabled = false;
                buttonAddUser.Visible = false;

                buttonAgents.Enabled = false;
                buttonAgents.Visible = false;

                buttonAddedClients.Location = new Point(31,12);
                buttonSalary.Location = new Point(31, 69);
                this.Width = 189;
            }
            else
            {
                buttonAddedClients.Location = new Point(150, 68);
                buttonSalary.Location = new Point(150, 124);
                this.Width = 298;

                buttonAddUser.Enabled = true;
                buttonAddUser.Visible = true;

                buttonAgents.Enabled = true;
                buttonAgents.Visible = true;
            }
        }
    }
}
