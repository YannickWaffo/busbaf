using BusBaf.Dao;
using BusBaf.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusBaf.View.Formu
{
    public partial class RechageForm : Form
    {
        Carte carte = new Carte();
        public RechageForm()
        {
            InitializeComponent();
        }

        public void Vider()
        {
            txtNumero.Text = "";
            txtSolde.Text = "";
            txtMontant.Text = "";
            txtPorteur.Text = "";
        }
        public void Form2Model()
        {
            carte.Numero = txtNumero.Text;
            carte.Porteur = txtPorteur.Text;
            carte.Solde = double.Parse(txtSolde.Text);

        }
        public void Model2Form(Carte cart)
        {
            carte = cart;
            txtNumero.Text = cart.Numero;
            txtPorteur.Text = cart.Porteur;
            txtSolde.Text = cart.Solde.ToString();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMontant_TextChanged(object sender, EventArgs e)
        {
            if (txtMontant.Text != "")
            {
                double sol = Double.Parse(txtSolde.Text) + Double.Parse(txtMontant.Text);
                txtSolde.Text = sol.ToString();
            }
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            Carte cart = CarteDao.findByNumero(txtNumero.Text);
            if(cart != null)
            {
                txtPorteur.Text = cart.Porteur;
                txtSolde.Text = cart.Solde.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Form2Model();
            CarteDao.Recharge(carte);
            Vider();
        }
    }
}
