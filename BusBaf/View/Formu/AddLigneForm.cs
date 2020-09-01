using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusBaf.Model;
using BusBaf.Dao;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace BusBaf.View.Formu
{
    public partial class AddLigneForm : Form
    {
        Ligne ligne = new Ligne();
        public AddLigneForm()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lPram);

        public void Vider()
        {
            txtNumero.Text = "";
            cbPD.SelectedValue = null;
            cbPF.SelectedValue = null;
            txtDistance.Text = "";
            txtDescrip.Text = "";
            cbEtat.SelectedValue = null;
        }

        public void Form2Model()
        {
            ligne.Numero = txtNumero.Text;
            ligne.Description = txtDescrip.Text;
            ligne.Distance = txtDistance.Text;
            ligne.Etat = cbEtat.Text;
            ligne.PointD = cbPD.Text;
            ligne.PointF = cbPF.Text;
        }

        public void Model2Form(Ligne lig)
        {
            ligne = lig;
            txtNumero.Text = lig.Numero;
            txtDescrip.Text = lig.Description;
            txtDistance.Text = lig.Distance;
            cbEtat.SelectedItem = lig.Etat;
            cbPD.SelectedItem = lig.PointD;
            cbPF.SelectedItem = lig.PointF;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Vider();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Form2Model();
            LigneDao.save(ligne);
            Vider();
            txtNumero.Text = LigneDao.generateKey();
        }

        private void AddLigneForm_Load(object sender, EventArgs e)
        {
            if (ligne.Id == 0) {
                txtNumero.Text = LigneDao.generateKey();
            }
        }

        private void gunaPanel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
