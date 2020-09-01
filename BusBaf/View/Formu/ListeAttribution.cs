using BusBaf.Dao;
using BusBaf.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BusBaf.View.Formu
{
    public partial class ListeAttribution : Form
    {
        public ListeAttribution()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void DataAttribload()
        {
            List<Attribuer> Buss = AttibuerDao.findAll();
            int i = 0;
            dgAttribution.Rows.Clear();
            foreach (Attribuer bus in Buss)
            {
                dgAttribution.Rows.Add();
                dgAttribution.Rows[i].Cells[0].Value = bus.Numero;
                dgAttribution.Rows[i].Cells[1].Value = bus.DateDebut;
                dgAttribution.Rows[i].Cells[2].Value = bus.DateFin;
                dgAttribution.Rows[i].Cells[3].Value = bus.chauffeur.Numero;
                dgAttribution.Rows[i].Cells[4].Value = bus.bus.Numero;
                i++;
            }
        }

        private void ListeAttribution_Load(object sender, EventArgs e)
        {
            DataAttribload();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }
}
