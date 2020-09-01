using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusBaf.Model;
using BusBaf.Dao;
using System.Runtime.InteropServices;

namespace BusBaf.View.Formu
{
    public partial class AddCarteForm : Form
    {
        Carte carte = new Carte();
        public AddCarteForm()
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
            txtCode.Text = "";
            txtSolde.Text = "";
            txtSoldeMin.Text = "";
            txtPorteur.Text = "";
            cdDateDebut.Value = DateTime.Now;
            cdDateFin.Value = DateTime.Now;
        }
        public void Form2Model()
        {
            carte.Numero = txtNumero.Text;
            carte.DateCreation = cdDateDebut.Value;
            carte.DateExpiration = cdDateFin.Value;
            carte.Code = txtCode.Text;
            carte.Porteur = txtPorteur.Text;
            carte.Solde = double.Parse(txtSolde.Text);
            carte.SoldeMin = double.Parse(txtSoldeMin.Text);

        }
        public void Model2Form( Carte cart)
        {
            carte = cart;
            txtNumero.Text = cart.Numero;
            cdDateDebut.Value = cart.DateCreation;
            cdDateFin.Value = cart.DateCreation;
            txtCode.Text = cart.Code;
            cbType.SelectedItem = cart.Type;
            txtPorteur.Text = cart.Porteur;
            txtSolde.Text = cart.Solde.ToString();
            txtSoldeMin.Text = cart.SoldeMin.ToString();
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
            CarteDao.save(carte);
            Vider();
            txtNumero.Text = CarteDao.generateKey();
        }

        private void AddCarteForm_Load(object sender, EventArgs e)
        {
            if (carte.Id == 0) {
                txtNumero.Text = CarteDao.generateKey();
            }
        }

        private void gunaPanel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
