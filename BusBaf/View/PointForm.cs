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
    public partial class PointForm : Form
    {
        public PointForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void DataPointsload()
        {
            List<Points> Buss = PointDao.findAll();
            int i = 0;
            dgPoints.Rows.Clear();
            foreach (Points point in Buss)
            {
                dgPoints.Rows.Add();
                dgPoints.Rows[i].Cells[0].Value = point.Numero;
                dgPoints.Rows[i].Cells[1].Value = point.Description;
                dgPoints.Rows[i].Cells[2].Value = point.coordonnee;
                dgPoints.Rows[i].Cells[3].Value = point.Etat;
                dgPoints.Rows[i].Cells[4].Value = point.ligne.Numero;
                i++;
            }
        }

        private void PointForm_Load(object sender, EventArgs e)
        {
            DataPointsload();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddPointForm apf = new AddPointForm();
            apf.ShowDialog();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgPoints.RowCount; i++)
            {
                if ((bool)dgPoints.Rows[i].Selected)
                {
                    AddPointForm adf = new AddPointForm();
                    Points bus = PointDao.findByNumero(dgPoints.Rows[i].Cells[0].Value.ToString());
                    adf.Model2Form(bus);

                    adf.ShowDialog();
                }
            }
        }

        private void dgPoints_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dgPoints.RowCount; i++)
            {
                if ((bool)dgPoints.Rows[i].Selected)
                {
                    AddPointForm adf = new AddPointForm();
                    Points bus = PointDao.findByNumero(dgPoints.Rows[i].Cells[0].Value.ToString());
                    adf.Model2Form(bus);

                    adf.ShowDialog();
                }
            }
        }

        private void PointForm_Activated(object sender, EventArgs e)
        {
            DataPointsload();
        }
    }
}
