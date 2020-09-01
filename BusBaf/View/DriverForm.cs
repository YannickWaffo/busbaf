using BusBaf.Dao;
using BusBaf.Model;
using BusBaf.View.Formu;
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
    public partial class DriverForm : Form
    {
        public Admin administrateur = null;
        public DriverForm()
        {
            InitializeComponent();
        }
        public DriverForm(Admin ad)
        {
            InitializeComponent();
            administrateur = ad;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DriverForm_Load(object sender, EventArgs e)
        {
            DataDriversload();
        }
        public void DataDriversload()
        {
            List<Chauffeur> Buss = ChauffeurDao.findAll();
            int i = 0;
            dgDriver.Rows.Clear();
            foreach (Chauffeur chauffeur in Buss)
            {
                dgDriver.Rows.Add();
                dgDriver.Rows[i].Cells[0].Value = chauffeur.Numero;
                dgDriver.Rows[i].Cells[1].Value = chauffeur.Nom;
                dgDriver.Rows[i].Cells[2].Value = chauffeur.Prenom;
                dgDriver.Rows[i].Cells[3].Value = chauffeur.DateNais;
                dgDriver.Rows[i].Cells[4].Value = chauffeur.Telephone;
                dgDriver.Rows[i].Cells[5].Value = chauffeur.Adresse;
                dgDriver.Rows[i].Cells[6].Value = chauffeur.Permis;
                dgDriver.Rows[i].Cells[7].Value = chauffeur.Status;
                i++;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (DroitDao.findDroit(administrateur.Numero, "Chauffeur", "Ajouter"))
            {
                AddDriverForm adf = new AddDriverForm();
                adf.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vous n\'avez pas ce droit");
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgDriver.RowCount;i++)
            {
                if((bool)dgDriver.Rows[i].Selected)
                {
                    AddDriverForm adf = new AddDriverForm();
                    Chauffeur chauffeur = ChauffeurDao.findByNumero(dgDriver.Rows[i].Cells[0].Value.ToString());
                    adf.Model2Form(chauffeur);
                   
                    adf.ShowDialog();
                }
            }
            
        }

        private void DriverForm_Activated(object sender, EventArgs e)
        {
            DataDriversload();
        }

        private void dgDriver_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgDriver_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DroitDao.findDroit(administrateur.Numero, "Chauffeur", "Modifier"))
            {
                for (int i = 0; i < dgDriver.RowCount; i++)
                {
                    if ((bool)dgDriver.Rows[i].Selected)
                    {
                        AddDriverForm adf = new AddDriverForm();
                        Chauffeur chauffeur = ChauffeurDao.findByNumero(dgDriver.Rows[i].Cells[0].Value.ToString());
                        adf.Model2Form(chauffeur);

                        adf.ShowDialog();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vous n\'avez pas ce droit");
            }
            
        }

        private void btnAttribuer_Click(object sender, EventArgs e)
        {
            AddAttribuerForm aaf = new AddAttribuerForm();
            aaf.ShowDialog();
        }

        private void btnListeAttribuer_Click(object sender, EventArgs e)
        {
            ListeAttribution la = new ListeAttribution();
            la.ShowDialog();
        }

        private void txtRech_TextChanged(object sender, EventArgs e)
        {
            List<Chauffeur> Buss = ChauffeurDao.findby(cbTab.Text, txtRech.Text);
            int i = 0;
            dgDriver.Rows.Clear();
            foreach (Chauffeur chauffeur in Buss)
            {
                dgDriver.Rows.Add();
                dgDriver.Rows[i].Cells[0].Value = chauffeur.Numero;
                dgDriver.Rows[i].Cells[1].Value = chauffeur.Nom;
                dgDriver.Rows[i].Cells[2].Value = chauffeur.Prenom;
                dgDriver.Rows[i].Cells[3].Value = chauffeur.DateNais;
                dgDriver.Rows[i].Cells[4].Value = chauffeur.Telephone;
                dgDriver.Rows[i].Cells[5].Value = chauffeur.Adresse;
                dgDriver.Rows[i].Cells[6].Value = chauffeur.Permis;
                dgDriver.Rows[i].Cells[7].Value = chauffeur.Status;
                i++;
            }
        }
    }
}
