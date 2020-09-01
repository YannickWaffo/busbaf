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
using BusBaf.Dao;
using BusBaf.Model;

namespace BusBaf.View
{
    public partial class LigneForm : Form
    {
        Admin administrateur = null;
        public LigneForm()
        {
            InitializeComponent();
        }
        public LigneForm(Admin ad)
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
            if (DroitDao.findDroit(administrateur.Numero, "Ligne", "Ajouter"))
            {
                AddLigneForm alf = new AddLigneForm();
                alf.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vous n\'avez pas ce droit");
            }
            
        }

        private void LigneForm_Load(object sender, EventArgs e)
        {
            DataLignesload();
        }
        public void DataLignesload()
        {
            List<Ligne> Buss = LigneDao.findAll();
            int i = 0;
            dgLigne.Rows.Clear();
            foreach (Ligne ligne in Buss)
            {
                dgLigne.Rows.Add();
                dgLigne.Rows[i].Cells[0].Value = ligne.Numero;
                dgLigne.Rows[i].Cells[1].Value = ligne.Description;
                dgLigne.Rows[i].Cells[2].Value = ligne.Etat;
                dgLigne.Rows[i].Cells[3].Value = ligne.Distance;
                dgLigne.Rows[i].Cells[4].Value = ligne.PointD;
                dgLigne.Rows[i].Cells[5].Value = ligne.PointF;
                i++;
            }
        }

        private void btnChance_Click(object sender, EventArgs e)
        {
            if (DroitDao.findDroit(administrateur.Numero, "Ligne", "Modifier"))
            {
                for (int i = 0; i < dgLigne.RowCount; i++)
                {
                    if ((bool)dgLigne.Rows[i].Selected)
                    {
                        AddLigneForm alf = new AddLigneForm();
                        Ligne ligne = LigneDao.findByNumero(dgLigne.Rows[i].Cells[0].Value.ToString());
                        alf.Model2Form(ligne);

                        alf.ShowDialog();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vous n\'avez pas ce droit");
            }

            
        }

        private void LigneForm_Activated(object sender, EventArgs e)
        {
            DataLignesload();
        }

        private void dgLigne_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dgLigne.RowCount; i++)
            {
                if ((bool)dgLigne.Rows[i].Selected)
                {
                    AddLigneForm alf = new AddLigneForm();
                    Ligne ligne = LigneDao.findByNumero(dgLigne.Rows[i].Cells[0].Value.ToString());
                    alf.Model2Form(ligne);

                    alf.ShowDialog();
                }
            }
        }

        private void txtRech_TextChanged(object sender, EventArgs e)
        {
            List<Ligne> Buss = LigneDao.findby(cbTab.Text,txtRech.Text);
            int i = 0;
            dgLigne.Rows.Clear();
            foreach (Ligne ligne in Buss)
            {
                dgLigne.Rows.Add();
                dgLigne.Rows[i].Cells[0].Value = ligne.Numero;
                dgLigne.Rows[i].Cells[1].Value = ligne.Description;
                dgLigne.Rows[i].Cells[2].Value = ligne.Etat;
                dgLigne.Rows[i].Cells[3].Value = ligne.Distance;
                dgLigne.Rows[i].Cells[4].Value = ligne.PointD;
                dgLigne.Rows[i].Cells[5].Value = ligne.PointF;
                i++;
            }
        }
    }
}
