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
    public partial class FormAddedClients : Form
    {
        public FormAddedClients()
        {
            InitializeComponent();
            ShowComboBoxWorker();
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
        private void comboBoxWorkers_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach (Clients clients in Program.BD.Clients)
            {
                if (clients.id_worker == Convert.ToInt32(comboBoxWorkers.SelectedItem.ToString().Split(':')[0]))
                {
                    ListViewItem item = new ListViewItem(new string[] {
                    clients.NameOrganization, clients.Workers.FIO
                });
                    item.Tag = clients;
                    listView1.Items.Add(item);
                    listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
            }
        }

        private void FormAddedClients_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.9;
        }
    }
}
