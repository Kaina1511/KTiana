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
    public struct User
    {
        public string login;
        public string password;
        public string type;
    }
    public partial class FormAutorization : Form
    {
        public static User user = new User();
        public FormAutorization()
        {
            InitializeComponent();
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            user.login = "";
            user.password = "";
            user.type = "";
            Menu menu = new Menu();
            foreach (Users users in Program.BD.Users)
            {
                if (textBoxLogin.Text == users.login && textBoxPassword.Text == users.password)
                {
                    user.login = textBoxLogin.Text.ToString();
                    user.password = textBoxPassword.Text.ToString();
                    user.type = users.type;
                    menu.Show();
                }
            }
            if (menu.Visible == false)
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void FormAutorization_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.9;
        }
    }
}
