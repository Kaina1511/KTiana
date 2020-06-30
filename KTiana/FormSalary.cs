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
    public partial class FormSalary : Form
    {
        public FormSalary()
        {
            InitializeComponent();
            ShowSalary();
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
        void ShowSalary()
        {
            listView1.Items.Clear();
            foreach (Workers workers in Program.BD.Workers)
            {
                ListViewItem item = new ListViewItem(new string[] {
                   workers.Salary.ToString(), workers.FIO, workers.Prize.ToString()
                });
                item.Tag = workers;
                listView1.Items.Add(item);
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count==1)
            {
                Workers workers = listView1.SelectedItems[0].Tag as Workers;
                textBoxSalary.Text = workers.Salary.ToString();
                textBoxPrize.Text = workers.Prize.ToString();
                int i = 0;
                foreach (Contracts contracts in Program.BD.Contracts)
                {
                    if (contracts.id_worker == workers.id_worker)
                    {
                        i++;
                    }
                }
                if (i > 55)
                {
                    workers.Prize = 20000;
                    Program.BD.SaveChanges();
                    textBoxPrize.Text = workers.Prize.ToString();
                    ShowSalary();
                }
                else if (i > 35)
                {
                    workers.Prize = 15000;
                    Program.BD.SaveChanges();
                    textBoxPrize.Text = workers.Prize.ToString();
                    ShowSalary();
                }
                else if (i > 20)
                {
                    workers.Prize = 10000;
                    Program.BD.SaveChanges();
                    textBoxPrize.Text = workers.Prize.ToString();
                    ShowSalary();
                }
                else if (i > 15)
                {
                    workers.Prize = 5000;
                    Program.BD.SaveChanges();
                    textBoxPrize.Text = workers.Prize.ToString();
                    ShowSalary();
                }
                else if (i > 10)
                {
                    workers.Prize = 2000;
                    Program.BD.SaveChanges();
                    textBoxPrize.Text = workers.Prize.ToString();
                    ShowSalary();
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                if (textBoxSalary.Text != "" && textBoxPrize.Text != "")
                {
                    Workers workers = listView1.SelectedItems[0].Tag as Workers;
                    workers.Salary = Convert.ToInt32(textBoxSalary.Text);
                    workers.Prize = Convert.ToInt32(textBoxPrize.Text);
                    Program.BD.SaveChanges();
                    ShowSalary();
                }
            }
        }

        private void comboBoxWorkers_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach (Workers workers in Program.BD.Workers)
            {
                if (workers.id_worker == Convert.ToInt32(comboBoxWorkers.SelectedItem.ToString().Split(':')[0]))
                {
                    ListViewItem item = new ListViewItem(new string[] {
                    workers.Salary.ToString(), workers.FIO, workers.Prize.ToString()
                });
                    item.Tag = workers;
                    listView1.Items.Add(item);
                    listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
            }
        }

        private void FormSalary_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.9;
            if (FormAutorization.user.type != "admin")
            {
                buttonEdit.Enabled = false;
                buttonEdit.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                textBoxSalary.Visible = false;
                textBoxPrize.Visible = false;
                this.Width = 485;
            }
            else
            {
                textBoxSalary.Visible = true;
                textBoxPrize.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                this.Width = 674;
                buttonEdit.Enabled = true;
                buttonEdit.Visible = true;
            }
        }
    }
}
