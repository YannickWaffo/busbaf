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
    public partial class AddAttribuerForm : Form
    {
        Attribuer attribuer = new Attribuer();
        public AddAttribuerForm()
        {
            InitializeComponent();

        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lPram);


        public void Form2Model()
        {
            attribuer.Numero = txtNumero.Text;
            attribuer.DateDebut = cbdateD.Value;
            attribuer.DateFin = cbdateF.Value;
            attribuer.bus = BusDao.findByNumero(cbBus.Text);
            attribuer.chauffeur = ChauffeurDao.findByNumero(cbChauffeur.Text);
        }

        public void Model2Form()
        {

        }

        public void Vider()
        {
            txtNumero.Text = "";
            txtPreChau.Text = "";
            txtCartBus.Text = "";
            txtMarqBus.Text = "";
            txtNomChau.Text = "";
            txtMarqBus.Text = "";
            txtPreChau.Text = "";
            cbdateD.Value = DateTime.Now;
            cbdateF.Value = DateTime.Now;
            cbBus.SelectedValue = null;
            cbChauffeur.SelectedValue = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaPanel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AddAttribuerForm_Load(object sender, EventArgs e)
        {
            txtNumero.Text = AttibuerDao.generateKey();
            loadCombo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Form2Model();
            AttibuerDao.save(attribuer);
            Vider();
            txtNumero.Text = AttibuerDao.generateKey();
        }

        public void loadCombo()
        {
            List<Bus> buss = BusDao.findAll();
            cbBus.Items.Clear();
            foreach(Bus bus in buss)
            {
                cbBus.Items.Add(bus.Numero);
            }

            List<Chauffeur> chaus = ChauffeurDao.findAll();
            cbChauffeur.Items.Clear();
            foreach (Chauffeur chau in chaus)
            {
                cbChauffeur.Items.Add(chau.Numero);
            }
        }

        private void cbBus_SelectedValueChanged(object sender, EventArgs e)
        {
            Bus bus = BusDao.findByNumero(cbBus.Text);
            txtMarqBus.Text = bus.Marque;
            txtCartBus.Text = bus.CarteGrise;
        }

        private void cbChauffeur_SelectedValueChanged(object sender, EventArgs e)
        {
            Chauffeur chau = ChauffeurDao.findByNumero(cbChauffeur.Text);
            txtNomChau.Text = chau.Nom;
            txtPreChau.Text = chau.Prenom;
        }
    }
}
