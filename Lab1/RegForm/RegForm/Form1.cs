using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(this.textBox1.Text) || string.IsNullOrWhiteSpace(this.textBox2.Text) || this.comboBox1.SelectedItem == null || (!this.radioButton1.Checked && !this.radioButton2.Checked) ||(!this.checkBox1.Checked && !this.checkBox2.Checked && !this.checkBox3.Checked))
                MessageBox.Show("Error, Empty Fields");
            else
                MessageBox.Show("Registration Complete");
        }
    }
}
