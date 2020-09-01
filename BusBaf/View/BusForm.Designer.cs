namespace BusBaf.View
{
    partial class BusForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusForm));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.dgBus = new Guna.UI.WinForms.GunaDataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btnPaie = new Guna.UI.WinForms.GunaButton();
            this.btnListeAffectation = new Guna.UI.WinForms.GunaButton();
            this.btnAffecter = new Guna.UI.WinForms.GunaButton();
            this.btnChange = new Guna.UI.WinForms.GunaButton();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.BtnPrint = new Guna.UI.WinForms.GunaButton();
            this.btnExit = new Guna.UI.WinForms.GunaButton();
            this.ttt = new Guna.UI.WinForms.GunaLabel();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaComboBox1 = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel4 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel5 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel6 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel7 = new Guna.UI.WinForms.GunaPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgBus)).BeginInit();
            this.gunaPanel3.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // dgBus
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgBus.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgBus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgBus.BackgroundColor = System.Drawing.Color.White;
            this.dgBus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgBus.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgBus.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgBus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgBus.ColumnHeadersHeight = 40;
            this.dgBus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgBus.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgBus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgBus.EnableHeadersVisualStyles = false;
            this.dgBus.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgBus.Location = new System.Drawing.Point(0, 0);
            this.dgBus.Name = "dgBus";
            this.dgBus.RowHeadersVisible = false;
            this.dgBus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgBus.Size = new System.Drawing.Size(952, 356);
            this.dgBus.TabIndex = 0;
            this.dgBus.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.LightGrid;
            this.dgBus.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgBus.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgBus.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgBus.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgBus.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgBus.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgBus.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgBus.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgBus.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgBus.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgBus.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgBus.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgBus.ThemeStyle.HeaderStyle.Height = 40;
            this.dgBus.ThemeStyle.ReadOnly = false;
            this.dgBus.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgBus.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgBus.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgBus.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgBus.ThemeStyle.RowsStyle.Height = 22;
            this.dgBus.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgBus.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgBus.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBus_CellDoubleClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Numero";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Type";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Marque";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Places";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Kilometrage";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "puissance";
            this.Column7.Name = "Column7";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Energie";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Date_mise";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Carte_grise";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Chassis";
            this.Column12.Name = "Column12";
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaPanel3.Controls.Add(this.ttt);
            this.gunaPanel3.Controls.Add(this.gunaTextBox1);
            this.gunaPanel3.Controls.Add(this.gunaComboBox1);
            this.gunaPanel3.Controls.Add(this.gunaLabel3);
            this.gunaPanel3.Location = new System.Drawing.Point(26, 177);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(952, 63);
            this.gunaPanel3.TabIndex = 7;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Controls.Add(this.dgBus);
            this.gunaPanel2.Location = new System.Drawing.Point(26, 246);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(952, 356);
            this.gunaPanel2.TabIndex = 8;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPanel1.Controls.Add(this.btnPaie);
            this.gunaPanel1.Controls.Add(this.btnListeAffectation);
            this.gunaPanel1.Controls.Add(this.btnAffecter);
            this.gunaPanel1.Controls.Add(this.btnChange);
            this.gunaPanel1.Controls.Add(this.btnSave);
            this.gunaPanel1.Location = new System.Drawing.Point(26, 92);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(952, 70);
            this.gunaPanel1.TabIndex = 9;
            // 
            // btnPaie
            // 
            this.btnPaie.AnimationHoverSpeed = 0.07F;
            this.btnPaie.AnimationSpeed = 0.03F;
            this.btnPaie.BaseColor = System.Drawing.Color.Black;
            this.btnPaie.BorderColor = System.Drawing.Color.Black;
            this.btnPaie.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPaie.FocusedColor = System.Drawing.Color.Empty;
            this.btnPaie.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPaie.ForeColor = System.Drawing.Color.White;
            this.btnPaie.Image = global::BusBaf.Properties.Resources._039_credit_card_2;
            this.btnPaie.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPaie.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPaie.Location = new System.Drawing.Point(747, 20);
            this.btnPaie.Name = "btnPaie";
            this.btnPaie.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnPaie.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPaie.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPaie.OnHoverImage = null;
            this.btnPaie.OnPressedColor = System.Drawing.Color.Black;
            this.btnPaie.Size = new System.Drawing.Size(165, 43);
            this.btnPaie.TabIndex = 0;
            this.btnPaie.Text = "PAIEMENT";
            this.btnPaie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPaie.Click += new System.EventHandler(this.btnPaie_Click);
            // 
            // btnListeAffectation
            // 
            this.btnListeAffectation.AnimationHoverSpeed = 0.07F;
            this.btnListeAffectation.AnimationSpeed = 0.03F;
            this.btnListeAffectation.BaseColor = System.Drawing.Color.Black;
            this.btnListeAffectation.BorderColor = System.Drawing.Color.Black;
            this.btnListeAffectation.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnListeAffectation.FocusedColor = System.Drawing.Color.Empty;
            this.btnListeAffectation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnListeAffectation.ForeColor = System.Drawing.Color.White;
            this.btnListeAffectation.Image = global::BusBaf.Properties.Resources.squared_menu;
            this.btnListeAffectation.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnListeAffectation.ImageSize = new System.Drawing.Size(20, 20);
            this.btnListeAffectation.Location = new System.Drawing.Point(563, 20);
            this.btnListeAffectation.Name = "btnListeAffectation";
            this.btnListeAffectation.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnListeAffectation.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnListeAffectation.OnHoverForeColor = System.Drawing.Color.White;
            this.btnListeAffectation.OnHoverImage = null;
            this.btnListeAffectation.OnPressedColor = System.Drawing.Color.Black;
            this.btnListeAffectation.Size = new System.Drawing.Size(165, 43);
            this.btnListeAffectation.TabIndex = 0;
            this.btnListeAffectation.Text = "LISTE AFFECTER";
            this.btnListeAffectation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnListeAffectation.Click += new System.EventHandler(this.btnListeAffectation_Click);
            // 
            // btnAffecter
            // 
            this.btnAffecter.AnimationHoverSpeed = 0.07F;
            this.btnAffecter.AnimationSpeed = 0.03F;
            this.btnAffecter.BaseColor = System.Drawing.Color.Black;
            this.btnAffecter.BorderColor = System.Drawing.Color.Black;
            this.btnAffecter.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAffecter.FocusedColor = System.Drawing.Color.Empty;
            this.btnAffecter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAffecter.ForeColor = System.Drawing.Color.White;
            this.btnAffecter.Image = ((System.Drawing.Image)(resources.GetObject("btnAffecter.Image")));
            this.btnAffecter.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAffecter.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAffecter.Location = new System.Drawing.Point(390, 20);
            this.btnAffecter.Name = "btnAffecter";
            this.btnAffecter.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAffecter.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAffecter.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAffecter.OnHoverImage = null;
            this.btnAffecter.OnPressedColor = System.Drawing.Color.Black;
            this.btnAffecter.Size = new System.Drawing.Size(152, 43);
            this.btnAffecter.TabIndex = 0;
            this.btnAffecter.Text = "AFFECTER BUS";
            this.btnAffecter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAffecter.Click += new System.EventHandler(this.btnAffecter_Click);
            // 
            // btnChange
            // 
            this.btnChange.AnimationHoverSpeed = 0.07F;
            this.btnChange.AnimationSpeed = 0.03F;
            this.btnChange.BaseColor = System.Drawing.Color.Black;
            this.btnChange.BorderColor = System.Drawing.Color.Black;
            this.btnChange.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnChange.FocusedColor = System.Drawing.Color.Empty;
            this.btnChange.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChange.ForeColor = System.Drawing.Color.White;
            this.btnChange.Image = global::BusBaf.Properties.Resources.save1;
            this.btnChange.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnChange.ImageSize = new System.Drawing.Size(20, 20);
            this.btnChange.Location = new System.Drawing.Point(207, 20);
            this.btnChange.Name = "btnChange";
            this.btnChange.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnChange.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnChange.OnHoverForeColor = System.Drawing.Color.White;
            this.btnChange.OnHoverImage = null;
            this.btnChange.OnPressedColor = System.Drawing.Color.Black;
            this.btnChange.Size = new System.Drawing.Size(165, 43);
            this.btnChange.TabIndex = 0;
            this.btnChange.Text = "MODIFIER";
            this.btnChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnSave
            // 
            this.btnSave.AnimationHoverSpeed = 0.07F;
            this.btnSave.AnimationSpeed = 0.03F;
            this.btnSave.BaseColor = System.Drawing.Color.Black;
            this.btnSave.BorderColor = System.Drawing.Color.Black;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.FocusedColor = System.Drawing.Color.Empty;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::BusBaf.Properties.Resources.save;
            this.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSave.Location = new System.Drawing.Point(25, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Size = new System.Drawing.Size(166, 43);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "ENREGISTRER";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 19F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(32, 3);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(62, 36);
            this.gunaLabel1.TabIndex = 6;
            this.gunaLabel1.Text = "BUS";
            // 
            // BtnPrint
            // 
            this.BtnPrint.AnimationHoverSpeed = 0.07F;
            this.BtnPrint.AnimationSpeed = 0.03F;
            this.BtnPrint.BackColor = System.Drawing.Color.Black;
            this.BtnPrint.BaseColor = System.Drawing.Color.Black;
            this.BtnPrint.BorderColor = System.Drawing.Color.Black;
            this.BtnPrint.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnPrint.FocusedColor = System.Drawing.Color.Empty;
            this.BtnPrint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnPrint.ForeColor = System.Drawing.Color.White;
            this.BtnPrint.Image = global::BusBaf.Properties.Resources.print;
            this.BtnPrint.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnPrint.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnPrint.Location = new System.Drawing.Point(785, 608);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnPrint.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnPrint.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnPrint.OnHoverImage = null;
            this.BtnPrint.OnPressedColor = System.Drawing.Color.Black;
            this.BtnPrint.Size = new System.Drawing.Size(193, 32);
            this.BtnPrint.TabIndex = 0;
            this.BtnPrint.Text = "IMPRIMMER";
            this.BtnPrint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
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
            this.btnExit.Location = new System.Drawing.Point(972, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.Red;
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExit.OnHoverImage = global::BusBaf.Properties.Resources.icons8_delete_250px_11;
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(40, 42);
            this.btnExit.TabIndex = 5;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ttt
            // 
            this.ttt.AutoSize = true;
            this.ttt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ttt.Location = new System.Drawing.Point(632, 25);
            this.ttt.Name = "ttt";
            this.ttt.Size = new System.Drawing.Size(39, 15);
            this.ttt.TabIndex = 16;
            this.ttt.Text = "valeur";
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Black;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox1.Location = new System.Drawing.Point(677, 16);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Radius = 15;
            this.gunaTextBox1.Size = new System.Drawing.Size(251, 34);
            this.gunaTextBox1.TabIndex = 15;
            // 
            // gunaComboBox1
            // 
            this.gunaComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBox1.BaseColor = System.Drawing.Color.White;
            this.gunaComboBox1.BorderColor = System.Drawing.Color.Black;
            this.gunaComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaComboBox1.ForeColor = System.Drawing.Color.Black;
            this.gunaComboBox1.FormattingEnabled = true;
            this.gunaComboBox1.Location = new System.Drawing.Point(385, 20);
            this.gunaComboBox1.Name = "gunaComboBox1";
            this.gunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox1.Radius = 10;
            this.gunaComboBox1.Size = new System.Drawing.Size(208, 26);
            this.gunaComboBox1.TabIndex = 14;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(293, 25);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(82, 15);
            this.gunaLabel3.TabIndex = 13;
            this.gunaLabel3.Text = "Recherche par";
            // 
            // gunaPanel4
            // 
            this.gunaPanel4.BackColor = System.Drawing.Color.Black;
            this.gunaPanel4.Controls.Add(this.btnExit);
            this.gunaPanel4.Controls.Add(this.gunaLabel1);
            this.gunaPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel4.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel4.Name = "gunaPanel4";
            this.gunaPanel4.Size = new System.Drawing.Size(1012, 45);
            this.gunaPanel4.TabIndex = 10;
            // 
            // gunaPanel5
            // 
            this.gunaPanel5.BackColor = System.Drawing.Color.Black;
            this.gunaPanel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel5.Location = new System.Drawing.Point(0, 45);
            this.gunaPanel5.Name = "gunaPanel5";
            this.gunaPanel5.Size = new System.Drawing.Size(5, 613);
            this.gunaPanel5.TabIndex = 11;
            // 
            // gunaPanel6
            // 
            this.gunaPanel6.BackColor = System.Drawing.Color.Black;
            this.gunaPanel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel6.Location = new System.Drawing.Point(5, 653);
            this.gunaPanel6.Name = "gunaPanel6";
            this.gunaPanel6.Size = new System.Drawing.Size(1007, 5);
            this.gunaPanel6.TabIndex = 11;
            // 
            // gunaPanel7
            // 
            this.gunaPanel7.BackColor = System.Drawing.Color.Black;
            this.gunaPanel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaPanel7.Location = new System.Drawing.Point(1007, 45);
            this.gunaPanel7.Name = "gunaPanel7";
            this.gunaPanel7.Size = new System.Drawing.Size(5, 608);
            this.gunaPanel7.TabIndex = 11;
            // 
            // BusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 658);
            this.Controls.Add(this.gunaPanel7);
            this.Controls.Add(this.gunaPanel6);
            this.Controls.Add(this.gunaPanel5);
            this.Controls.Add(this.gunaPanel4);
            this.Controls.Add(this.gunaPanel3);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BusForm";
            this.Activated += new System.EventHandler(this.BusForm_Activated);
            this.Load += new System.EventHandler(this.BusForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBus)).EndInit();
            this.gunaPanel3.ResumeLayout(false);
            this.gunaPanel3.PerformLayout();
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel4.ResumeLayout(false);
            this.gunaPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaDataGridView dgBus;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaButton btnAffecter;
        private Guna.UI.WinForms.GunaButton BtnPrint;
        private Guna.UI.WinForms.GunaButton btnChange;
        private Guna.UI.WinForms.GunaButton btnSave;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private Guna.UI.WinForms.GunaButton btnListeAffectation;
        private Guna.UI.WinForms.GunaButton btnPaie;
        private Guna.UI.WinForms.GunaPanel gunaPanel4;
        private Guna.UI.WinForms.GunaLabel ttt;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaPanel gunaPanel7;
        private Guna.UI.WinForms.GunaPanel gunaPanel6;
        private Guna.UI.WinForms.GunaPanel gunaPanel5;
    }
}