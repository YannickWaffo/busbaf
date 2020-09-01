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

namespace BusBaf.View
{
    public partial class MenuForm2 : Form
    {
        public Admin administrateur = null;
        public MenuForm2()
        {
            InitializeComponent();
        }
        public MenuForm2(Admin ad)
        {
            InitializeComponent();
            administrateur = ad;
        }

        private void ucItPay_Click(object sender, EventArgs e)
        {
            VersementForm paf = new VersementForm(administrateur);
            paf.ShowDialog();
        }

        private void ucItCarte_Click(object sender, EventArgs e)
        {
            CarteForm cf = new CarteForm(administrateur);
            cf.ShowDialog();
        }

        private void ucItBus_Click(object sender, EventArgs e)
        {
            BusForm bf = new BusForm(administrateur);
            bf.ShowDialog();
        }

        private void ucItDriver_Click(object sender, EventArgs e)
        {
            DriverForm df = new DriverForm(administrateur);
            df.ShowDialog();
        }

        private void ucItLigne_Click(object sender, EventArgs e)
        {
            LigneForm lf = new LigneForm(administrateur);
            lf.ShowDialog();
        }

        private void ucItPoint_Click(object sender, EventArgs e)
        {
            PointForm pf = new PointForm();
            pf.ShowDialog();
        }

        private void ucItUser_Click(object sender, EventArgs e)
        {
            AdminForm uf = new AdminForm();
            uf.ShowDialog();
        }

        private void ucItHistorique_Click(object sender, EventArgs e)
        {
            HistForm hf = new HistForm();
            hf.ShowDialog();
        }

        private void MenuForm2_Load(object sender, EventArgs e)
        {

        }

        private void MenuForm2_Activated(object sender, EventArgs e)
        {
            
        }

        private void ucItCarte_Load(object sender, EventArgs e)
        {

        }
    }
}
