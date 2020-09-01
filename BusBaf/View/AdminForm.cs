using BusBaf.Model;
using BusBaf.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusBaf.View
{
    public partial class AdminForm : Form
    {
        Admin admin = new Admin();
        Droits droit = new Droits();
        public AdminForm()
        {
            InitializeComponent();
            txtNumero.Text = AdminDao.generateKey();
        }

        public void Form2Model()
        {
            admin.Numero = txtNumero.Text;
            admin.Nom = txtNom.Text;
            admin.Prenom = txtPrenom.Text;
            admin.UserName = txtUser.Text;
            admin.Password = txtPass.Text;
            if (ckActive.Checked)
            {
                droit.Table = cbTables.Text;
                droit.admin = AdminDao.findByNumero(txtNumero.Text);
                if (Coui.Checked == true)
                { 
                    droit.Consulter = "O";
                }
                if (Cnon.Checked == true) {
                    droit.Consulter = "N";
                }
                if (Eoui.Checked == true)
                {
                    droit.Ajouter = "O";
                }
                if (Enon.Checked == true)
                {
                    droit.Ajouter = "N";
                }
                if (Moui.Checked == true)
                {
                    droit.Modifier = "O";
                }
                if (Mnon.Checked == true)
                {
                    droit.Modifier = "N";
                }
                if (Soui.Checked == true)
                {
                    droit.Supprimer = "O";
                }
                if (Snon.Checked == true)
                {
                    droit.Supprimer = "N";
                }

            }
        }

        public void Model2Form()
        {
            txtNumero.Text = admin.Numero;
            txtNom.Text = admin.Nom;
            txtPrenom.Text = admin.Prenom;
            txtUser.Text = admin.UserName;
            txtPass.Text = admin.Password;
        }

        public void Vider()
        {
            admin = null;
            txtNumero.Text = "";
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtUser.Text = "";
            txtPass.Text = "";
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            txtNumero.Text = AdminDao.generateKey();
            DataAdminload();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dgAdmin.RowCount; i++)
            {
                if ((bool)dgAdmin.Rows[i].Selected)
                {
                    Admin admins = AdminDao.findByNumero(dgAdmin.Rows[i].Cells[0].Value.ToString());
                    admin = admins;
                    Model2Form();
                    
                }
            }
        }

        private void btnSee_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '*') {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }

        private void ckActive_CheckedChanged(object sender, EventArgs e)
        {
            if (PanelDroits.Enabled == true) {
                PanelDroits.Enabled = false;
            }
            else
            {
                PanelDroits.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Form2Model();
            AdminDao.save(admin);
            if (ckActive.Checked)
            {
                DroitDao.save(droit);
            }
            Vider();
            txtNumero.Text = AdminDao.generateKey();
            DataAdminload();
        }

        public void DataAdminload()
        {
            List<Admin> Buss = AdminDao.findAll();

            int i = 0;
            dgAdmin.Rows.Clear();
            foreach (Admin bus in Buss)
            {
                Droits drt = DroitDao.findAdmin(bus.Numero);
                dgAdmin.Rows.Add();
                dgAdmin.Rows[i].Cells[0].Value = bus.Numero;
                dgAdmin.Rows[i].Cells[1].Value = bus.Nom;
                dgAdmin.Rows[i].Cells[2].Value = bus.Prenom;
                dgAdmin.Rows[i].Cells[3].Value = bus.UserName;
                dgAdmin.Rows[i].Cells[4].Value = bus.Password;
                dgAdmin.Rows[i].Cells[5].Value = drt.Consulter;
                dgAdmin.Rows[i].Cells[6].Value = drt.Ajouter;
                dgAdmin.Rows[i].Cells[7].Value = drt.Modifier;
                dgAdmin.Rows[i].Cells[8].Value = drt.Supprimer;
                i++;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Form2Model();
            AdminDao.save(admin);
            Vider();
            txtNumero.Text = AdminDao.generateKey();
            DataAdminload();
        }

        private void ckToutes_CheckedChanged(object sender, EventArgs e)
        {
            if (ckToutes.Checked == true) {
                cbTables.Enabled = false;
                lbTables.Enabled = false;
            }
            else
            {
                cbTables.Enabled = true;
                lbTables.Enabled = true;
            }
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            Vider();
        }
    }
}

