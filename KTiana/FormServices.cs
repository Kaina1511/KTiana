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
    public partial class FormServices : Form
    {
        public FormServices()
        {
            InitializeComponent();
            ShowServices();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                Services s = listView1.SelectedItems[0].Tag as Services;
                textBoxNameService.Text = s.Service;
                textBoxPrice.Text = s.Price.ToString();
            }
        }
        void ShowServices()
        {
            listView1.Items.Clear();
            foreach (Services s in Program.BD.Services)
            {
                ListViewItem item = new ListViewItem(new string[] {
                  s.Service, s.Price.ToString()
                }); ;
                item.Tag = s;
                listView1.Items.Add(item);
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxNameService.Text != "" && textBoxPrice.Text != "")
            {
                Services services = new Services();
                services.Service = textBoxNameService.Text;
                services.Price = Convert.ToInt32(textBoxPrice.Text);
                Program.BD.Services.Add(services);
                Program.BD.SaveChanges();
                ShowServices();
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

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxNameService.Text != "" && textBoxPrice.Text != "")
            {
                if (listView1.SelectedItems.Count == 1)
                {
                    Services services = listView1.SelectedItems[0].Tag as Services;
                    services.Service = textBoxNameService.Text;
                    services.Price = Convert.ToInt32(textBoxPrice.Text);
                    Program.BD.SaveChanges();
                    ShowServices();
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                Services services= listView1.SelectedItems[0].Tag as Services;
                Program.BD.Services.Remove(services);
                Program.BD.SaveChanges();
                ShowServices();
            }
        }

        private void FormServices_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.9;
        }
    }
}
