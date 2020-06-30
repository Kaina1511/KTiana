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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
            ShowClients();
            ShowComboBoxWorker();
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text != "" && textBoxINN.Text != "" && textBoxKPP.Text != "" && textBoxNameOrganization.Text != "" && textBoxPhone.Text != "" && textBoxR_S.Text != "" && comboBoxWorkers.SelectedItem != null)
            {
                Clients clients = new Clients();
                clients.NameOrganization = textBoxNameOrganization.Text;
                clients.phone = textBoxPhone.Text;
                clients.kpp = Convert.ToInt32(textBoxKPP.Text);
                clients.inn = Convert.ToInt32(textBoxINN.Text);
                clients.r_s = Convert.ToInt32(textBoxR_S.Text);
                clients.email = textBoxEmail.Text;
                clients.id_worker = Convert.ToInt32(comboBoxWorkers.SelectedItem.ToString().Split(':')[0]);
                Program.BD.Clients.Add(clients);
                Program.BD.SaveChanges();
                ShowClients();
            }
        }
        void ShowComboBoxWorker()
        {
            comboBoxWorkers.Items.Clear();
            foreach (Workers workers in Program.BD.Workers)
            {
                    string[] item = { workers.id_worker + ": " + workers.FIO + ", Профессия:" + workers.Position };
                    comboBoxWorkers.Items.Add(string.Join(" ", item));
            }
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
            listView1.Items.Clear();
            foreach (Clients clients in Program.BD.Clients)
            {
                ListViewItem item = new ListViewItem(new string[] {
                  clients.NameOrganization, clients.inn.ToString(), clients.kpp.ToString(), clients.phone, clients.r_s.ToString(), clients.email, clients.Workers.FIO+", Проффесия: "+clients.Workers.Position
                }); ;
                item.Tag = clients;
                listView1.Items.Add(item);
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                if (textBoxEmail.Text != "" && textBoxINN.Text != "" && textBoxKPP.Text != "" && textBoxNameOrganization.Text != "" && textBoxPhone.Text != "" && textBoxR_S.Text != ""&&comboBoxWorkers.SelectedItem!=null)
                {
                    Clients clients = listView1.SelectedItems[0].Tag as Clients;
                    clients.NameOrganization = textBoxNameOrganization.Text;
                    clients.phone = textBoxPhone.Text;
                    clients.kpp = Convert.ToInt32(textBoxKPP.Text);
                    clients.inn = Convert.ToInt32(textBoxINN.Text);
                    clients.r_s = Convert.ToInt32(textBoxR_S.Text);
                    clients.email = textBoxEmail.Text;
                    clients.id_worker = Convert.ToInt32(comboBoxWorkers.SelectedItem.ToString().Split(':')[0]);
                    Program.BD.SaveChanges();
                    ShowClients();
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count == 1)
                {
                    Clients clients = listView1.SelectedItems[0].Tag as Clients;
                    Program.BD.Clients.Remove(clients);
                    Program.BD.SaveChanges();
                    ShowClients();
                }
            }
            catch
            {
                MessageBox.Show("Поле используется!");
            }

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                Clients clients = listView1.SelectedItems[0].Tag as Clients;
                textBoxNameOrganization.Text = clients.NameOrganization;
                textBoxPhone.Text = clients.phone;
                textBoxEmail.Text = clients.email;
                textBoxINN.Text = clients.inn.ToString();
                textBoxKPP.Text = clients.kpp.ToString();
                textBoxR_S.Text = clients.r_s.ToString();
            }
        }

        private void Client_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.9;
        }
    }
}
