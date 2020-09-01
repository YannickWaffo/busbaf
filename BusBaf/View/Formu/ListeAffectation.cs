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
    public partial class ListeAffectation : Form
    {
        public ListeAffectation()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void DataAffectload()
        {
            List<Affecter> Buss = AffecterDao.findAll();
            int i = 0;
            dgAffectation.Rows.Clear();
            foreach (Affecter bus in Buss)
            {
                dgAffectation.Rows.Add();
                dgAffectation.Rows[i].Cells[0].Value = bus.Numero;
                dgAffectation.Rows[i].Cells[1].Value = bus.DateDebut;
                dgAffectation.Rows[i].Cells[2].Value = bus.DateFin;
                dgAffectation.Rows[i].Cells[3].Value = bus.ligne.Numero;
                dgAffectation.Rows[i].Cells[4].Value = bus.bus.Numero;
                i++;
            }
        }

        private void ListeAffectation_Load(object sender, EventArgs e)
        {
            DataAffectload();
        }
    }
}
