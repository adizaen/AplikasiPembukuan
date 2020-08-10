namespace AplikasiPembukuan.View
{
    partial class FrmMain
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
            this.txtHakAkses = new System.Windows.Forms.TextBox();
            this.txtNamaUser = new System.Windows.Forms.TextBox();
            this.lblNamaApps = new Guna.UI.WinForms.GunaLabel();
            this.lblVersiApps = new Guna.UI.WinForms.GunaLabel();
            this.btnMinimize = new Guna.UI.WinForms.GunaControlBox();
            this.lblHeader = new Guna.UI.WinForms.GunaLabel();
            this.btnExit = new Guna.UI.WinForms.GunaControlBox();
            this.txtKodeUser = new System.Windows.Forms.TextBox();
            this.panelUtama = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.pbLogo = new Guna.UI.WinForms.GunaPictureBox();
            this.menuDatabase = new Guna.UI.WinForms.GunaAdvenceButton();
            this.menuProfil = new Guna.UI.WinForms.GunaAdvenceButton();
            this.menuLaporan = new Guna.UI.WinForms.GunaAdvenceButton();
            this.menuPembukuan = new Guna.UI.WinForms.GunaAdvenceButton();
            this.menuKaryawan = new Guna.UI.WinForms.GunaAdvenceButton();
            this.menuDashboard = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panelUtama.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHakAkses
            // 
            this.txtHakAkses.Location = new System.Drawing.Point(18, 569);
            this.txtHakAkses.Name = "txtHakAkses";
            this.txtHakAkses.Size = new System.Drawing.Size(100, 25);
            this.txtHakAkses.TabIndex = 0;
            this.txtHakAkses.Visible = false;
            // 
            // txtNamaUser
            // 
            this.txtNamaUser.Location = new System.Drawing.Point(18, 543);
            this.txtNamaUser.Name = "txtNamaUser";
            this.txtNamaUser.Size = new System.Drawing.Size(100, 25);
            this.txtNamaUser.TabIndex = 0;
            this.txtNamaUser.Visible = false;
            // 
            // lblNamaApps
            // 
            this.lblNamaApps.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNamaApps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(207)))), ((int)(((byte)(106)))));
            this.lblNamaApps.Location = new System.Drawing.Point(0, 636);
            this.lblNamaApps.Name = "lblNamaApps";
            this.lblNamaApps.Size = new System.Drawing.Size(225, 21);
            this.lblNamaApps.TabIndex = 1;
            this.lblNamaApps.Text = "PEMBUKUAN APPS";
            this.lblNamaApps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVersiApps
            // 
            this.lblVersiApps.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblVersiApps.ForeColor = System.Drawing.Color.White;
            this.lblVersiApps.Location = new System.Drawing.Point(0, 657);
            this.lblVersiApps.Name = "lblVersiApps";
            this.lblVersiApps.Size = new System.Drawing.Size(225, 23);
            this.lblVersiApps.TabIndex = 1;
            this.lblVersiApps.Text = "version 1.0";
            this.lblVersiApps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Animated = true;
            this.btnMinimize.AnimationHoverSpeed = 0.07F;
            this.btnMinimize.AnimationSpeed = 0.03F;
            this.btnMinimize.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.btnMinimize.IconColor = System.Drawing.Color.Black;
            this.btnMinimize.IconSize = 15F;
            this.btnMinimize.Location = new System.Drawing.Point(856, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.OnHoverBackColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.OnHoverIconColor = System.Drawing.Color.White;
            this.btnMinimize.OnPressedColor = System.Drawing.Color.Black;
            this.btnMinimize.Size = new System.Drawing.Size(48, 29);
            this.btnMinimize.TabIndex = 5;
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Location = new System.Drawing.Point(14, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(219, 29);
            this.lblHeader.TabIndex = 4;
            this.lblHeader.Text = "Dashboard";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Animated = true;
            this.btnExit.AnimationHoverSpeed = 0.07F;
            this.btnExit.AnimationSpeed = 0.03F;
            this.btnExit.CustomClick = true;
            this.btnExit.IconColor = System.Drawing.Color.Black;
            this.btnExit.IconSize = 15F;
            this.btnExit.Location = new System.Drawing.Point(904, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.OnHoverIconColor = System.Drawing.Color.White;
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(48, 29);
            this.btnExit.TabIndex = 2;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtKodeUser
            // 
            this.txtKodeUser.Location = new System.Drawing.Point(18, 517);
            this.txtKodeUser.Name = "txtKodeUser";
            this.txtKodeUser.Size = new System.Drawing.Size(100, 25);
            this.txtKodeUser.TabIndex = 0;
            this.txtKodeUser.Visible = false;
            // 
            // panelUtama
            // 
            this.panelUtama.Controls.Add(this.txtHakAkses);
            this.panelUtama.Controls.Add(this.txtKodeUser);
            this.panelUtama.Controls.Add(this.txtNamaUser);
            this.panelUtama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUtama.Location = new System.Drawing.Point(225, 29);
            this.panelUtama.Name = "panelUtama";
            this.panelUtama.Size = new System.Drawing.Size(952, 664);
            this.panelUtama.TabIndex = 5;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gunaPanel2.Controls.Add(this.btnMinimize);
            this.gunaPanel2.Controls.Add(this.lblHeader);
            this.gunaPanel2.Controls.Add(this.btnExit);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel2.Location = new System.Drawing.Point(225, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(952, 29);
            this.gunaPanel2.TabIndex = 4;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(45)))));
            this.gunaPanel1.Controls.Add(this.pbLogo);
            this.gunaPanel1.Controls.Add(this.lblNamaApps);
            this.gunaPanel1.Controls.Add(this.lblVersiApps);
            this.gunaPanel1.Controls.Add(this.menuDatabase);
            this.gunaPanel1.Controls.Add(this.menuProfil);
            this.gunaPanel1.Controls.Add(this.menuLaporan);
            this.gunaPanel1.Controls.Add(this.menuPembukuan);
            this.gunaPanel1.Controls.Add(this.menuKaryawan);
            this.gunaPanel1.Controls.Add(this.menuDashboard);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(225, 693);
            this.gunaPanel1.TabIndex = 3;
            // 
            // pbLogo
            // 
            this.pbLogo.BaseColor = System.Drawing.Color.White;
            this.pbLogo.Image = global::AplikasiPembukuan.Properties.Resources.iconfinder_contacts_1055082;
            this.pbLogo.Location = new System.Drawing.Point(0, 32);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(225, 113);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // menuDatabase
            // 
            this.menuDatabase.AnimationHoverSpeed = 0.07F;
            this.menuDatabase.AnimationSpeed = 0.03F;
            this.menuDatabase.BackColor = System.Drawing.Color.Transparent;
            this.menuDatabase.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(45)))));
            this.menuDatabase.BorderColor = System.Drawing.Color.Black;
            this.menuDatabase.CheckedBaseColor = System.Drawing.Color.DimGray;
            this.menuDatabase.CheckedBorderColor = System.Drawing.Color.Black;
            this.menuDatabase.CheckedForeColor = System.Drawing.Color.White;
            this.menuDatabase.CheckedImage = global::AplikasiPembukuan.Properties.Resources.database4;
            this.menuDatabase.CheckedLineColor = System.Drawing.Color.DimGray;
            this.menuDatabase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuDatabase.DialogResult = System.Windows.Forms.DialogResult.None;
            this.menuDatabase.FocusedColor = System.Drawing.Color.Empty;
            this.menuDatabase.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuDatabase.ForeColor = System.Drawing.Color.White;
            this.menuDatabase.Image = global::AplikasiPembukuan.Properties.Resources.database4;
            this.menuDatabase.ImageSize = new System.Drawing.Size(20, 20);
            this.menuDatabase.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.menuDatabase.Location = new System.Drawing.Point(0, 448);
            this.menuDatabase.Name = "menuDatabase";
            this.menuDatabase.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.menuDatabase.OnHoverBorderColor = System.Drawing.Color.Black;
            this.menuDatabase.OnHoverForeColor = System.Drawing.Color.White;
            this.menuDatabase.OnHoverImage = null;
            this.menuDatabase.OnHoverLineColor = System.Drawing.Color.DimGray;
            this.menuDatabase.OnPressedColor = System.Drawing.Color.Black;
            this.menuDatabase.Size = new System.Drawing.Size(225, 51);
            this.menuDatabase.TabIndex = 0;
            this.menuDatabase.Text = "  Database";
            this.menuDatabase.UseTransfarantBackground = true;
            this.menuDatabase.Click += new System.EventHandler(this.menuDatabase_Click);
            // 
            // menuProfil
            // 
            this.menuProfil.AnimationHoverSpeed = 0.07F;
            this.menuProfil.AnimationSpeed = 0.03F;
            this.menuProfil.BackColor = System.Drawing.Color.Transparent;
            this.menuProfil.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(45)))));
            this.menuProfil.BorderColor = System.Drawing.Color.Black;
            this.menuProfil.CheckedBaseColor = System.Drawing.Color.DimGray;
            this.menuProfil.CheckedBorderColor = System.Drawing.Color.Black;
            this.menuProfil.CheckedForeColor = System.Drawing.Color.White;
            this.menuProfil.CheckedImage = global::AplikasiPembukuan.Properties.Resources.setting1;
            this.menuProfil.CheckedLineColor = System.Drawing.Color.DimGray;
            this.menuProfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuProfil.DialogResult = System.Windows.Forms.DialogResult.None;
            this.menuProfil.FocusedColor = System.Drawing.Color.Empty;
            this.menuProfil.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuProfil.ForeColor = System.Drawing.Color.White;
            this.menuProfil.Image = global::AplikasiPembukuan.Properties.Resources.setting1;
            this.menuProfil.ImageSize = new System.Drawing.Size(20, 20);
            this.menuProfil.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.menuProfil.Location = new System.Drawing.Point(0, 391);
            this.menuProfil.Name = "menuProfil";
            this.menuProfil.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.menuProfil.OnHoverBorderColor = System.Drawing.Color.Black;
            this.menuProfil.OnHoverForeColor = System.Drawing.Color.White;
            this.menuProfil.OnHoverImage = null;
            this.menuProfil.OnHoverLineColor = System.Drawing.Color.DimGray;
            this.menuProfil.OnPressedColor = System.Drawing.Color.Black;
            this.menuProfil.Size = new System.Drawing.Size(225, 51);
            this.menuProfil.TabIndex = 0;
            this.menuProfil.Text = "  Profil";
            this.menuProfil.UseTransfarantBackground = true;
            this.menuProfil.Click += new System.EventHandler(this.menuProfil_Click);
            // 
            // menuLaporan
            // 
            this.menuLaporan.AnimationHoverSpeed = 0.07F;
            this.menuLaporan.AnimationSpeed = 0.03F;
            this.menuLaporan.BackColor = System.Drawing.Color.Transparent;
            this.menuLaporan.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(45)))));
            this.menuLaporan.BorderColor = System.Drawing.Color.Black;
            this.menuLaporan.CheckedBaseColor = System.Drawing.Color.DimGray;
            this.menuLaporan.CheckedBorderColor = System.Drawing.Color.Black;
            this.menuLaporan.CheckedForeColor = System.Drawing.Color.White;
            this.menuLaporan.CheckedImage = global::AplikasiPembukuan.Properties.Resources.report;
            this.menuLaporan.CheckedLineColor = System.Drawing.Color.DimGray;
            this.menuLaporan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuLaporan.DialogResult = System.Windows.Forms.DialogResult.None;
            this.menuLaporan.FocusedColor = System.Drawing.Color.Empty;
            this.menuLaporan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuLaporan.ForeColor = System.Drawing.Color.White;
            this.menuLaporan.Image = global::AplikasiPembukuan.Properties.Resources.report;
            this.menuLaporan.ImageSize = new System.Drawing.Size(20, 20);
            this.menuLaporan.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.menuLaporan.Location = new System.Drawing.Point(0, 340);
            this.menuLaporan.Name = "menuLaporan";
            this.menuLaporan.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.menuLaporan.OnHoverBorderColor = System.Drawing.Color.Black;
            this.menuLaporan.OnHoverForeColor = System.Drawing.Color.White;
            this.menuLaporan.OnHoverImage = null;
            this.menuLaporan.OnHoverLineColor = System.Drawing.Color.DimGray;
            this.menuLaporan.OnPressedColor = System.Drawing.Color.Black;
            this.menuLaporan.Size = new System.Drawing.Size(225, 51);
            this.menuLaporan.TabIndex = 0;
            this.menuLaporan.Text = "  Laporan";
            this.menuLaporan.UseTransfarantBackground = true;
            this.menuLaporan.Click += new System.EventHandler(this.menuLaporan_Click);
            // 
            // menuPembukuan
            // 
            this.menuPembukuan.AnimationHoverSpeed = 0.07F;
            this.menuPembukuan.AnimationSpeed = 0.03F;
            this.menuPembukuan.BackColor = System.Drawing.Color.Transparent;
            this.menuPembukuan.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(45)))));
            this.menuPembukuan.BorderColor = System.Drawing.Color.Black;
            this.menuPembukuan.CheckedBaseColor = System.Drawing.Color.DimGray;
            this.menuPembukuan.CheckedBorderColor = System.Drawing.Color.Black;
            this.menuPembukuan.CheckedForeColor = System.Drawing.Color.White;
            this.menuPembukuan.CheckedImage = global::AplikasiPembukuan.Properties.Resources.book;
            this.menuPembukuan.CheckedLineColor = System.Drawing.Color.DimGray;
            this.menuPembukuan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuPembukuan.DialogResult = System.Windows.Forms.DialogResult.None;
            this.menuPembukuan.FocusedColor = System.Drawing.Color.Empty;
            this.menuPembukuan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuPembukuan.ForeColor = System.Drawing.Color.White;
            this.menuPembukuan.Image = global::AplikasiPembukuan.Properties.Resources.book;
            this.menuPembukuan.ImageSize = new System.Drawing.Size(20, 20);
            this.menuPembukuan.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.menuPembukuan.Location = new System.Drawing.Point(0, 289);
            this.menuPembukuan.Name = "menuPembukuan";
            this.menuPembukuan.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.menuPembukuan.OnHoverBorderColor = System.Drawing.Color.Black;
            this.menuPembukuan.OnHoverForeColor = System.Drawing.Color.White;
            this.menuPembukuan.OnHoverImage = null;
            this.menuPembukuan.OnHoverLineColor = System.Drawing.Color.DimGray;
            this.menuPembukuan.OnPressedColor = System.Drawing.Color.Black;
            this.menuPembukuan.Size = new System.Drawing.Size(225, 51);
            this.menuPembukuan.TabIndex = 0;
            this.menuPembukuan.Text = "  Pembukuan";
            this.menuPembukuan.UseTransfarantBackground = true;
            this.menuPembukuan.Click += new System.EventHandler(this.menuPembukuan_Click);
            // 
            // menuKaryawan
            // 
            this.menuKaryawan.AnimationHoverSpeed = 0.07F;
            this.menuKaryawan.AnimationSpeed = 0.03F;
            this.menuKaryawan.BackColor = System.Drawing.Color.Transparent;
            this.menuKaryawan.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(45)))));
            this.menuKaryawan.BorderColor = System.Drawing.Color.Black;
            this.menuKaryawan.CheckedBaseColor = System.Drawing.Color.DimGray;
            this.menuKaryawan.CheckedBorderColor = System.Drawing.Color.Black;
            this.menuKaryawan.CheckedForeColor = System.Drawing.Color.White;
            this.menuKaryawan.CheckedImage = global::AplikasiPembukuan.Properties.Resources.employee;
            this.menuKaryawan.CheckedLineColor = System.Drawing.Color.DimGray;
            this.menuKaryawan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuKaryawan.DialogResult = System.Windows.Forms.DialogResult.None;
            this.menuKaryawan.FocusedColor = System.Drawing.Color.Empty;
            this.menuKaryawan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuKaryawan.ForeColor = System.Drawing.Color.White;
            this.menuKaryawan.Image = global::AplikasiPembukuan.Properties.Resources.employee;
            this.menuKaryawan.ImageSize = new System.Drawing.Size(20, 20);
            this.menuKaryawan.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.menuKaryawan.Location = new System.Drawing.Point(0, 238);
            this.menuKaryawan.Name = "menuKaryawan";
            this.menuKaryawan.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.menuKaryawan.OnHoverBorderColor = System.Drawing.Color.Black;
            this.menuKaryawan.OnHoverForeColor = System.Drawing.Color.White;
            this.menuKaryawan.OnHoverImage = null;
            this.menuKaryawan.OnHoverLineColor = System.Drawing.Color.DimGray;
            this.menuKaryawan.OnPressedColor = System.Drawing.Color.Black;
            this.menuKaryawan.Size = new System.Drawing.Size(225, 51);
            this.menuKaryawan.TabIndex = 0;
            this.menuKaryawan.Text = "  Data Karyawan";
            this.menuKaryawan.UseTransfarantBackground = true;
            this.menuKaryawan.Click += new System.EventHandler(this.menuKaryawan_Click);
            // 
            // menuDashboard
            // 
            this.menuDashboard.AnimationHoverSpeed = 0.07F;
            this.menuDashboard.AnimationSpeed = 0.03F;
            this.menuDashboard.BackColor = System.Drawing.Color.Transparent;
            this.menuDashboard.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(45)))));
            this.menuDashboard.BorderColor = System.Drawing.Color.Black;
            this.menuDashboard.Checked = true;
            this.menuDashboard.CheckedBaseColor = System.Drawing.Color.DimGray;
            this.menuDashboard.CheckedBorderColor = System.Drawing.Color.Black;
            this.menuDashboard.CheckedForeColor = System.Drawing.Color.White;
            this.menuDashboard.CheckedImage = global::AplikasiPembukuan.Properties.Resources.dasboard1;
            this.menuDashboard.CheckedLineColor = System.Drawing.Color.DimGray;
            this.menuDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuDashboard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.menuDashboard.FocusedColor = System.Drawing.Color.Empty;
            this.menuDashboard.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuDashboard.ForeColor = System.Drawing.Color.White;
            this.menuDashboard.Image = global::AplikasiPembukuan.Properties.Resources.dasboard1;
            this.menuDashboard.ImageSize = new System.Drawing.Size(20, 20);
            this.menuDashboard.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.menuDashboard.Location = new System.Drawing.Point(0, 187);
            this.menuDashboard.Name = "menuDashboard";
            this.menuDashboard.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.menuDashboard.OnHoverBorderColor = System.Drawing.Color.Black;
            this.menuDashboard.OnHoverForeColor = System.Drawing.Color.White;
            this.menuDashboard.OnHoverImage = null;
            this.menuDashboard.OnHoverLineColor = System.Drawing.Color.DimGray;
            this.menuDashboard.OnPressedColor = System.Drawing.Color.Black;
            this.menuDashboard.Size = new System.Drawing.Size(225, 51);
            this.menuDashboard.TabIndex = 0;
            this.menuDashboard.Text = "  Dashboard";
            this.menuDashboard.UseTransfarantBackground = true;
            this.menuDashboard.Click += new System.EventHandler(this.menuDashboard_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 693);
            this.Controls.Add(this.panelUtama);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.panelUtama.ResumeLayout(false);
            this.panelUtama.PerformLayout();
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TextBox txtHakAkses;
        internal System.Windows.Forms.TextBox txtNamaUser;
        private Guna.UI.WinForms.GunaPictureBox pbLogo;
        private Guna.UI.WinForms.GunaLabel lblNamaApps;
        private Guna.UI.WinForms.GunaLabel lblVersiApps;
        private Guna.UI.WinForms.GunaControlBox btnMinimize;
        private Guna.UI.WinForms.GunaLabel lblHeader;
        private Guna.UI.WinForms.GunaControlBox btnExit;
        internal Guna.UI.WinForms.GunaAdvenceButton menuLaporan;
        internal Guna.UI.WinForms.GunaAdvenceButton menuPembukuan;
        internal Guna.UI.WinForms.GunaAdvenceButton menuKaryawan;
        internal Guna.UI.WinForms.GunaAdvenceButton menuDashboard;
        internal System.Windows.Forms.TextBox txtKodeUser;
        public Guna.UI.WinForms.GunaPanel panelUtama;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        internal Guna.UI.WinForms.GunaAdvenceButton menuProfil;
        internal Guna.UI.WinForms.GunaAdvenceButton menuDatabase;
    }
}