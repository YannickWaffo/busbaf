using BusBaf.Model;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusBaf.View
{
    public partial class MainForm : Form
    {
        private Form activeForm;
        public Admin administrateur = null;
        LoginForm lf = new LoginForm();
        MenuForm mf = new MenuForm();
        MenuForm2 mf2 = new MenuForm2();
        AdminForm uf = new AdminForm();
        
        public MainForm()
        {
            InitializeComponent();
            
            RadioRight.Checked = true;
            btnMenu.Visible = false;

            titre.Text = "Menu";
            OpenFormChild(mf2);

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lPram);

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        private void panelBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        public void OpenFormChild(Form childForm)
        {
            //if (activeForm != null)
            //{
            //    activeForm.Close();

            //}
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.PanelMain.Controls.Add(childForm);
            this.PanelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            childForm.Dock = DockStyle.Fill;

        }

        private void RadioLeft_CheckedChanged(object sender, EventArgs e)
        {
            
            OpenFormChild(mf);
            titre.Text = "CARTE";
        }

        private void RadioRight_CheckedChanged(object sender, EventArgs e)
        {
            
            OpenFormChild(mf2);
            titre.Text = "MENU PRINCIPAL";
        }

        private void btnSpace_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PanelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lf.ShowDialog();  
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            btmPanel1.Height = 1;
            OpenFormChild(uf);
            btnUser.Visible = false;
            btnMenu.Visible = true;
            titre.Text = "GESTION ADMINISTRATEUR";
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            btmPanel1.Height = 42;
            OpenFormChild(mf2);

            btnMenu.Visible = false;
            btnUser.Visible = true;
            titre.Text = "MENU PRINCIPAL";
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            administrateur = lf.administrateur;
            mf2.administrateur = administrateur;
            mf.administrateur = administrateur;

            if (administrateur != null)
            {
                lbTitre.Text = "Bienvenue " +  administrateur.Nom;
            }
            if (this.Visible == false) {
                this.Visible = true;
            }
        }

        private void gunaButton2_Click_1(object sender, EventArgs e)
        {
            
            lf.ShowDialog();
        }
    }
}
