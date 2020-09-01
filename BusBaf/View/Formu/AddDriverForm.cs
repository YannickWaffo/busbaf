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
using System.Runtime.InteropServices;

namespace BusBaf.View.Formu
{
    public partial class AddDriverForm : Form
    {
        Chauffeur chauffeur = new Chauffeur();
        public AddDriverForm()
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
            txtNom.Text = "";
            txtNumero.Text = "";
            txtPrenom.Text = "";
            txtTelephone.Text = "";
            txtPermis.Text = "";
            txtAdresse.Text = "";
            cbDate.Value = DateTime.Now;
            cbStatus.SelectedValue = null;
        }

        public void Form2Model()
        {
            
            chauffeur.Numero = txtNumero.Text;
            chauffeur.Nom = txtNom.Text;
            chauffeur.Prenom = txtPrenom.Text;
            chauffeur.DateNais = cbDate.Value;
            chauffeur.Telephone = txtTelephone.Text;
            chauffeur.Adresse = txtAdresse.Text;
            chauffeur.Permis = txtPermis.Text;
            chauffeur.Status = cbStatus.Text;

        }
        public void Model2Form(Chauffeur chauf)
        {
            chauffeur = chauf;
            txtNumero.Text = chauf.Numero;
            txtNom.Text = chauf.Nom;
            txtPrenom.Text = chauf.Numero;
            cbDate.Value = chauf.DateNais;
            txtTelephone.Text = chauf.Telephone;
            txtAdresse.Text = chauf.Adresse;
            txtPermis.Text = chauf.Permis;
            cbStatus.SelectedValue = chauf.Status;
        }

        private void btnImageSelect_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Title = "Ouvrir Image";
            dialog.Filter = "png files (*.png)|*.png";

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                pic.ImageLocation = dialog.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Form2Model();
            ChauffeurDao.save(chauffeur);
            Vider();
            txtNumero.Text = ChauffeurDao.generateKey();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Vider();
        }

        public string TextNumero{
            get { return txtNumero.Text; }
            set { txtNumero.Text = value; }
        }

        private void AddDriverForm_Load(object sender, EventArgs e)
        {
            if(chauffeur.Id == 0)
            {
                txtNumero.Text = ChauffeurDao.generateKey();
            }
        }

        private void gunaPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
