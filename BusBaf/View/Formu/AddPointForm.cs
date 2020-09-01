using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusBaf.Dao;
using BusBaf.Model;
using System.Runtime.InteropServices;

namespace BusBaf.View.Formu
{
    public partial class AddPointForm : Form
    {
        Points point = new Points();
        public AddPointForm()
        {
            InitializeComponent();

        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lPram);



        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        public void Vider()
        {
            txtNumero.Text = "";
            txtCoord.Text = "";
            txtDescrip.Text = "";
            cbEtat.SelectedItem = null;
            cbLigne.SelectedItem = null;
        }
        public void Form2Model()
        {
            point.Numero = txtNumero.Text;
            point.coordonnee = txtCoord.Text;
            point.Description = txtDescrip.Text;
            point.Etat = cbEtat.Text;
            point.ligne = LigneDao.findByNumero(cbLigne.Text);
        }

        public void Model2Form(Points pt)
        {
            point = pt;
            txtNumero.Text = point.Numero;
            txtCoord.Text = point.coordonnee;
            txtDescrip.Text = point.Description;
            cbEtat.Text = point.Etat;
            cbLigne.Text = point.ligne.Numero.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Vider();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Form2Model();
            PointDao.save(point);
            Vider();
            txtNumero.Text = PointDao.generateKey();
        }

        

        private void AddPointForm_Load(object sender, EventArgs e)
        {
            if (point.Id == 0) {
                txtNumero.Text = PointDao.generateKey();
            }
            DataLigneload();
        }

        private void gunaPanel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void DataLigneload()
        {
            List<Ligne> Buss = LigneDao.findAll();

            foreach (Ligne ligne in Buss)
            {
                cbLigne.Items.Add(ligne.Numero);
            }
        }
    }
}
