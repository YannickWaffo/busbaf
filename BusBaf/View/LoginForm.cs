using BusBaf.Dao;
using BusBaf.Model;
using BusBaf.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusBaf
{
    public partial class LoginForm : Form
    {
        public Admin administrateur = null;
        public LoginForm()
        {
            InitializeComponent();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if(txtUser.Text == "NOM USER")
            {
                txtUser.Text = "";
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "NOM USER";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if(txtPassword.Text == "MOT DE PASSE")
            {
                txtPassword.Text = "";
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "MOT DE PASSE";
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            administrateur = AdminDao.findUser(txtUser.Text, txtPassword.Text);
            if (administrateur != null)
            {
                this.Hide();
                txtUser.Text = "2035";
                txtPassword.Text = "2035";
            }
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
