using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cellar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            //txtUsername.Clear();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            //txtPassword.UseSystemPasswordChar = true;
            //txtPassword.Clear();
        }

        //Log in code
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "harold" && txtPassword.Text == "monroe")
            {
                Cellar s = new Cellar(); //New instance of 'Cellar' application
                s.Show();
                this.Hide();
            }
            else
            {
                //Message for user when login fails
                MessageBox.Show("Login Attempt Failed!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Clear();
                txtPassword.Clear();
            }
        }
    }
}
