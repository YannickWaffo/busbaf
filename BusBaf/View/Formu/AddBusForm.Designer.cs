namespace BusBaf.View.Formu
{
    partial class AddBusForm
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
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btnExit = new Guna.UI.WinForms.GunaButton();
            this.LabelTitle = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtNumero = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.cbType = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.cbPlaces = new Guna.UI.WinForms.GunaComboBox();
            this.cbMarque = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.cbKilometrage = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.cbEnergie = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.cbDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.txtCarte = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel11 = new Guna.UI.WinForms.GunaLabel();
            this.txtChassis = new Guna.UI.WinForms.GunaTextBox();
            this.cbPuissance = new Guna.UI.WinForms.GunaComboBox();
            this.btnReset = new Guna.UI.WinForms.GunaButton();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.Black;
            this.gunaPanel1.Controls.Add(this.btnExit);
            this.gunaPanel1.Controls.Add(this.LabelTitle);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(631, 49);
            this.gunaPanel1.TabIndex = 0;
            this.gunaPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gunaPanel1_MouseDown);
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
            this.btnExit.Location = new System.Drawing.Point(591, 0);
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
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Impact", 20F);
            this.LabelTitle.ForeColor = System.Drawing.Color.White;
            this.LabelTitle.Location = new System.Drawing.Point(12, 9);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(248, 34);
            this.LabelTitle.TabIndex = 1;
            this.LabelTitle.Text = "ENREGISTREMENT BUS";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(24, 115);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(51, 15);
            this.gunaLabel2.TabIndex = 1;
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
            this.txtNumero.Location = new System.Drawing.Point(110, 108);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.PasswordChar = '\0';
            this.txtNumero.Size = new System.Drawing.Size(140, 30);
            this.txtNumero.TabIndex = 2;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(355, 115);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(31, 15);
            this.gunaLabel3.TabIndex = 1;
            this.gunaLabel3.Text = "Type";
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
            "Coster",
            "Mini Porteur",
            "Gros Porteur"});
            this.cbType.Location = new System.Drawing.Point(423, 110);
            this.cbType.Name = "cbType";
            this.cbType.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbType.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbType.Size = new System.Drawing.Size(181, 26);
            this.cbType.TabIndex = 3;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(24, 167);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(48, 15);
            this.gunaLabel4.TabIndex = 1;
            this.gunaLabel4.Text = "Marque";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(356, 167);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(40, 15);
            this.gunaLabel5.TabIndex = 1;
            this.gunaLabel5.Text = "Places";
            // 
            // cbPlaces
            // 
            this.cbPlaces.BackColor = System.Drawing.Color.Transparent;
            this.cbPlaces.BaseColor = System.Drawing.Color.White;
            this.cbPlaces.BorderColor = System.Drawing.Color.Silver;
            this.cbPlaces.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPlaces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlaces.FocusedColor = System.Drawing.Color.Empty;
            this.cbPlaces.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbPlaces.ForeColor = System.Drawing.Color.Black;
            this.cbPlaces.FormattingEnabled = true;
            this.cbPlaces.Items.AddRange(new object[] {
            "40",
            "50",
            "60",
            "70",
            "80",
            "100",
            "120"});
            this.cbPlaces.Location = new System.Drawing.Point(423, 160);
            this.cbPlaces.Name = "cbPlaces";
            this.cbPlaces.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbPlaces.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbPlaces.Size = new System.Drawing.Size(181, 26);
            this.cbPlaces.TabIndex = 3;
            // 
            // cbMarque
            // 
            this.cbMarque.BackColor = System.Drawing.Color.Transparent;
            this.cbMarque.BaseColor = System.Drawing.Color.White;
            this.cbMarque.BorderColor = System.Drawing.Color.Silver;
            this.cbMarque.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMarque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarque.FocusedColor = System.Drawing.Color.Empty;
            this.cbMarque.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbMarque.ForeColor = System.Drawing.Color.Black;
            this.cbMarque.FormattingEnabled = true;
            this.cbMarque.Items.AddRange(new object[] {
            "Toyota",
            "Corola",
            "Mercedece",
            "Ford"});
            this.cbMarque.Location = new System.Drawing.Point(110, 162);
            this.cbMarque.Name = "cbMarque";
            this.cbMarque.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbMarque.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbMarque.Size = new System.Drawing.Size(228, 26);
            this.cbMarque.TabIndex = 3;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel6.Location = new System.Drawing.Point(24, 219);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(71, 15);
            this.gunaLabel6.TabIndex = 1;
            this.gunaLabel6.Text = "Kilometrage";
            // 
            // cbKilometrage
            // 
            this.cbKilometrage.BackColor = System.Drawing.Color.Transparent;
            this.cbKilometrage.BaseColor = System.Drawing.Color.White;
            this.cbKilometrage.BorderColor = System.Drawing.Color.Silver;
            this.cbKilometrage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbKilometrage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKilometrage.FocusedColor = System.Drawing.Color.Empty;
            this.cbKilometrage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbKilometrage.ForeColor = System.Drawing.Color.Black;
            this.cbKilometrage.FormattingEnabled = true;
            this.cbKilometrage.Items.AddRange(new object[] {
            "50",
            "100",
            "200",
            "300",
            "400"});
            this.cbKilometrage.Location = new System.Drawing.Point(109, 214);
            this.cbKilometrage.Name = "cbKilometrage";
            this.cbKilometrage.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbKilometrage.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbKilometrage.Size = new System.Drawing.Size(228, 26);
            this.cbKilometrage.TabIndex = 3;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel7.Location = new System.Drawing.Point(352, 221);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(59, 15);
            this.gunaLabel7.TabIndex = 1;
            this.gunaLabel7.Text = "Puissance";
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel8.Location = new System.Drawing.Point(30, 275);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(52, 15);
            this.gunaLabel8.TabIndex = 1;
            this.gunaLabel8.Text = "ENERGIE";
            // 
            // cbEnergie
            // 
            this.cbEnergie.BackColor = System.Drawing.Color.Transparent;
            this.cbEnergie.BaseColor = System.Drawing.Color.White;
            this.cbEnergie.BorderColor = System.Drawing.Color.Silver;
            this.cbEnergie.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbEnergie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEnergie.FocusedColor = System.Drawing.Color.Empty;
            this.cbEnergie.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbEnergie.ForeColor = System.Drawing.Color.Black;
            this.cbEnergie.FormattingEnabled = true;
            this.cbEnergie.Items.AddRange(new object[] {
            "Diezel",
            "Essence",
            "Super"});
            this.cbEnergie.Location = new System.Drawing.Point(110, 270);
            this.cbEnergie.Name = "cbEnergie";
            this.cbEnergie.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbEnergie.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbEnergie.Size = new System.Drawing.Size(228, 26);
            this.cbEnergie.TabIndex = 3;
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel9.Location = new System.Drawing.Point(25, 333);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(119, 15);
            this.gunaLabel9.TabIndex = 1;
            this.gunaLabel9.Text = "Date Mise en servives";
            // 
            // cbDate
            // 
            this.cbDate.BaseColor = System.Drawing.Color.White;
            this.cbDate.BorderColor = System.Drawing.Color.Silver;
            this.cbDate.CustomFormat = null;
            this.cbDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.cbDate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbDate.ForeColor = System.Drawing.Color.Black;
            this.cbDate.Location = new System.Drawing.Point(155, 324);
            this.cbDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.cbDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.cbDate.Name = "cbDate";
            this.cbDate.OnHoverBaseColor = System.Drawing.Color.White;
            this.cbDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbDate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbDate.OnPressedColor = System.Drawing.Color.Black;
            this.cbDate.Size = new System.Drawing.Size(449, 30);
            this.cbDate.TabIndex = 5;
            this.cbDate.Text = "mercredi 22 juillet 2020";
            this.cbDate.Value = new System.DateTime(2020, 7, 22, 7, 40, 53, 927);
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel10.Location = new System.Drawing.Point(26, 392);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(64, 15);
            this.gunaLabel10.TabIndex = 1;
            this.gunaLabel10.Text = "Carte Grise";
            // 
            // txtCarte
            // 
            this.txtCarte.BaseColor = System.Drawing.Color.White;
            this.txtCarte.BorderColor = System.Drawing.Color.Silver;
            this.txtCarte.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCarte.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCarte.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCarte.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCarte.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCarte.Location = new System.Drawing.Point(110, 385);
            this.txtCarte.Name = "txtCarte";
            this.txtCarte.PasswordChar = '\0';
            this.txtCarte.Size = new System.Drawing.Size(201, 30);
            this.txtCarte.TabIndex = 2;
            // 
            // gunaLabel11
            // 
            this.gunaLabel11.AutoSize = true;
            this.gunaLabel11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel11.Location = new System.Drawing.Point(361, 392);
            this.gunaLabel11.Name = "gunaLabel11";
            this.gunaLabel11.Size = new System.Drawing.Size(46, 15);
            this.gunaLabel11.TabIndex = 1;
            this.gunaLabel11.Text = "Chassis";
            // 
            // txtChassis
            // 
            this.txtChassis.BaseColor = System.Drawing.Color.White;
            this.txtChassis.BorderColor = System.Drawing.Color.Silver;
            this.txtChassis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChassis.FocusedBaseColor = System.Drawing.Color.White;
            this.txtChassis.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtChassis.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtChassis.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtChassis.Location = new System.Drawing.Point(423, 385);
            this.txtChassis.Name = "txtChassis";
            this.txtChassis.PasswordChar = '\0';
            this.txtChassis.Size = new System.Drawing.Size(181, 30);
            this.txtChassis.TabIndex = 2;
            // 
            // cbPuissance
            // 
            this.cbPuissance.BackColor = System.Drawing.Color.Transparent;
            this.cbPuissance.BaseColor = System.Drawing.Color.White;
            this.cbPuissance.BorderColor = System.Drawing.Color.Silver;
            this.cbPuissance.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPuissance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPuissance.FocusedColor = System.Drawing.Color.Empty;
            this.cbPuissance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbPuissance.ForeColor = System.Drawing.Color.Black;
            this.cbPuissance.FormattingEnabled = true;
            this.cbPuissance.Items.AddRange(new object[] {
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.cbPuissance.Location = new System.Drawing.Point(423, 214);
            this.cbPuissance.Name = "cbPuissance";
            this.cbPuissance.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbPuissance.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbPuissance.Size = new System.Drawing.Size(181, 26);
            this.cbPuissance.TabIndex = 3;
            // 
            // btnReset
            // 
            this.btnReset.AnimationHoverSpeed = 0.07F;
            this.btnReset.AnimationSpeed = 0.03F;
            this.btnReset.BaseColor = System.Drawing.Color.Red;
            this.btnReset.BorderColor = System.Drawing.Color.Black;
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReset.FocusedColor = System.Drawing.Color.Empty;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Image = global::BusBaf.Properties.Resources.icons8_delete_250px;
            this.btnReset.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReset.ImageSize = new System.Drawing.Size(20, 20);
            this.btnReset.Location = new System.Drawing.Point(412, 492);
            this.btnReset.Name = "btnReset";
            this.btnReset.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnReset.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReset.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReset.OnHoverImage = null;
            this.btnReset.OnPressedColor = System.Drawing.Color.Black;
            this.btnReset.Size = new System.Drawing.Size(192, 51);
            this.btnReset.TabIndex = 4;
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
            this.btnSave.Location = new System.Drawing.Point(33, 492);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Size = new System.Drawing.Size(347, 51);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "ENREGISTRER";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.Black;
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 49);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(3, 523);
            this.gunaPanel2.TabIndex = 6;
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.BackColor = System.Drawing.Color.Black;
            this.gunaPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaPanel3.Location = new System.Drawing.Point(628, 49);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(3, 523);
            this.gunaPanel3.TabIndex = 6;
            // 
            // AddBusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 572);
            this.Controls.Add(this.gunaPanel3);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.cbDate);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbEnergie);
            this.Controls.Add(this.cbPuissance);
            this.Controls.Add(this.cbKilometrage);
            this.Controls.Add(this.cbMarque);
            this.Controls.Add(this.cbPlaces);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.gunaLabel9);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.txtChassis);
            this.Controls.Add(this.gunaLabel11);
            this.Controls.Add(this.txtCarte);
            this.Controls.Add(this.gunaLabel10);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddBusForm";
            this.Load += new System.EventHandler(this.AddBusForm_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaButton btnExit;
        private Guna.UI.WinForms.GunaComboBox cbMarque;
        private Guna.UI.WinForms.GunaComboBox cbPlaces;
        private Guna.UI.WinForms.GunaComboBox cbType;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox txtNumero;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaComboBox cbKilometrage;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaDateTimePicker cbDate;
        private Guna.UI.WinForms.GunaButton btnReset;
        private Guna.UI.WinForms.GunaButton btnSave;
        private Guna.UI.WinForms.GunaComboBox cbEnergie;
        private Guna.UI.WinForms.GunaComboBox cbPuissance;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaTextBox txtChassis;
        private Guna.UI.WinForms.GunaLabel gunaLabel11;
        private Guna.UI.WinForms.GunaTextBox txtCarte;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        public Guna.UI.WinForms.GunaLabel LabelTitle;
    }
}