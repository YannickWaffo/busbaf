namespace BusBaf.View
{
    partial class MenuForm2
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
            this.ucItHistorique = new BusBaf.View.UCItemMenu();
            this.ucItDriver = new BusBaf.View.UCItemMenu();
            this.ucItUser = new BusBaf.View.UCItemMenu();
            this.ucItBus = new BusBaf.View.UCItemMenu();
            this.ucItPoint = new BusBaf.View.UCItemMenu();
            this.ucItCarte = new BusBaf.View.UCItemMenu();
            this.ucItLigne = new BusBaf.View.UCItemMenu();
            this.ucItPay = new BusBaf.View.UCItemMenu();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 0;
            this.gunaElipse1.TargetControl = this;
            // 
            // ucItHistorique
            // 
            this.ucItHistorique.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucItHistorique.AutoSize = true;
            this.ucItHistorique.ChangeDesc = "Consulter";
            this.ucItHistorique.ChangeName = "HISTORIQUE";
            this.ucItHistorique.ChangePic = global::BusBaf.Properties.Resources._017_clock_2;
            this.ucItHistorique.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucItHistorique.Location = new System.Drawing.Point(709, 347);
            this.ucItHistorique.Name = "ucItHistorique";
            this.ucItHistorique.Size = new System.Drawing.Size(192, 220);
            this.ucItHistorique.TabIndex = 2;
            this.ucItHistorique.Click += new System.EventHandler(this.ucItHistorique_Click);
            // 
            // ucItDriver
            // 
            this.ucItDriver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucItDriver.AutoSize = true;
            this.ucItDriver.ChangeDesc = "Creer, Modifier, Supprimer, Attribuer";
            this.ucItDriver.ChangeName = "CHAUFFEUR";
            this.ucItDriver.ChangePic = global::BusBaf.Properties.Resources._077_people_1;
            this.ucItDriver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucItDriver.Location = new System.Drawing.Point(709, 86);
            this.ucItDriver.Name = "ucItDriver";
            this.ucItDriver.Size = new System.Drawing.Size(192, 220);
            this.ucItDriver.TabIndex = 2;
            this.ucItDriver.Click += new System.EventHandler(this.ucItDriver_Click);
            // 
            // ucItUser
            // 
            this.ucItUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucItUser.AutoSize = true;
            this.ucItUser.ChangeDesc = "Creer, Modifier, Supprimer, Consulter";
            this.ucItUser.ChangeName = "STATISTIQUE";
            this.ucItUser.ChangePic = global::BusBaf.Properties.Resources.combo_ch1;
            this.ucItUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucItUser.Location = new System.Drawing.Point(493, 347);
            this.ucItUser.Name = "ucItUser";
            this.ucItUser.Size = new System.Drawing.Size(192, 220);
            this.ucItUser.TabIndex = 2;
            this.ucItUser.Click += new System.EventHandler(this.ucItUser_Click);
            // 
            // ucItBus
            // 
            this.ucItBus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucItBus.AutoSize = true;
            this.ucItBus.ChangeDesc = "Creer, Modifier, Consulter,  Attribuer";
            this.ucItBus.ChangeName = "BUS";
            this.ucItBus.ChangePic = global::BusBaf.Properties.Resources._006_bus_3;
            this.ucItBus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucItBus.Location = new System.Drawing.Point(493, 86);
            this.ucItBus.Name = "ucItBus";
            this.ucItBus.Size = new System.Drawing.Size(192, 220);
            this.ucItBus.TabIndex = 2;
            this.ucItBus.Click += new System.EventHandler(this.ucItBus_Click);
            // 
            // ucItPoint
            // 
            this.ucItPoint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucItPoint.AutoSize = true;
            this.ucItPoint.ChangeDesc = "Creer, Modifier, Supprimer";
            this.ucItPoint.ChangeName = "POINT";
            this.ucItPoint.ChangePic = global::BusBaf.Properties.Resources._007_bus_stop;
            this.ucItPoint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucItPoint.Location = new System.Drawing.Point(278, 347);
            this.ucItPoint.Name = "ucItPoint";
            this.ucItPoint.Size = new System.Drawing.Size(192, 220);
            this.ucItPoint.TabIndex = 2;
            this.ucItPoint.Click += new System.EventHandler(this.ucItPoint_Click);
            // 
            // ucItCarte
            // 
            this.ucItCarte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucItCarte.AutoSize = true;
            this.ucItCarte.ChangeDesc = "Creer, Modifier, Supprimer,Consulter";
            this.ucItCarte.ChangeName = "CARTE";
            this.ucItCarte.ChangePic = global::BusBaf.Properties.Resources._023_bus_12;
            this.ucItCarte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucItCarte.Location = new System.Drawing.Point(278, 86);
            this.ucItCarte.Name = "ucItCarte";
            this.ucItCarte.Size = new System.Drawing.Size(192, 220);
            this.ucItCarte.TabIndex = 2;
            this.ucItCarte.Click += new System.EventHandler(this.ucItCarte_Click);
            this.ucItCarte.Load += new System.EventHandler(this.ucItCarte_Load);
            // 
            // ucItLigne
            // 
            this.ucItLigne.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucItLigne.AutoSize = true;
            this.ucItLigne.ChangeDesc = "Creer, Modifier, Supprimer";
            this.ucItLigne.ChangeName = "LIGNE";
            this.ucItLigne.ChangePic = global::BusBaf.Properties.Resources._020_bus_stop_4;
            this.ucItLigne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucItLigne.Location = new System.Drawing.Point(63, 347);
            this.ucItLigne.Name = "ucItLigne";
            this.ucItLigne.Size = new System.Drawing.Size(192, 220);
            this.ucItLigne.TabIndex = 1;
            this.ucItLigne.Click += new System.EventHandler(this.ucItLigne_Click);
            // 
            // ucItPay
            // 
            this.ucItPay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucItPay.AutoSize = true;
            this.ucItPay.ChangeDesc = "Creer, Modifier, Supprimer, Consulter";
            this.ucItPay.ChangeName = "VERSEMENT";
            this.ucItPay.ChangePic = global::BusBaf.Properties.Resources._030_online_shop;
            this.ucItPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucItPay.Location = new System.Drawing.Point(63, 86);
            this.ucItPay.Name = "ucItPay";
            this.ucItPay.Size = new System.Drawing.Size(192, 220);
            this.ucItPay.TabIndex = 1;
            this.ucItPay.Click += new System.EventHandler(this.ucItPay_Click);
            // 
            // MenuForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(970, 626);
            this.Controls.Add(this.ucItHistorique);
            this.Controls.Add(this.ucItDriver);
            this.Controls.Add(this.ucItUser);
            this.Controls.Add(this.ucItBus);
            this.Controls.Add(this.ucItPoint);
            this.Controls.Add(this.ucItCarte);
            this.Controls.Add(this.ucItLigne);
            this.Controls.Add(this.ucItPay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuForm2";
            this.Text = "MenuForm2";
            this.Activated += new System.EventHandler(this.MenuForm2_Activated);
            this.Load += new System.EventHandler(this.MenuForm2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private UCItemMenu ucItPay;
        private UCItemMenu ucItHistorique;
        private UCItemMenu ucItDriver;
        private UCItemMenu ucItBus;
        private UCItemMenu ucItCarte;
        private UCItemMenu ucItUser;
        private UCItemMenu ucItPoint;
        private UCItemMenu ucItLigne;
    }
}