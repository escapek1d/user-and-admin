using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace user_and_admin
{
    public partial class vhod : Form
    {
        public vhod()
        {
            InitializeComponent();
        }
    private void button1_Click(object sender, EventArgs e)
        {
            vhod vhod = new vhod();
            account acc = new account();
            acc.but1 = this.button1;
            if (comboBox1.Text == "admin" && textBox1.Text == "qwerty")
            {
                this.Hide();
                acc.Show();
            }
            else if (comboBox1.Text == "user" && textBox1.Text == "qwerty1")
            {
                this.Hide();
                acc.Show();
            }
            else MessageBox.Show("Неверный пароль или имя пользователя");
        }
    }
}
