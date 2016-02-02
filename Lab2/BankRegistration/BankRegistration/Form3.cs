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
    public partial class Form3 : Form
    {
        Details details = new Details();
        Form1 form1 = new Form1();
        public Form3()
        {
            InitializeComponent();
        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(usernameTextBox.Text) && !String.IsNullOrEmpty(amountTextBox.Text))
            {
                if (Int32.Parse(amountTextBox.Text) > details.balance[form1.index])
                    MessageBox.Show("Insufficient Balance");
                else
                {
                    details.balance[form1.index] -= Int32.Parse(amountTextBox.Text);
                    MessageBox.Show("Transferred: " + Int32.Parse(amountTextBox.Text) + "\nBalance: " + details.balance[form1.index]);
                }
            }
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
