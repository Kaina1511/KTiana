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
    public partial class Agents : Form
    {
        public Agents()
        {
            InitializeComponent();
            ShowWorkers();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text != "" && textBoxFIO.Text != "" && textBoxNumberPasport.Text != "" && textBoxPhone.Text != "" && textBoxPosition.Text != "" && textBoxSeriasPasport.Text != "")
            {
                Workers workers = new Workers();
                workers.FIO = textBoxFIO.Text;
                workers.SeriasPasport = Convert.ToInt32(textBoxSeriasPasport.Text);
                workers.NumberPasport = Convert.ToInt32(textBoxNumberPasport.Text);
                workers.Phone = textBoxPhone.Text;
                workers.Position = textBoxPosition.Text;
                workers.Email = textBoxEmail.Text;
                workers.Salary = 50000;
                workers.Prize = 0;
                Program.BD.Workers.Add(workers);
                Program.BD.SaveChanges();
                ShowWorkers();
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
        void ShowWorkers()
        {
            listView1.Items.Clear();
            foreach (Workers workers in Program.BD.Workers)
            {
                    ListViewItem item = new ListViewItem(new string[] {
                   workers.FIO, workers.SeriasPasport.ToString(), workers.NumberPasport.ToString(),
                   workers.Phone, workers.Position, workers.Email
                });
                    item.Tag = workers;
                    listView1.Items.Add(item);
                    listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                Workers workers = listView1.SelectedItems[0].Tag as Workers;
                textBoxFIO.Text = workers.FIO;
                textBoxPhone.Text = workers.Phone;
                textBoxEmail.Text = workers.Email;
                textBoxPosition.Text = workers.Position;
                textBoxSeriasPasport.Text = workers.SeriasPasport.ToString();
                textBoxNumberPasport.Text = workers.NumberPasport.ToString();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text != "" && textBoxFIO.Text != "" && textBoxNumberPasport.Text != "" && textBoxPhone.Text != "" && textBoxPosition.Text != "" && textBoxSeriasPasport.Text != "")
            {
                if (listView1.SelectedItems.Count == 1)
                {
                    Workers workers = listView1.SelectedItems[0].Tag as Workers;
                    workers.FIO = textBoxFIO.Text;
                    workers.SeriasPasport = Convert.ToInt32(textBoxSeriasPasport.Text);
                    workers.NumberPasport = Convert.ToInt32(textBoxNumberPasport.Text);
                    workers.Phone = textBoxPhone.Text;
                    workers.Position = textBoxPosition.Text;
                    workers.Email = textBoxEmail.Text;
                    Program.BD.SaveChanges();
                    ShowWorkers();
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count == 1)
                {
                    Workers workers = listView1.SelectedItems[0].Tag as Workers;
                    Program.BD.Workers.Remove(workers);
                    Program.BD.SaveChanges();
                    ShowWorkers();
                }

            }
            catch
            {
                MessageBox.Show("Поле используется!","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           
        }

        private void Agents_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.9;
        }
    }
}
