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
using BusBaf.View.Formu;
using BusBaf.Dao;

namespace BusBaf.View
{
    public partial class VersementForm : Form
    {
        public Admin administrateur = null;
        public VersementForm()
        {
            InitializeComponent();
        }
        public VersementForm(Admin ad)
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
            
            if (DroitDao.findDroit(administrateur.Numero, "Versement", "Ajouter"))
            {
                AddVersemForm apf = new AddVersemForm(administrateur);
                apf.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vous n\'avez pas ce droit");
            }
        }

        private void PayForm_Load(object sender, EventArgs e)
        {
            DataVersementload();
            
        }
        public void DataVersementload()
        {
            List<Versement> Buss = VersementDao.findAll();
            int i = 0;
            dgVersement.Rows.Clear();
            foreach (Versement versement in Buss)
            {
                dgVersement.Rows.Add();
                dgVersement.Rows[i].Cells[0].Value = versement.Numero;
                dgVersement.Rows[i].Cells[1].Value = versement.Montant;
                dgVersement.Rows[i].Cells[2].Value = versement.Date;
                dgVersement.Rows[i].Cells[3].Value = versement.Description;
                dgVersement.Rows[i].Cells[4].Value = versement.carte.Numero;
                dgVersement.Rows[i].Cells[5].Value = versement.admin.Numero;
                i++;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            

            if (DroitDao.findDroit(administrateur.Numero, "Versement", "Modifier"))
            {
                for (int i = 0; i < dgVersement.RowCount; i++)
                {
                    if ((bool)dgVersement.Rows[i].Selected)
                    {
                        AddVersemForm adf = new AddVersemForm(administrateur);
                        Versement bus = VersementDao.findByNumero(dgVersement.Rows[i].Cells[0].Value.ToString());
                        adf.LabelTitle.Text = "MODIFICATION VERSEMENT";
                        adf.Model2Form(bus);

                        adf.ShowDialog();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vous n\'avez pas ce droit");
            }
        }

        private void dgVersement_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dgVersement.RowCount; i++)
            {
                if ((bool)dgVersement.Rows[i].Selected)
                {
                    AddVersemForm adf = new AddVersemForm(administrateur);
                    Versement bus = VersementDao.findByNumero(dgVersement.Rows[i].Cells[0].Value.ToString());
                    adf.LabelTitle.Text = "MODIFICATION VERSEMENT";
                    adf.Model2Form(bus);

                    adf.ShowDialog();
                }
            }
        }

        private void PayForm_Activated(object sender, EventArgs e)
        {
            DataVersementload();

        }

        private void txtVal_TextChanged(object sender, EventArgs e)
        {
            List<Versement> Buss = VersementDao.findby(txtTab.Text, txtVal.Text);
            int i = 0;
            dgVersement.Rows.Clear();
            foreach (Versement versement in Buss)
            {
                dgVersement.Rows.Add();
                dgVersement.Rows[i].Cells[0].Value = versement.Numero;
                dgVersement.Rows[i].Cells[1].Value = versement.Montant;
                dgVersement.Rows[i].Cells[2].Value = versement.Date;
                dgVersement.Rows[i].Cells[3].Value = versement.Description;
                dgVersement.Rows[i].Cells[4].Value = versement.carte.Numero;
                dgVersement.Rows[i].Cells[5].Value = versement.admin.Numero;
                i++;
            }
        }
    }
}
