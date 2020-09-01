using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusBaf.View
{
    public partial class UCItemMenu : UserControl
    {
        public UCItemMenu()
        {
            InitializeComponent();
        }

        private void UCItemMenu_Load(object sender, EventArgs e)
        {

        }

        public Image ChangePic
        {
            get
            {
                return picBox.Image;
            }
            set
            {
                picBox.Image = value;
            }
        }

        public string ChangeName
        {
            get
            {
                return LabelName.Text;
            }
            set
            {
                LabelName.Text = value;
            }
        }
        public string ChangeDesc
        {
            get
            {
                return LabelDescription.Text;
            }
            set
            {
                LabelDescription.Text = value;
            }
        }

        public new event EventHandler Click
        {
            add
            {
                base.Click += value;
                foreach (Control control in Controls)
                {
                    control.Click += value;
                }
            }
            remove
            {
                base.Click -= value;
                foreach (Control control in Controls)
                {
                    control.Click -= value;
                }
            }
        }

        private void picBox_Click(object sender, EventArgs e)
        {
            base.OnClick(e);
        }

        private void LabelName_Click(object sender, EventArgs e)
        {
            base.OnClick(e);
        }

        private void LabelDescription_Click(object sender, EventArgs e)
        {
            base.OnClick(e);
        }
    }
}
