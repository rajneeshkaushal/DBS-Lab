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
    public partial class Details : Form
    {
        Form1 form1 = new Form1();
        public int[] balance = {5000, 7000, 4500};
        public Details()
        {
            InitializeComponent();
        }

        private void Details_Load(object sender, EventArgs e)
        {
            this.Text = "Details";
            label1.Text = "Username: " + form1.usernames[form1.index] + "\nBalance: " + balance[form1.index] + "\nLast Access: " + DateTime.Now + "\nTransactions:\nDeposit 5000\nWithdraw 3000\nDeposit 4000\nWithdraw 3000\nDeposit 2000"; 
        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.Show();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
