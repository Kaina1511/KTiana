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
    public partial class FormContracts : Form
    {
        public FormContracts()
        {
            InitializeComponent();
            ShowContracts();
            ShowClients();
            ShowComboBoxWorkers();
            ShowComboBoxServices();
        }
        private void OnlyNumber(object sender, KeyPressEventArgs e)
        {
            char sym = e.KeyChar;
            if (!Char.IsDigit(sym) && sym != 8 || sym == 127)
            {
                e.Handled = true;
            }
        }
        void ShowClients()
        {
            comboBoxClients.Items.Clear();
            foreach (Clients clients in Program.BD.Clients)
            {
                string[] item = { clients.id_client + ": " + clients.NameOrganization};
                comboBoxClients.Items.Add(string.Join(" ", item));
            }
        }
        void ShowComboBoxWorkers()
        {
            comboBoxWorkers.Items.Clear();
            foreach (Workers workers in Program.BD.Workers)
            {
                string[] item = { workers.id_worker + ": " + workers.FIO + ", Профессия:" + workers.Position };
                comboBoxWorkers.Items.Add(string.Join(" ", item));
            }
        }
        void ShowComboBoxServices()
        {
            comboBoxServices.Items.Clear();
            foreach (Services services in Program.BD.Services)
            {
                string[] item = { services.id_service + ": " + services.Service+", Цена:" + services.Price};
                comboBoxServices.Items.Add(string.Join(" ", item));
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxNumberContract.Text != "" && comboBoxClients.SelectedItem != null && comboBoxServices.SelectedItem != null && comboBoxWorkers.SelectedItem != null)
            {
                Contracts contracts = new Contracts();
                contracts.NumberContract = Convert.ToInt32(textBoxNumberContract.Text);
                contracts.id_client = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split(':')[0]);
                contracts.id_worker = Convert.ToInt32(comboBoxWorkers.SelectedItem.ToString().Split(':')[0]);
                contracts.id_service = Convert.ToInt32(comboBoxServices.SelectedItem.ToString().Split(':')[0]);
                Program.BD.Contracts.Add(contracts);
                Program.BD.SaveChanges();
                ShowContracts();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxNumberContract.Text != "" && comboBoxClients.SelectedItem != null && comboBoxServices.SelectedItem != null && comboBoxWorkers.SelectedItem != null)
            {
                if (listView1.SelectedItems.Count == 1)
                {
                    Contracts contracts = listView1.SelectedItems[0].Tag as Contracts;
                    contracts.NumberContract = Convert.ToInt32(textBoxNumberContract.Text);
                    contracts.id_client = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split(':')[0]);
                    contracts.id_worker = Convert.ToInt32(comboBoxWorkers.SelectedItem.ToString().Split(':')[0]);
                    contracts.id_service = Convert.ToInt32(comboBoxServices.SelectedItem.ToString().Split(':')[0]);
                    Program.BD.SaveChanges();
                    ShowContracts();

                }
            }
        }
        void ShowContracts()
        {
            listView1.Items.Clear();
            foreach (Contracts contracts in Program.BD.Contracts)
            {
                ListViewItem item = new ListViewItem(new string[] {
                    contracts.NumberContract.ToString(), contracts.Clients.NameOrganization, contracts.Workers.FIO+", Должность:"+ contracts.Workers.Position,
                    contracts.Services.Service
                }); ;
                item.Tag = contracts;
                listView1.Items.Add(item);
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
}
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                Contracts contracts = listView1.SelectedItems[0].Tag as Contracts;
                textBoxNumberContract.Text = contracts.NumberContract.ToString();
                comboBoxClients.SelectedIndex = comboBoxClients.FindString(contracts.id_client.ToString());
                comboBoxWorkers.SelectedIndex = comboBoxWorkers.FindString(contracts.Workers.id_worker.ToString());
                comboBoxServices.SelectedIndex = comboBoxServices.FindString(contracts.Services.id_service.ToString());
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                Contracts contracts = listView1.SelectedItems[0].Tag as Contracts;
                Program.BD.Contracts.Remove(contracts);
                Program.BD.SaveChanges();
                    ShowContracts();
            }
        }

        private void FormContracts_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.9;
        }
    }
}
