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
    public partial class FormAddUser : Form
    {
        public FormAddUser()
        {
            InitializeComponent();
            ShowUsers();
        }
        void ShowUsers()
        {
            listView1.Items.Clear();
            foreach (Users users in Program.BD.Users)
            {
                ListViewItem item = new ListViewItem(new string[] {
                  users.login, users.password, users.type
                });
                item.Tag = users;
                listView1.Items.Add(item);
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                Users users = listView1.SelectedItems[0].Tag as Users;
                textBoxLogin.Text = users.login;
                textBoxPassword.Text = users.password;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
                if (textBoxLogin.Text != "" && textBoxPassword.Text != "")
                {
                    Users users = new Users();
                    users.login = textBoxLogin.Text;
                    users.password = textBoxPassword.Text;
                users.type = "user";
                    Program.BD.Users.Add(users);
                    Program.BD.SaveChanges();
                    ShowUsers();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                if (textBoxLogin.Text != "" && textBoxPassword.Text != "")
                {
                    Users users = listView1.SelectedItems[0].Tag as Users;
                    users.login = textBoxLogin.Text;
                    users.password = textBoxPassword.Text;
                    Program.BD.SaveChanges();
                    ShowUsers();
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count == 1)
                {
                    Users users = listView1.SelectedItems[0].Tag as Users;
                    Program.BD.Users.Remove(users);
                    Program.BD.SaveChanges();
                    ShowUsers();
                }
            }
            catch
            {
                MessageBox.Show("Поле используется!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAddUser_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.9;
        }
    }
}
