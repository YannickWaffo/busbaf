using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusBaf.View.Formu;
using BusBaf.Model;
using BusBaf.Dao;

namespace BusBaf.View
{
    public partial class CarteForm : Form
    {
        Admin administrateur = null;
        public CarteForm()
        {
            InitializeComponent();
        }
        public CarteForm(Admin ad)
        {
            InitializeComponent();
            administrateur = ad;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DroitDao.findDroit(administrateur.Numero, "Carte", "Ajouter"))
            {
                AddCarteForm acf = new AddCarteForm();
                acf.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vous n\'avez pas ce droit");
            }
        }

        private void CarteForm_Load(object sender, EventArgs e)
        {
            DataCartesload();
        }

        public void DataCartesload()
        {
            List<Carte> Buss = CarteDao.findAll();
            int i = 0;
            dgCartes.Rows.Clear();
            foreach (Carte carte in Buss)
            {
                dgCartes.Rows.Add();
                dgCartes.Rows[i].Cells[0].Value = carte.Numero;
                dgCartes.Rows[i].Cells[1].Value = carte.Porteur;
                dgCartes.Rows[i].Cells[2].Value = carte.Solde;
                dgCartes.Rows[i].Cells[3].Value = carte.SoldeMin;
                dgCartes.Rows[i].Cells[4].Value = carte.Type;
                dgCartes.Rows[i].Cells[5].Value = carte.Code;
                dgCartes.Rows[i].Cells[6].Value = carte.DateCreation;
                dgCartes.Rows[i].Cells[7].Value = carte.DateExpiration;
                i++;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (DroitDao.findDroit(administrateur.Numero, "Carte", "Modifier"))
            {
                for (int i = 0; i < dgCartes.RowCount; i++)
                {
                    if ((bool)dgCartes.Rows[i].Selected)
                    {
                        AddCarteForm adf = new AddCarteForm();
                        Carte carte = CarteDao.findByNumero(dgCartes.Rows[i].Cells[0].Value.ToString());
                        adf.Model2Form(carte);

                        adf.ShowDialog();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vous n\'avez pas ce droit");
            }

            
        }

        private void dgCartes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dgCartes.RowCount; i++)
            {
                if ((bool)dgCartes.Rows[i].Selected)
                {
                    AddCarteForm adf = new AddCarteForm();
                    Carte carte = CarteDao.findByNumero(dgCartes.Rows[i].Cells[0].Value.ToString());
                    adf.Model2Form(carte);

                    adf.ShowDialog();
                }
            }
        }

        private void CarteForm_Activated(object sender, EventArgs e)
        {
            DataCartesload();
        }

        private void btnRechage_Click(object sender, EventArgs e)
        {
            RechageForm rf = new RechageForm();
            rf.ShowDialog();
        }

        private void txtVal_TextChanged(object sender, EventArgs e)
        {
            List<Carte> Buss = CarteDao.findby(cbtab.Text, txtVal.Text);
            int i = 0;
            dgCartes.Rows.Clear();
            foreach (Carte carte in Buss)
            {
                dgCartes.Rows.Add();
                dgCartes.Rows[i].Cells[0].Value = carte.Numero;
                dgCartes.Rows[i].Cells[1].Value = carte.Porteur;
                dgCartes.Rows[i].Cells[2].Value = carte.Solde;
                dgCartes.Rows[i].Cells[3].Value = carte.SoldeMin;
                dgCartes.Rows[i].Cells[4].Value = carte.Type;
                dgCartes.Rows[i].Cells[5].Value = carte.Code;
                dgCartes.Rows[i].Cells[6].Value = carte.DateCreation;
                dgCartes.Rows[i].Cells[7].Value = carte.DateExpiration;
                i++;
            }
        }
    }
}
