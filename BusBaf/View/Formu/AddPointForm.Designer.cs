namespace BusBaf.View.Formu
{
    partial class AddPointForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPointForm));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel4 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.btnExit = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnReset = new Guna.UI.WinForms.GunaButton();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtCoord = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.cbEtat = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtDescrip = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.cbLigne = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.txtNumero = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 0;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.Coral;
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(5, 572);
            this.gunaPanel1.TabIndex = 0;
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.BackColor = System.Drawing.Color.Coral;
            this.gunaPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaPanel3.Location = new System.Drawing.Point(509, 0);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(5, 572);
            this.gunaPanel3.TabIndex = 0;
            // 
            // gunaPanel4
            // 
            this.gunaPanel4.BackColor = System.Drawing.Color.Coral;
            this.gunaPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel4.Location = new System.Drawing.Point(5, 567);
            this.gunaPanel4.Name = "gunaPanel4";
            this.gunaPanel4.Size = new System.Drawing.Size(504, 5);
            this.gunaPanel4.TabIndex = 0;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.White;
            this.gunaPanel2.Controls.Add(this.btnExit);
            this.gunaPanel2.Controls.Add(this.gunaLabel1);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel2.Location = new System.Drawing.Point(5, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(504, 49);
            this.gunaPanel2.TabIndex = 9;
            this.gunaPanel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gunaPanel2_MouseDown);
            // 
            // btnExit
            // 
            this.btnExit.AnimationHoverSpeed = 0.07F;
            this.btnExit.AnimationSpeed = 0.03F;
            this.btnExit.BaseColor = System.Drawing.Color.Black;
            this.btnExit.BorderColor = System.Drawing.Color.Black;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FocusedColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::BusBaf.Properties.Resources.icons8_delete_250px;
            this.btnExit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExit.Location = new System.Drawing.Point(464, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.Red;
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExit.OnHoverImage = global::BusBaf.Properties.Resources.icons8_delete_250px_11;
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(40, 49);
            this.btnExit.TabIndex = 6;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Impact", 20F);
            this.gunaLabel1.Location = new System.Drawing.Point(12, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(79, 34);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "POINT";
            // 
            // btnReset
            // 
            this.btnReset.AnimationHoverSpeed = 0.07F;
            this.btnReset.AnimationSpeed = 0.03F;
            this.btnReset.BaseColor = System.Drawing.Color.Coral;
            this.btnReset.BorderColor = System.Drawing.Color.Black;
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReset.FocusedColor = System.Drawing.Color.Empty;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReset.ImageSize = new System.Drawing.Size(20, 20);
            this.btnReset.Location = new System.Drawing.Point(373, 497);
            this.btnReset.Name = "btnReset";
            this.btnReset.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnReset.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReset.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReset.OnHoverImage = null;
            this.btnReset.OnPressedColor = System.Drawing.Color.Black;
            this.btnReset.Size = new System.Drawing.Size(106, 51);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "ANNULLER";
            this.btnReset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.AnimationHoverSpeed = 0.07F;
            this.btnSave.AnimationSpeed = 0.03F;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BaseColor = System.Drawing.Color.Black;
            this.btnSave.BorderColor = System.Drawing.Color.Black;
            this.btnSave.BorderSize = 3;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.FocusedColor = System.Drawing.Color.Empty;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSave.Location = new System.Drawing.Point(32, 497);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Size = new System.Drawing.Size(319, 51);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "ENREGISTRER";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(52, 173);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(73, 15);
            this.gunaLabel2.TabIndex = 10;
            this.gunaLabel2.Text = "Coordonnee";
            // 
            // txtCoord
            // 
            this.txtCoord.BaseColor = System.Drawing.Color.White;
            this.txtCoord.BorderColor = System.Drawing.Color.Silver;
            this.txtCoord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCoord.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCoord.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCoord.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCoord.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCoord.Location = new System.Drawing.Point(162, 158);
            this.txtCoord.Name = "txtCoord";
            this.txtCoord.PasswordChar = '\0';
            this.txtCoord.Size = new System.Drawing.Size(283, 40);
            this.txtCoord.TabIndex = 11;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(56, 224);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(27, 15);
            this.gunaLabel3.TabIndex = 10;
            this.gunaLabel3.Text = "Etat";
            // 
            // cbEtat
            // 
            this.cbEtat.BackColor = System.Drawing.Color.Transparent;
            this.cbEtat.BaseColor = System.Drawing.Color.White;
            this.cbEtat.BorderColor = System.Drawing.Color.Silver;
            this.cbEtat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbEtat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEtat.FocusedColor = System.Drawing.Color.Empty;
            this.cbEtat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbEtat.ForeColor = System.Drawing.Color.Black;
            this.cbEtat.FormattingEnabled = true;
            this.cbEtat.Items.AddRange(new object[] {
            "Actif",
            "Inactif"});
            this.cbEtat.Location = new System.Drawing.Point(162, 219);
            this.cbEtat.Name = "cbEtat";
            this.cbEtat.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbEtat.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbEtat.Size = new System.Drawing.Size(189, 26);
            this.cbEtat.TabIndex = 12;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(52, 281);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(67, 15);
            this.gunaLabel4.TabIndex = 10;
            this.gunaLabel4.Text = "Description";
            // 
            // txtDescrip
            // 
            this.txtDescrip.BaseColor = System.Drawing.Color.White;
            this.txtDescrip.BorderColor = System.Drawing.Color.Silver;
            this.txtDescrip.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescrip.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDescrip.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDescrip.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDescrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescrip.Location = new System.Drawing.Point(162, 266);
            this.txtDescrip.MultiLine = true;
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.PasswordChar = '\0';
            this.txtDescrip.Size = new System.Drawing.Size(283, 95);
            this.txtDescrip.TabIndex = 11;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(58, 378);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(36, 15);
            this.gunaLabel5.TabIndex = 10;
            this.gunaLabel5.Text = "Ligne";
            // 
            // cbLigne
            // 
            this.cbLigne.BackColor = System.Drawing.Color.Transparent;
            this.cbLigne.BaseColor = System.Drawing.Color.White;
            this.cbLigne.BorderColor = System.Drawing.Color.Silver;
            this.cbLigne.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLigne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLigne.FocusedColor = System.Drawing.Color.Empty;
            this.cbLigne.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbLigne.ForeColor = System.Drawing.Color.Black;
            this.cbLigne.FormattingEnabled = true;
            this.cbLigne.Location = new System.Drawing.Point(162, 378);
            this.cbLigne.Name = "cbLigne";
            this.cbLigne.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbLigne.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbLigne.Size = new System.Drawing.Size(283, 26);
            this.cbLigne.TabIndex = 12;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel6.Location = new System.Drawing.Point(52, 115);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(51, 15);
            this.gunaLabel6.TabIndex = 10;
            this.gunaLabel6.Text = "Numero";
            // 
            // txtNumero
            // 
            this.txtNumero.BaseColor = System.Drawing.Color.White;
            this.txtNumero.BorderColor = System.Drawing.Color.Silver;
            this.txtNumero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumero.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNumero.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNumero.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNumero.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNumero.Location = new System.Drawing.Point(162, 106);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.PasswordChar = '\0';
            this.txtNumero.Size = new System.Drawing.Size(189, 34);
            this.txtNumero.TabIndex = 11;
            // 
            // AddPointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 572);
            this.Controls.Add(this.cbLigne);
            this.Controls.Add(this.cbEtat);
            this.Controls.Add(this.txtDescrip);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtCoord);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.gunaPanel4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gunaPanel3);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPointForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddPointForm";
            this.Load += new System.EventHandler(this.AddPointForm_Load);
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPanel gunaPanel4;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaButton btnReset;
        private Guna.UI.WinForms.GunaButton btnSave;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaButton btnExit;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaComboBox cbEtat;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        public Guna.UI.WinForms.GunaComboBox cbLigne;
        public Guna.UI.WinForms.GunaTextBox txtDescrip;
        public Guna.UI.WinForms.GunaTextBox txtCoord;
        public Guna.UI.WinForms.GunaTextBox txtNumero;
    }
}