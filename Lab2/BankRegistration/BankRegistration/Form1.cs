using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankRegistration
{
    public partial class Form1 : Form
    {
        public String[] usernames = { "Ram", "Shyam", "Hari" };
        public String[] passwords = { "ram", "shyam", "hari" };
        public int index;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            usernameTextBox.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 3; i++)
            {
                if (String.Equals(usernameTextBox.Text, usernames[i]))
                {
                    index = i;
                    if (String.Equals(passwordTextBox.Text, passwords[i]))
                    {
                        Details details = new Details();
                        this.Hide();
                        details.Show();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password");
                        break;
                    }
                }
                else
                {
                    MessageBox.Show("User Not Registered");
                    break;
                }
            }
        }
    }
}
