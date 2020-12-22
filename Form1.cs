using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Anamul" && txtPassword.Text == "236411")
            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The user name or password is incorrect");
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
