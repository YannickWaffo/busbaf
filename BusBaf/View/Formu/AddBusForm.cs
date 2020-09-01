using BusBaf.Model;
using BusBaf.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace BusBaf.View.Formu
{
    public partial class AddBusForm : Form
    {
        Bus bus = new Bus();
        public AddBusForm()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lPram);

        public void Form2Model()
        {
            bus.Numero = txtNumero.Text;
            bus.Type = cbType.Text;
            bus.Marque = cbMarque.Text;
            bus.Place = cbPlaces.Text;
            bus.Kilometrage = cbKilometrage.Text;
            bus.Puissance = cbPuissance.Text;
            bus.Energie = cbEnergie.Text;
            bus.DateMise = cbDate.Value;
            bus.CarteGrise = txtCarte.Text;
            bus.Chassis = txtChassis.Text;
        }

        public void Model2Form(Bus bu)
        {
            bus = bu;
            txtNumero.Text = bu.Numero;
            cbType.SelectedValue = bu.Type;
            cbMarque.SelectedValue = bu.Marque.ToString();
            cbPlaces.SelectedValue = bu.Place.ToString();
            cbKilometrage.SelectedValue = bu.Kilometrage.ToString();
            cbPuissance.SelectedValue = bu.Puissance;
            cbEnergie.SelectedValue = bu.Energie;
            cbDate.Value = bu.DateMise;
            txtCarte.Text = bu.CarteGrise;
            txtChassis.Text = bu.Chassis;
        }

        public void Vider()
        {
            bus = null;
            txtNumero.Text = "";
            cbType.SelectedValue = null;
            cbMarque.SelectedValue = null;
            cbPlaces.SelectedValue = null;
            cbKilometrage.SelectedValue = null;
            cbPuissance.SelectedValue = null;
            cbEnergie.SelectedValue = null;
            cbDate.Value = DateTime.Now;
            txtCarte.Text = "";
            txtChassis.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBusForm_Load(object sender, EventArgs e)
        {
            if (LabelTitle.Text == "ENREGISTREMENT BUS")
            {
                txtNumero.Text = BusDao.generateKey();
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Form2Model();
            BusDao.save(bus);
            Vider();
            if (LabelTitle.Text == "ENREGISTREMENT BUS")
            {
                txtNumero.Text = BusDao.generateKey();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Vider();
        }

        private void gunaPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
