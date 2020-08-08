namespace AplikasiPembukuan.View
{
    partial class FrmInputKaryawan
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
            this.cmbHakAkses = new Guna.UI.WinForms.GunaComboBox();
            this.rdoPerempuan = new Guna.UI.WinForms.GunaRadioButton();
            this.rdoLaki = new Guna.UI.WinForms.GunaRadioButton();
            this.txtTelepon = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.btnSimpan = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.lblHeader = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtKodeKaryawan = new Guna.UI.WinForms.GunaTextBox();
            this.txtNamaKaryawan = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbHakAkses
            // 
            this.cmbHakAkses.BackColor = System.Drawing.Color.Transparent;
            this.cmbHakAkses.BaseColor = System.Drawing.Color.White;
            this.cmbHakAkses.BorderColor = System.Drawing.Color.Silver;
            this.cmbHakAkses.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbHakAkses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHakAkses.FocusedColor = System.Drawing.Color.Empty;
            this.cmbHakAkses.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbHakAkses.ForeColor = System.Drawing.Color.Black;
            this.cmbHakAkses.FormattingEnabled = true;
            this.cmbHakAkses.Items.AddRange(new object[] {
            "1 - Admin",
            "2 - Kasir"});
            this.cmbHakAkses.Location = new System.Drawing.Point(147, 209);
            this.cmbHakAkses.Name = "cmbHakAkses";
            this.cmbHakAkses.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbHakAkses.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbHakAkses.Size = new System.Drawing.Size(173, 26);
            this.cmbHakAkses.TabIndex = 73;
            // 
            // rdoPerempuan
            // 
            this.rdoPerempuan.BaseColor = System.Drawing.SystemColors.Control;
            this.rdoPerempuan.CheckedOffColor = System.Drawing.Color.Gray;
            this.rdoPerempuan.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rdoPerempuan.FillColor = System.Drawing.Color.White;
            this.rdoPerempuan.Location = new System.Drawing.Point(260, 134);
            this.rdoPerempuan.Name = "rdoPerempuan";
            this.rdoPerempuan.Size = new System.Drawing.Size(88, 20);
            this.rdoPerempuan.TabIndex = 71;
            this.rdoPerempuan.Text = "Perempuan";
            // 
            // rdoLaki
            // 
            this.rdoLaki.BaseColor = System.Drawing.SystemColors.Control;
            this.rdoLaki.CheckedOffColor = System.Drawing.Color.Gray;
            this.rdoLaki.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rdoLaki.FillColor = System.Drawing.Color.White;
            this.rdoLaki.Location = new System.Drawing.Point(147, 134);
            this.rdoLaki.Name = "rdoLaki";
            this.rdoLaki.Size = new System.Drawing.Size(81, 20);
            this.rdoLaki.TabIndex = 70;
            this.rdoLaki.Text = "Laki - Laki";
            // 
            // txtTelepon
            // 
            this.txtTelepon.BaseColor = System.Drawing.Color.White;
            this.txtTelepon.BorderColor = System.Drawing.Color.Silver;
            this.txtTelepon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelepon.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTelepon.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTelepon.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTelepon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTelepon.Location = new System.Drawing.Point(147, 169);
            this.txtTelepon.Name = "txtTelepon";
            this.txtTelepon.PasswordChar = '\0';
            this.txtTelepon.SelectedText = "";
            this.txtTelepon.Size = new System.Drawing.Size(312, 30);
            this.txtTelepon.TabIndex = 69;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel8.Location = new System.Drawing.Point(26, 212);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(72, 19);
            this.gunaLabel8.TabIndex = 66;
            this.gunaLabel8.Text = "Hak Akses";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel6.Location = new System.Drawing.Point(26, 175);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(56, 19);
            this.gunaLabel6.TabIndex = 67;
            this.gunaLabel6.Text = "Telepon";
            // 
            // btnSimpan
            // 
            this.btnSimpan.AnimationHoverSpeed = 0.07F;
            this.btnSimpan.AnimationSpeed = 0.03F;
            this.btnSimpan.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSimpan.BorderColor = System.Drawing.Color.Black;
            this.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpan.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSimpan.FocusedColor = System.Drawing.Color.Empty;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Image = global::AplikasiPembukuan.Properties.Resources.check;
            this.btnSimpan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSimpan.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSimpan.Location = new System.Drawing.Point(147, 261);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSimpan.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSimpan.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSimpan.OnHoverImage = null;
            this.btnSimpan.OnPressedColor = System.Drawing.Color.Black;
            this.btnSimpan.Size = new System.Drawing.Size(94, 33);
            this.btnSimpan.TabIndex = 64;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gunaPanel1.Controls.Add(this.gunaControlBox1);
            this.gunaPanel1.Controls.Add(this.lblHeader);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(482, 29);
            this.gunaPanel1.TabIndex = 60;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(437, 0);
            this.gunaControlBox1.Margin = new System.Windows.Forms.Padding(0);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Location = new System.Drawing.Point(10, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(300, 29);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Tambah Data";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel1.Location = new System.Drawing.Point(26, 56);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(103, 19);
            this.gunaLabel1.TabIndex = 55;
            this.gunaLabel1.Text = "Kode Karyawan";
            // 
            // txtKodeKaryawan
            // 
            this.txtKodeKaryawan.BaseColor = System.Drawing.Color.White;
            this.txtKodeKaryawan.BorderColor = System.Drawing.Color.Silver;
            this.txtKodeKaryawan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKodeKaryawan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKodeKaryawan.FocusedBaseColor = System.Drawing.Color.White;
            this.txtKodeKaryawan.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtKodeKaryawan.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtKodeKaryawan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtKodeKaryawan.Location = new System.Drawing.Point(147, 50);
            this.txtKodeKaryawan.MaxLength = 7;
            this.txtKodeKaryawan.Name = "txtKodeKaryawan";
            this.txtKodeKaryawan.PasswordChar = '\0';
            this.txtKodeKaryawan.SelectedText = "";
            this.txtKodeKaryawan.Size = new System.Drawing.Size(173, 30);
            this.txtKodeKaryawan.TabIndex = 61;
            // 
            // txtNamaKaryawan
            // 
            this.txtNamaKaryawan.BaseColor = System.Drawing.Color.White;
            this.txtNamaKaryawan.BorderColor = System.Drawing.Color.Silver;
            this.txtNamaKaryawan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNamaKaryawan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNamaKaryawan.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNamaKaryawan.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNamaKaryawan.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNamaKaryawan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNamaKaryawan.Location = new System.Drawing.Point(147, 89);
            this.txtNamaKaryawan.Name = "txtNamaKaryawan";
            this.txtNamaKaryawan.PasswordChar = '\0';
            this.txtNamaKaryawan.SelectedText = "";
            this.txtNamaKaryawan.Size = new System.Drawing.Size(312, 30);
            this.txtNamaKaryawan.TabIndex = 63;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel3.Location = new System.Drawing.Point(26, 134);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(90, 19);
            this.gunaLabel3.TabIndex = 56;
            this.gunaLabel3.Text = "Jenis Kelamin";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel2.Location = new System.Drawing.Point(26, 95);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(108, 19);
            this.gunaLabel2.TabIndex = 59;
            this.gunaLabel2.Text = "Nama Karyawan";
            // 
            // FrmInputKaryawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 320);
            this.Controls.Add(this.cmbHakAkses);
            this.Controls.Add(this.rdoPerempuan);
            this.Controls.Add(this.rdoLaki);
            this.Controls.Add(this.txtTelepon);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txtKodeKaryawan);
            this.Controls.Add(this.txtNamaKaryawan);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmInputKaryawan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInputKaryawan";
            this.Shown += new System.EventHandler(this.FrmInputKaryawan_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmInputKaryawan_KeyPress);
            this.gunaPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaComboBox cmbHakAkses;
        private Guna.UI.WinForms.GunaRadioButton rdoPerempuan;
        private Guna.UI.WinForms.GunaRadioButton rdoLaki;
        private Guna.UI.WinForms.GunaTextBox txtTelepon;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaButton btnSimpan;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaLabel lblHeader;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txtKodeKaryawan;
        private Guna.UI.WinForms.GunaTextBox txtNamaKaryawan;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
    }
}