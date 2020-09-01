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

namespace BusBaf.View.Formu
{
    public partial class AddVersemForm : Form
    {
        Versement versement = new Versement();
        public Admin administrateur = null;
        public AddVersemForm()
        {
            InitializeComponent();
        }
        public AddVersemForm(Admin ad)
        {
            InitializeComponent();
            administrateur = ad;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Vider()
        {
            txtNumero.Text = "";
            txtDescrip.Text = "";
            txtMontant.Text = "";
            cbDate.Value = DateTime.Now;
            cbNumeroCarte.SelectedItem = null;
        }
        public void Form2Model()
        {
            versement.Numero = txtNumero.Text;
            versement.Montant = double.Parse(txtMontant.Text);
            versement.Description = txtDescrip.Text;
            versement.Date = cbDate.Value;
            versement.carte = CarteDao.findByNumero(cbNumeroCarte.Text);
            versement.admin = administrateur;
        }

        public void Model2Form( Versement vers)
        {
            versement = vers;
            txtNumero.Text = versement.Numero;
            txtMontant.Text = versement.Montant.ToString();
            txtDescrip.Text = versement.Description;
            cbDate.Value = versement.Date;
            cbNumeroCarte.GetItemText(versement.carte.Numero);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Form2Model();
            VersementDao.save(versement);
            Vider();
            if (LabelTitle.Text == "ENREGISTREMENT VERSEMENT")
            {
                txtNumero.Text = VersementDao.generateKey();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Vider();
            if (LabelTitle.Text == "ENREGISTREMENT VERSEMENT")
            {
                txtNumero.Text = VersementDao.generateKey();
            }
            
        }

        private void AddPayForm_Load(object sender, EventArgs e)
        {
            Dataload1();
            if (LabelTitle.Text == "ENREGISTREMENT VERSEMENT")
            {
                txtNumero.Text = VersementDao.generateKey();
            }
        }

        public void Dataload1()
        {
            List<Carte> Buss = CarteDao.findAll();
            foreach (Carte carte in Buss)
            {
                cbNumeroCarte.Items.Add(carte.Numero);
            }
        }
    }
}
