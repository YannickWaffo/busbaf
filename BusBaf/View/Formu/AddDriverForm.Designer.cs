namespace BusBaf.View.Formu
{
    partial class AddDriverForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDriverForm));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btnExit = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtNumero = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txtNom = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtPrenom = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txtTelephone = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.txtAdresse = new Guna.UI.WinForms.GunaTextBox();
            this.cbDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.txtPermis = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.cbStatus = new Guna.UI.WinForms.GunaComboBox();
            this.btnImageSelect = new Guna.UI.WinForms.GunaButton();
            this.pic = new Guna.UI.WinForms.GunaPictureBox();
            this.btnReset = new Guna.UI.WinForms.GunaButton();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.White;
            this.gunaPanel1.Controls.Add(this.btnExit);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(671, 49);
            this.gunaPanel1.TabIndex = 1;
            this.gunaPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gunaPanel1_MouseDown);
            // 
            // btnExit
            // 
            this.btnExit.AnimationHoverSpeed = 0.07F;
            this.btnExit.AnimationSpeed = 0.03F;
            this.btnExit.BaseColor = System.Drawing.Color.Black;
            this.btnExit.BorderColor = System.Drawing.Color.Black;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExit.FocusedColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::BusBaf.Properties.Resources.icons8_delete_250px;
            this.btnExit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExit.Location = new System.Drawing.Point(631, -3);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.Red;
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExit.OnHoverImage = global::BusBaf.Properties.Resources.icons8_delete_250px_11;
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(40, 52);
            this.btnExit.TabIndex = 6;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Impact", 20F);
            this.gunaLabel1.Location = new System.Drawing.Point(12, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(137, 34);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "CHAUFFEUR";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(42, 114);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(51, 15);
            this.gunaLabel2.TabIndex = 7;
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
            this.txtNumero.Location = new System.Drawing.Point(129, 107);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.PasswordChar = '\0';
            this.txtNumero.Size = new System.Drawing.Size(145, 30);
            this.txtNumero.TabIndex = 8;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(42, 159);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(34, 15);
            this.gunaLabel3.TabIndex = 7;
            this.gunaLabel3.Text = "Nom";
            // 
            // txtNom
            // 
            this.txtNom.BaseColor = System.Drawing.Color.White;
            this.txtNom.BorderColor = System.Drawing.Color.Silver;
            this.txtNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNom.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNom.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNom.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNom.Location = new System.Drawing.Point(129, 152);
            this.txtNom.Name = "txtNom";
            this.txtNom.PasswordChar = '\0';
            this.txtNom.Size = new System.Drawing.Size(291, 30);
            this.txtNom.TabIndex = 8;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(42, 208);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(49, 15);
            this.gunaLabel4.TabIndex = 7;
            this.gunaLabel4.Text = "Prenom";
            // 
            // txtPrenom
            // 
            this.txtPrenom.BaseColor = System.Drawing.Color.White;
            this.txtPrenom.BorderColor = System.Drawing.Color.Silver;
            this.txtPrenom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrenom.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPrenom.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPrenom.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPrenom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrenom.Location = new System.Drawing.Point(129, 201);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.PasswordChar = '\0';
            this.txtPrenom.Size = new System.Drawing.Size(291, 30);
            this.txtPrenom.TabIndex = 8;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(42, 309);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(61, 15);
            this.gunaLabel5.TabIndex = 7;
            this.gunaLabel5.Text = "Telephone";
            // 
            // txtTelephone
            // 
            this.txtTelephone.BaseColor = System.Drawing.Color.White;
            this.txtTelephone.BorderColor = System.Drawing.Color.Silver;
            this.txtTelephone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelephone.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTelephone.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTelephone.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTelephone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTelephone.Location = new System.Drawing.Point(129, 302);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.PasswordChar = '\0';
            this.txtTelephone.Size = new System.Drawing.Size(202, 30);
            this.txtTelephone.TabIndex = 8;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel6.Location = new System.Drawing.Point(42, 257);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(57, 15);
            this.gunaLabel6.TabIndex = 7;
            this.gunaLabel6.Text = "Date Nai*";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel7.Location = new System.Drawing.Point(368, 310);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(48, 15);
            this.gunaLabel7.TabIndex = 7;
            this.gunaLabel7.Text = "Adresse";
            // 
            // txtAdresse
            // 
            this.txtAdresse.BaseColor = System.Drawing.Color.White;
            this.txtAdresse.BorderColor = System.Drawing.Color.Silver;
            this.txtAdresse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdresse.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAdresse.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtAdresse.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAdresse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAdresse.Location = new System.Drawing.Point(433, 302);
            this.txtAdresse.MultiLine = true;
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.PasswordChar = '\0';
            this.txtAdresse.Size = new System.Drawing.Size(202, 124);
            this.txtAdresse.TabIndex = 8;
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
            this.cbDate.Location = new System.Drawing.Point(129, 253);
            this.cbDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.cbDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.cbDate.Name = "cbDate";
            this.cbDate.OnHoverBaseColor = System.Drawing.Color.White;
            this.cbDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbDate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbDate.OnPressedColor = System.Drawing.Color.Black;
            this.cbDate.Size = new System.Drawing.Size(291, 30);
            this.cbDate.TabIndex = 11;
            this.cbDate.Text = "mercredi 22 juillet 2020";
            this.cbDate.Value = new System.DateTime(2020, 7, 22, 17, 59, 2, 868);
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel8.Location = new System.Drawing.Point(42, 355);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(43, 15);
            this.gunaLabel8.TabIndex = 7;
            this.gunaLabel8.Text = "Permis";
            // 
            // txtPermis
            // 
            this.txtPermis.BaseColor = System.Drawing.Color.White;
            this.txtPermis.BorderColor = System.Drawing.Color.Silver;
            this.txtPermis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPermis.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPermis.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPermis.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPermis.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPermis.Location = new System.Drawing.Point(129, 348);
            this.txtPermis.Name = "txtPermis";
            this.txtPermis.PasswordChar = '\0';
            this.txtPermis.Size = new System.Drawing.Size(202, 30);
            this.txtPermis.TabIndex = 8;
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel9.Location = new System.Drawing.Point(42, 403);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(38, 15);
            this.gunaLabel9.TabIndex = 7;
            this.gunaLabel9.Text = "status";
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbStatus.BaseColor = System.Drawing.Color.White;
            this.cbStatus.BorderColor = System.Drawing.Color.Silver;
            this.cbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FocusedColor = System.Drawing.Color.Empty;
            this.cbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbStatus.ForeColor = System.Drawing.Color.Black;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Principal",
            "Second"});
            this.cbStatus.Location = new System.Drawing.Point(129, 396);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbStatus.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbStatus.Size = new System.Drawing.Size(202, 26);
            this.cbStatus.TabIndex = 12;
            // 
            // btnImageSelect
            // 
            this.btnImageSelect.AnimationHoverSpeed = 0.07F;
            this.btnImageSelect.AnimationSpeed = 0.03F;
            this.btnImageSelect.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnImageSelect.BorderColor = System.Drawing.Color.Black;
            this.btnImageSelect.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnImageSelect.FocusedColor = System.Drawing.Color.Empty;
            this.btnImageSelect.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnImageSelect.ForeColor = System.Drawing.Color.White;
            this.btnImageSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnImageSelect.Image")));
            this.btnImageSelect.ImageSize = new System.Drawing.Size(20, 20);
            this.btnImageSelect.Location = new System.Drawing.Point(477, 257);
            this.btnImageSelect.Name = "btnImageSelect";
            this.btnImageSelect.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnImageSelect.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnImageSelect.OnHoverForeColor = System.Drawing.Color.White;
            this.btnImageSelect.OnHoverImage = null;
            this.btnImageSelect.OnPressedColor = System.Drawing.Color.Black;
            this.btnImageSelect.Size = new System.Drawing.Size(142, 25);
            this.btnImageSelect.TabIndex = 10;
            this.btnImageSelect.Text = "image";
            this.btnImageSelect.Click += new System.EventHandler(this.btnImageSelect_Click);
            // 
            // pic
            // 
            this.pic.BaseColor = System.Drawing.Color.White;
            this.pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic.Location = new System.Drawing.Point(477, 99);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(142, 155);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 9;
            this.pic.TabStop = false;
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
            this.btnReset.Location = new System.Drawing.Point(454, 491);
            this.btnReset.Name = "btnReset";
            this.btnReset.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnReset.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReset.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReset.OnHoverImage = null;
            this.btnReset.OnPressedColor = System.Drawing.Color.Black;
            this.btnReset.Size = new System.Drawing.Size(187, 51);
            this.btnReset.TabIndex = 5;
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
            this.btnSave.Location = new System.Drawing.Point(45, 491);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Size = new System.Drawing.Size(385, 51);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "ENREGISTRER";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddDriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 572);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.cbDate);
            this.Controls.Add(this.btnImageSelect);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtPermis);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.gunaLabel9);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddDriverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddDriverForm";
            this.Load += new System.EventHandler(this.AddDriverForm_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaButton btnExit;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton btnImageSelect;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaButton btnReset;
        private Guna.UI.WinForms.GunaButton btnSave;
        public Guna.UI.WinForms.GunaDateTimePicker cbDate;
        public Guna.UI.WinForms.GunaPictureBox pic;
        public Guna.UI.WinForms.GunaTextBox txtAdresse;
        public Guna.UI.WinForms.GunaTextBox txtPermis;
        public Guna.UI.WinForms.GunaTextBox txtTelephone;
        public Guna.UI.WinForms.GunaTextBox txtPrenom;
        public Guna.UI.WinForms.GunaTextBox txtNom;
        public Guna.UI.WinForms.GunaTextBox txtNumero;
        public Guna.UI.WinForms.GunaComboBox cbStatus;
    }
}