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
    public partial class AddAffecterForm : Form
    {
        Affecter affecter = new Affecter();
        public AddAffecterForm()
        {
            InitializeComponent();
        }

        public void Form2Model()
        {
            affecter.Numero = txtNumero.Text;
            affecter.DateDebut = cbDateD.Value;
            affecter.DateFin = cbDateF.Value;
            affecter.bus = BusDao.findByNumero(cbBus.Text);
            affecter.ligne = LigneDao.findByNumero(cbLigne.Text);
        }

        public void Model2Form()
        {

        }

        public void Vider()
        {
            txtNumero.Text = "";
            txtMarqBus.Text = "";
            txtCartBus.Text = "";
            cbDateD.Value = DateTime.Now;
            cbDateF.Value = DateTime.Now;
            cbBus.SelectedValue = null;
            cbLigne.SelectedValue = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        public void loadCombo()
        {
            List<Bus> buss = BusDao.findAll();
            cbBus.Items.Clear();
            foreach (Bus bus in buss)
            {
                cbBus.Items.Add(bus.Numero);
            }

            List<Ligne> chaus = LigneDao.findAll();
            cbLigne.Items.Clear();
            foreach (Ligne chau in chaus)
            {
                cbLigne.Items.Add(chau.Numero);
            }
        }

        private void AddAffecterForm_Load(object sender, EventArgs e)
        {
            loadCombo();
            txtNumero.Text = AffecterDao.generateKey();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Form2Model();
            AffecterDao.save(affecter);
            Vider();
            txtNumero.Text = AffecterDao.generateKey();
        }

        private void cbBus_SelectedValueChanged(object sender, EventArgs e)
        {
            Bus bus = BusDao.findByNumero(cbBus.Text);
            txtMarqBus.Text = bus.Marque;
            txtCartBus.Text = bus.CarteGrise;
        }
    }
}
