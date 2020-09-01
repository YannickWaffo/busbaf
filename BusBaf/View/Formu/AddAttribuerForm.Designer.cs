namespace BusBaf.View.Formu
{
    partial class AddAttribuerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAttribuerForm));
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.btnExit = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.cbChauffeur = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtNumero = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPanel4 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.cbdateD = new Guna.UI.WinForms.GunaDateTimePicker();
            this.cbdateF = new Guna.UI.WinForms.GunaDateTimePicker();
            this.txtNomChau = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.txtPreChau = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.txtMarqBus = new Guna.UI.WinForms.GunaTextBox();
            this.txtCartBus = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel11 = new Guna.UI.WinForms.GunaLabel();
            this.cbBus = new Guna.UI.WinForms.GunaComboBox();
            this.btnReset = new Guna.UI.WinForms.GunaButton();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.White;
            this.gunaPanel2.Controls.Add(this.btnExit);
            this.gunaPanel2.Controls.Add(this.gunaLabel1);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel2.Location = new System.Drawing.Point(5, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(661, 49);
            this.gunaPanel2.TabIndex = 24;
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
            this.btnExit.Location = new System.Drawing.Point(621, 0);
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
            this.gunaLabel1.Size = new System.Drawing.Size(155, 34);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "ATTRIBUTION";
            // 
            // cbChauffeur
            // 
            this.cbChauffeur.BackColor = System.Drawing.Color.Transparent;
            this.cbChauffeur.BaseColor = System.Drawing.Color.White;
            this.cbChauffeur.BorderColor = System.Drawing.Color.Silver;
            this.cbChauffeur.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbChauffeur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChauffeur.FocusedColor = System.Drawing.Color.Empty;
            this.cbChauffeur.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbChauffeur.ForeColor = System.Drawing.Color.Black;
            this.cbChauffeur.FormattingEnabled = true;
            this.cbChauffeur.Location = new System.Drawing.Point(156, 259);
            this.cbChauffeur.Name = "cbChauffeur";
            this.cbChauffeur.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbChauffeur.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbChauffeur.Size = new System.Drawing.Size(438, 26);
            this.cbChauffeur.TabIndex = 34;
            this.cbChauffeur.SelectedValueChanged += new System.EventHandler(this.cbChauffeur_SelectedValueChanged);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(55, 211);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(50, 15);
            this.gunaLabel4.TabIndex = 32;
            this.gunaLabel4.Text = "Date Fin";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(55, 160);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(66, 15);
            this.gunaLabel3.TabIndex = 31;
            this.gunaLabel3.Text = "Date Debut";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(52, 264);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(60, 15);
            this.gunaLabel5.TabIndex = 33;
            this.gunaLabel5.Text = "Chauffeur";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(55, 105);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(51, 15);
            this.gunaLabel2.TabIndex = 28;
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
            this.txtNumero.Location = new System.Drawing.Point(156, 97);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.PasswordChar = '\0';
            this.txtNumero.Size = new System.Drawing.Size(256, 30);
            this.txtNumero.TabIndex = 25;
            // 
            // gunaPanel4
            // 
            this.gunaPanel4.BackColor = System.Drawing.Color.Coral;
            this.gunaPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel4.Location = new System.Drawing.Point(5, 567);
            this.gunaPanel4.Name = "gunaPanel4";
            this.gunaPanel4.Size = new System.Drawing.Size(661, 5);
            this.gunaPanel4.TabIndex = 19;
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.BackColor = System.Drawing.Color.Coral;
            this.gunaPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaPanel3.Location = new System.Drawing.Point(666, 0);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(5, 572);
            this.gunaPanel3.TabIndex = 20;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.Coral;
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(5, 572);
            this.gunaPanel1.TabIndex = 21;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 0;
            this.gunaElipse1.TargetControl = this;
            // 
            // cbdateD
            // 
            this.cbdateD.BaseColor = System.Drawing.Color.White;
            this.cbdateD.BorderColor = System.Drawing.Color.Silver;
            this.cbdateD.CustomFormat = null;
            this.cbdateD.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.cbdateD.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbdateD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbdateD.ForeColor = System.Drawing.Color.Black;
            this.cbdateD.Location = new System.Drawing.Point(156, 154);
            this.cbdateD.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.cbdateD.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.cbdateD.Name = "cbdateD";
            this.cbdateD.OnHoverBaseColor = System.Drawing.Color.White;
            this.cbdateD.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbdateD.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbdateD.OnPressedColor = System.Drawing.Color.Black;
            this.cbdateD.Size = new System.Drawing.Size(438, 30);
            this.cbdateD.TabIndex = 35;
            this.cbdateD.Text = "jeudi 23 juillet 2020";
            this.cbdateD.Value = new System.DateTime(2020, 7, 23, 19, 47, 17, 391);
            // 
            // cbdateF
            // 
            this.cbdateF.BaseColor = System.Drawing.Color.White;
            this.cbdateF.BorderColor = System.Drawing.Color.Silver;
            this.cbdateF.CustomFormat = null;
            this.cbdateF.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.cbdateF.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbdateF.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbdateF.ForeColor = System.Drawing.Color.Black;
            this.cbdateF.Location = new System.Drawing.Point(156, 205);
            this.cbdateF.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.cbdateF.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.cbdateF.Name = "cbdateF";
            this.cbdateF.OnHoverBaseColor = System.Drawing.Color.White;
            this.cbdateF.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbdateF.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbdateF.OnPressedColor = System.Drawing.Color.Black;
            this.cbdateF.Size = new System.Drawing.Size(438, 30);
            this.cbdateF.TabIndex = 35;
            this.cbdateF.Text = "jeudi 23 juillet 2020";
            this.cbdateF.Value = new System.DateTime(2020, 7, 23, 19, 47, 17, 391);
            // 
            // txtNomChau
            // 
            this.txtNomChau.BaseColor = System.Drawing.Color.White;
            this.txtNomChau.BorderColor = System.Drawing.Color.Silver;
            this.txtNomChau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomChau.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNomChau.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNomChau.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNomChau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNomChau.Location = new System.Drawing.Point(156, 306);
            this.txtNomChau.Name = "txtNomChau";
            this.txtNomChau.PasswordChar = '\0';
            this.txtNomChau.Size = new System.Drawing.Size(163, 30);
            this.txtNomChau.TabIndex = 25;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel6.Location = new System.Drawing.Point(55, 314);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(34, 15);
            this.gunaLabel6.TabIndex = 28;
            this.gunaLabel6.Text = "Nom";
            // 
            // txtPreChau
            // 
            this.txtPreChau.BaseColor = System.Drawing.Color.White;
            this.txtPreChau.BorderColor = System.Drawing.Color.Silver;
            this.txtPreChau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPreChau.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPreChau.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPreChau.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPreChau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPreChau.Location = new System.Drawing.Point(404, 306);
            this.txtPreChau.Name = "txtPreChau";
            this.txtPreChau.PasswordChar = '\0';
            this.txtPreChau.Size = new System.Drawing.Size(190, 30);
            this.txtPreChau.TabIndex = 25;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel7.Location = new System.Drawing.Point(349, 314);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(49, 15);
            this.gunaLabel7.TabIndex = 28;
            this.gunaLabel7.Text = "Prenom";
            // 
            // txtMarqBus
            // 
            this.txtMarqBus.BaseColor = System.Drawing.Color.White;
            this.txtMarqBus.BorderColor = System.Drawing.Color.Silver;
            this.txtMarqBus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMarqBus.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMarqBus.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMarqBus.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMarqBus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMarqBus.Location = new System.Drawing.Point(153, 406);
            this.txtMarqBus.Name = "txtMarqBus";
            this.txtMarqBus.PasswordChar = '\0';
            this.txtMarqBus.Size = new System.Drawing.Size(166, 30);
            this.txtMarqBus.TabIndex = 25;
            // 
            // txtCartBus
            // 
            this.txtCartBus.BaseColor = System.Drawing.Color.White;
            this.txtCartBus.BorderColor = System.Drawing.Color.Silver;
            this.txtCartBus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCartBus.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCartBus.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCartBus.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCartBus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCartBus.Location = new System.Drawing.Point(404, 406);
            this.txtCartBus.Name = "txtCartBus";
            this.txtCartBus.PasswordChar = '\0';
            this.txtCartBus.Size = new System.Drawing.Size(190, 30);
            this.txtCartBus.TabIndex = 25;
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel9.Location = new System.Drawing.Point(55, 414);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(48, 15);
            this.gunaLabel9.TabIndex = 28;
            this.gunaLabel9.Text = "Marque";
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel10.Location = new System.Drawing.Point(339, 414);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(63, 15);
            this.gunaLabel10.TabIndex = 28;
            this.gunaLabel10.Text = "Carte grise";
            // 
            // gunaLabel11
            // 
            this.gunaLabel11.AutoSize = true;
            this.gunaLabel11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel11.Location = new System.Drawing.Point(52, 364);
            this.gunaLabel11.Name = "gunaLabel11";
            this.gunaLabel11.Size = new System.Drawing.Size(26, 15);
            this.gunaLabel11.TabIndex = 33;
            this.gunaLabel11.Text = "Bus";
            // 
            // cbBus
            // 
            this.cbBus.BackColor = System.Drawing.Color.Transparent;
            this.cbBus.BaseColor = System.Drawing.Color.White;
            this.cbBus.BorderColor = System.Drawing.Color.Silver;
            this.cbBus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbBus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBus.FocusedColor = System.Drawing.Color.Empty;
            this.cbBus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbBus.ForeColor = System.Drawing.Color.Black;
            this.cbBus.FormattingEnabled = true;
            this.cbBus.Location = new System.Drawing.Point(156, 359);
            this.cbBus.Name = "cbBus";
            this.cbBus.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbBus.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbBus.Size = new System.Drawing.Size(438, 26);
            this.cbBus.TabIndex = 34;
            this.cbBus.SelectedValueChanged += new System.EventHandler(this.cbBus_SelectedValueChanged);
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
            this.btnReset.Location = new System.Drawing.Point(444, 497);
            this.btnReset.Name = "btnReset";
            this.btnReset.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnReset.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReset.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReset.OnHoverImage = null;
            this.btnReset.OnPressedColor = System.Drawing.Color.Black;
            this.btnReset.Size = new System.Drawing.Size(187, 51);
            this.btnReset.TabIndex = 22;
            this.btnReset.Text = "ANNULLER";
            this.btnReset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnSave.Size = new System.Drawing.Size(385, 51);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "ENREGISTRER";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddAttribuerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 572);
            this.Controls.Add(this.cbdateF);
            this.Controls.Add(this.cbdateD);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.cbBus);
            this.Controls.Add(this.cbChauffeur);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel11);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel10);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel9);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.txtCartBus);
            this.Controls.Add(this.txtMarqBus);
            this.Controls.Add(this.txtPreChau);
            this.Controls.Add(this.txtNomChau);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.gunaPanel4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gunaPanel3);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAttribuerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddAttribuerForm";
            this.Load += new System.EventHandler(this.AddAttribuerForm_Load);
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaButton btnExit;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaComboBox cbChauffeur;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txtNumero;
        private Guna.UI.WinForms.GunaButton btnReset;
        private Guna.UI.WinForms.GunaPanel gunaPanel4;
        private Guna.UI.WinForms.GunaButton btnSave;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaDateTimePicker cbdateF;
        private Guna.UI.WinForms.GunaDateTimePicker cbdateD;
        private Guna.UI.WinForms.GunaComboBox cbBus;
        private Guna.UI.WinForms.GunaLabel gunaLabel11;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaTextBox txtCartBus;
        private Guna.UI.WinForms.GunaTextBox txtMarqBus;
        private Guna.UI.WinForms.GunaTextBox txtPreChau;
        private Guna.UI.WinForms.GunaTextBox txtNomChau;
    }
}