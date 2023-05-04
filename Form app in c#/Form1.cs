using System;
using System.Text;
using System.Windows.Forms;

namespace Form_app_in_c_
{
    public partial class Form : System.Windows.Forms.Form
    {
        String labelText = "";

        public Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Bowmans_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelText = comboBox1.Text;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label6.Text = labelText;
        }
    }
}
