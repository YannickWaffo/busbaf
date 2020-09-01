using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusBaf.View;
using BusBaf.View.Formu;
using BusBaf.Model;
using BusBaf.Dao;

namespace BusBaf.View
{
    public partial class BusForm : Form
    {
        public Admin administrateur = null;
        public BusForm()
        {
            InitializeComponent();
        }

        public BusForm(Admin ad)
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
            if (DroitDao.findDroit(administrateur.Numero, "Bus", "Ajouter"))
            {
                AddBusForm abf = new AddBusForm();
                abf.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vous n\'avez pas ce droit");
            }

            
        }


        public void DataBusload()
        {
            List<Bus> Buss = BusDao.findAll();
            int i = 0;
            dgBus.Rows.Clear();
            foreach (Bus bus in Buss)
            {
                dgBus.Rows.Add();
                dgBus.Rows[i].Cells[0].Value = bus.Numero;
                dgBus.Rows[i].Cells[1].Value = bus.Type;
                dgBus.Rows[i].Cells[2].Value = bus.Marque;
                dgBus.Rows[i].Cells[3].Value = bus.Place;
                dgBus.Rows[i].Cells[4].Value = bus.Kilometrage;
                dgBus.Rows[i].Cells[5].Value = bus.Puissance;
                dgBus.Rows[i].Cells[6].Value = bus.Energie;
                dgBus.Rows[i].Cells[7].Value = bus.DateMise;
                dgBus.Rows[i].Cells[8].Value = bus.CarteGrise;
                dgBus.Rows[i].Cells[9].Value = bus.Chassis;
                i++;
            }
        }

        private void BusForm_Load(object sender, EventArgs e)
        {
            DataBusload();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAffecter_Click(object sender, EventArgs e)
        {
            AddAffecterForm aft = new AddAffecterForm();
            aft.ShowDialog();
        }

        private void btnListeAffectation_Click(object sender, EventArgs e)
        {
            ListeAffectation laff = new ListeAffectation();
            laff.ShowDialog();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {

            if (DroitDao.findDroit(administrateur.Numero, "Bus", "Modifier"))
            {
                for (int i = 0; i < dgBus.RowCount; i++)
                {
                    if ((bool)dgBus.Rows[i].Selected)
                    {
                        AddBusForm adf = new AddBusForm();
                        Bus bus = BusDao.findByNumero(dgBus.Rows[i].Cells[0].Value.ToString());
                        adf.LabelTitle.Text = "MODIFICATION BUS";
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

        private void dgBus_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dgBus.RowCount; i++)
            {
                if ((bool)dgBus.Rows[i].Selected)
                {
                    AddBusForm adf = new AddBusForm();
                    Bus bus = BusDao.findByNumero(dgBus.Rows[i].Cells[0].Value.ToString());
                    adf.LabelTitle.Text = "MODIFICATION BUS";
                    adf.Model2Form(bus);

                    adf.ShowDialog();
                }
            }
        }

        private void BusForm_Activated(object sender, EventArgs e)
        {
            DataBusload();
        }

        private void btnPaie_Click(object sender, EventArgs e)
        {
            ListePaiement lp = new ListePaiement();
            lp.ShowDialog();
        }
    }
}
