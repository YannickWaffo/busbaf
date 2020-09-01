namespace BusBaf.View.Formu
{
    partial class AddCarteForm
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
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.btnExit = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel4 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btnReset = new Guna.UI.WinForms.GunaButton();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtNumero = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.cdDateDebut = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.cdDateFin = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.cbType = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.txtCode = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.txtPorteur = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.txtSolde = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.txtSoldeMin = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 0;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.Black;
            this.gunaPanel2.Controls.Add(this.btnExit);
            this.gunaPanel2.Controls.Add(this.gunaLabel1);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel2.Location = new System.Drawing.Point(5, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(604, 49);
            this.gunaPanel2.TabIndex = 15;
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
            this.btnExit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExit.Location = new System.Drawing.Point(557, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.Red;
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExit.OnHoverImage = global::BusBaf.Properties.Resources.icons8_delete_250px_11;
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(47, 49);
            this.btnExit.TabIndex = 6;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Impact", 20F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(21, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(82, 34);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "CARTE";
            // 
            // gunaPanel4
            // 
            this.gunaPanel4.BackColor = System.Drawing.Color.Black;
            this.gunaPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel4.Location = new System.Drawing.Point(5, 567);
            this.gunaPanel4.Name = "gunaPanel4";
            this.gunaPanel4.Size = new System.Drawing.Size(604, 5);
            this.gunaPanel4.TabIndex = 10;
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.BackColor = System.Drawing.Color.Black;
            this.gunaPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaPanel3.Location = new System.Drawing.Point(609, 0);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(5, 572);
            this.gunaPanel3.TabIndex = 11;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.Black;
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(5, 572);
            this.gunaPanel1.TabIndex = 12;
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
            this.btnReset.Image = global::BusBaf.Properties.Resources.visible;
            this.btnReset.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReset.ImageSize = new System.Drawing.Size(20, 20);
            this.btnReset.Location = new System.Drawing.Point(412, 497);
            this.btnReset.Name = "btnReset";
            this.btnReset.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnReset.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReset.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReset.OnHoverImage = null;
            this.btnReset.OnPressedColor = System.Drawing.Color.Black;
            this.btnReset.Size = new System.Drawing.Size(169, 51);
            this.btnReset.TabIndex = 13;
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
            this.btnSave.Image = global::BusBaf.Properties.Resources.save;
            this.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSave.Location = new System.Drawing.Point(27, 497);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Size = new System.Drawing.Size(350, 51);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "ENREGISTRER";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(24, 100);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(51, 15);
            this.gunaLabel2.TabIndex = 16;
            this.gunaLabel2.Text = "Numero";
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
            this.txtNumero.Location = new System.Drawing.Point(130, 92);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.PasswordChar = '\0';
            this.txtNumero.Size = new System.Drawing.Size(198, 30);
            this.txtNumero.TabIndex = 17;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(24, 324);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(92, 15);
            this.gunaLabel3.TabIndex = 16;
            this.gunaLabel3.Text = "Date Attribution";
            // 
            // cdDateDebut
            // 
            this.cdDateDebut.BaseColor = System.Drawing.Color.White;
            this.cdDateDebut.BorderColor = System.Drawing.Color.Silver;
            this.cdDateDebut.CustomFormat = null;
            this.cdDateDebut.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.cdDateDebut.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cdDateDebut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cdDateDebut.ForeColor = System.Drawing.Color.Black;
            this.cdDateDebut.Location = new System.Drawing.Point(130, 318);
            this.cdDateDebut.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.cdDateDebut.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.cdDateDebut.Name = "cdDateDebut";
            this.cdDateDebut.OnHoverBaseColor = System.Drawing.Color.White;
            this.cdDateDebut.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cdDateDebut.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cdDateDebut.OnPressedColor = System.Drawing.Color.Black;
            this.cdDateDebut.Size = new System.Drawing.Size(451, 30);
            this.cdDateDebut.TabIndex = 18;
            this.cdDateDebut.Text = "mercredi 22 juillet 2020";
            this.cdDateDebut.Value = new System.DateTime(2020, 7, 22, 21, 2, 12, 192);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(24, 382);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(87, 15);
            this.gunaLabel4.TabIndex = 16;
            this.gunaLabel4.Text = "Date Expiration";
            // 
            // cdDateFin
            // 
            this.cdDateFin.BaseColor = System.Drawing.Color.White;
            this.cdDateFin.BorderColor = System.Drawing.Color.Silver;
            this.cdDateFin.CustomFormat = null;
            this.cdDateFin.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.cdDateFin.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cdDateFin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cdDateFin.ForeColor = System.Drawing.Color.Black;
            this.cdDateFin.Location = new System.Drawing.Point(130, 376);
            this.cdDateFin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.cdDateFin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.cdDateFin.Name = "cdDateFin";
            this.cdDateFin.OnHoverBaseColor = System.Drawing.Color.White;
            this.cdDateFin.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cdDateFin.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cdDateFin.OnPressedColor = System.Drawing.Color.Black;
            this.cdDateFin.Size = new System.Drawing.Size(451, 30);
            this.cdDateFin.TabIndex = 18;
            this.cdDateFin.Text = "mercredi 22 juillet 2020";
            this.cdDateFin.Value = new System.DateTime(2020, 7, 22, 21, 2, 12, 192);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(24, 160);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(31, 15);
            this.gunaLabel5.TabIndex = 16;
            this.gunaLabel5.Text = "Type";
            // 
            // cbType
            // 
            this.cbType.BackColor = System.Drawing.Color.Transparent;
            this.cbType.BaseColor = System.Drawing.Color.White;
            this.cbType.BorderColor = System.Drawing.Color.Silver;
            this.cbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FocusedColor = System.Drawing.Color.Empty;
            this.cbType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbType.ForeColor = System.Drawing.Color.Black;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Pré-Payé",
            "Post-Payé"});
            this.cbType.Location = new System.Drawing.Point(130, 155);
            this.cbType.Name = "cbType";
            this.cbType.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbType.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbType.Size = new System.Drawing.Size(198, 26);
            this.cbType.TabIndex = 19;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel6.Location = new System.Drawing.Point(362, 160);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(35, 15);
            this.gunaLabel6.TabIndex = 16;
            this.gunaLabel6.Text = "Code";
            // 
            // txtCode
            // 
            this.txtCode.BaseColor = System.Drawing.Color.White;
            this.txtCode.BorderColor = System.Drawing.Color.Silver;
            this.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCode.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCode.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCode.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCode.Location = new System.Drawing.Point(412, 154);
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.Size = new System.Drawing.Size(169, 30);
            this.txtCode.TabIndex = 17;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel7.Location = new System.Drawing.Point(24, 209);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(46, 15);
            this.gunaLabel7.TabIndex = 16;
            this.gunaLabel7.Text = "Porteur";
            // 
            // txtPorteur
            // 
            this.txtPorteur.BaseColor = System.Drawing.Color.White;
            this.txtPorteur.BorderColor = System.Drawing.Color.Silver;
            this.txtPorteur.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPorteur.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPorteur.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPorteur.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPorteur.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPorteur.Location = new System.Drawing.Point(130, 201);
            this.txtPorteur.Name = "txtPorteur";
            this.txtPorteur.PasswordChar = '\0';
            this.txtPorteur.Size = new System.Drawing.Size(451, 30);
            this.txtPorteur.TabIndex = 17;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel8.Location = new System.Drawing.Point(24, 264);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(36, 15);
            this.gunaLabel8.TabIndex = 16;
            this.gunaLabel8.Text = "Solde";
            // 
            // txtSolde
            // 
            this.txtSolde.BaseColor = System.Drawing.Color.White;
            this.txtSolde.BorderColor = System.Drawing.Color.Silver;
            this.txtSolde.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSolde.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSolde.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSolde.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSolde.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSolde.Location = new System.Drawing.Point(130, 256);
            this.txtSolde.Name = "txtSolde";
            this.txtSolde.PasswordChar = '\0';
            this.txtSolde.Size = new System.Drawing.Size(198, 30);
            this.txtSolde.TabIndex = 17;
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel10.Location = new System.Drawing.Point(347, 263);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(56, 15);
            this.gunaLabel10.TabIndex = 16;
            this.gunaLabel10.Text = "soldeMin";
            // 
            // txtSoldeMin
            // 
            this.txtSoldeMin.BaseColor = System.Drawing.Color.White;
            this.txtSoldeMin.BorderColor = System.Drawing.Color.Silver;
            this.txtSoldeMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoldeMin.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSoldeMin.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSoldeMin.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSoldeMin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoldeMin.Location = new System.Drawing.Point(412, 257);
            this.txtSoldeMin.Name = "txtSoldeMin";
            this.txtSoldeMin.PasswordChar = '\0';
            this.txtSoldeMin.Size = new System.Drawing.Size(169, 30);
            this.txtSoldeMin.TabIndex = 17;
            // 
            // AddCarteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 572);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.cdDateFin);
            this.Controls.Add(this.cdDateDebut);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.txtSoldeMin);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtPorteur);
            this.Controls.Add(this.txtSolde);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel10);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.gunaPanel4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gunaPanel3);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCarteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddCarteForm";
            this.Load += new System.EventHandler(this.AddCarteForm_Load);
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaButton btnExit;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton btnReset;
        private Guna.UI.WinForms.GunaPanel gunaPanel4;
        private Guna.UI.WinForms.GunaButton btnSave;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaComboBox cbType;
        private Guna.UI.WinForms.GunaDateTimePicker cdDateFin;
        private Guna.UI.WinForms.GunaDateTimePicker cdDateDebut;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox txtSoldeMin;
        private Guna.UI.WinForms.GunaTextBox txtCode;
        private Guna.UI.WinForms.GunaTextBox txtPorteur;
        private Guna.UI.WinForms.GunaTextBox txtSolde;
        private Guna.UI.WinForms.GunaTextBox txtNumero;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
    }
}