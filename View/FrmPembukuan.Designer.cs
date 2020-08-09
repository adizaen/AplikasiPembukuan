namespace AplikasiPembukuan
{
    partial class FrmPembukuan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPembukuan));
            this.txtKaryawan = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.dgv = new Guna.UI.WinForms.GunaDataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tempat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Laba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Keterangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtTanggal = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtTotalDebit = new Guna.UI.WinForms.GunaTextBox();
            this.txtTotalKredit = new Guna.UI.WinForms.GunaTextBox();
            this.btnHapus = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnTambah = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnUbah = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKaryawan
            // 
            this.txtKaryawan.BackColor = System.Drawing.Color.Transparent;
            this.txtKaryawan.BaseColor = System.Drawing.Color.White;
            this.txtKaryawan.BorderColor = System.Drawing.Color.Silver;
            this.txtKaryawan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKaryawan.FocusedBaseColor = System.Drawing.Color.White;
            this.txtKaryawan.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtKaryawan.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtKaryawan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtKaryawan.Location = new System.Drawing.Point(103, 53);
            this.txtKaryawan.Name = "txtKaryawan";
            this.txtKaryawan.PasswordChar = '\0';
            this.txtKaryawan.ReadOnly = true;
            this.txtKaryawan.SelectedText = "";
            this.txtKaryawan.Size = new System.Drawing.Size(318, 28);
            this.txtKaryawan.TabIndex = 36;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel2.Location = new System.Drawing.Point(22, 55);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(68, 19);
            this.gunaLabel2.TabIndex = 34;
            this.gunaLabel2.Text = "Karyawan";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel1.Location = new System.Drawing.Point(22, 21);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(55, 19);
            this.gunaLabel1.TabIndex = 35;
            this.gunaLabel1.Text = "Tanggal";
            // 
            // dgv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeight = 30;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.ID,
            this.Nama,
            this.Gender,
            this.Tempat,
            this.Hak,
            this.Laba,
            this.Keterangan});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv.Location = new System.Drawing.Point(26, 97);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 30;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(900, 490);
            this.dgv.TabIndex = 39;
            this.dgv.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv.ThemeStyle.HeaderStyle.Height = 30;
            this.dgv.ThemeStyle.ReadOnly = false;
            this.dgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv.ThemeStyle.RowsStyle.Height = 30;
            this.dgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.No.HeaderText = "No";
            this.No.MinimumWidth = 80;
            this.No.Name = "No";
            this.No.Width = 80;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Nama
            // 
            this.Nama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nama.HeaderText = "Nama Item";
            this.Nama.MinimumWidth = 250;
            this.Nama.Name = "Nama";
            this.Nama.Width = 250;
            // 
            // Gender
            // 
            this.Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Gender.DefaultCellStyle = dataGridViewCellStyle3;
            this.Gender.HeaderText = "Debit";
            this.Gender.MinimumWidth = 100;
            this.Gender.Name = "Gender";
            // 
            // Tempat
            // 
            this.Tempat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Tempat.DefaultCellStyle = dataGridViewCellStyle4;
            this.Tempat.HeaderText = "Kredit";
            this.Tempat.MinimumWidth = 100;
            this.Tempat.Name = "Tempat";
            // 
            // Hak
            // 
            this.Hak.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Hak.DefaultCellStyle = dataGridViewCellStyle5;
            this.Hak.HeaderText = "Saldo";
            this.Hak.MinimumWidth = 100;
            this.Hak.Name = "Hak";
            // 
            // Laba
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Laba.DefaultCellStyle = dataGridViewCellStyle6;
            this.Laba.HeaderText = "Laba";
            this.Laba.MinimumWidth = 100;
            this.Laba.Name = "Laba";
            // 
            // Keterangan
            // 
            this.Keterangan.HeaderText = "Keterangan";
            this.Keterangan.MinimumWidth = 150;
            this.Keterangan.Name = "Keterangan";
            // 
            // dtTanggal
            // 
            this.dtTanggal.BaseColor = System.Drawing.Color.White;
            this.dtTanggal.BorderColor = System.Drawing.Color.Silver;
            this.dtTanggal.CustomFormat = null;
            this.dtTanggal.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtTanggal.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtTanggal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtTanggal.ForeColor = System.Drawing.Color.Black;
            this.dtTanggal.Location = new System.Drawing.Point(103, 18);
            this.dtTanggal.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtTanggal.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtTanggal.Name = "dtTanggal";
            this.dtTanggal.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtTanggal.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtTanggal.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtTanggal.OnPressedColor = System.Drawing.Color.Black;
            this.dtTanggal.Size = new System.Drawing.Size(201, 30);
            this.dtTanggal.TabIndex = 40;
            this.dtTanggal.Text = "07 August 2020";
            this.dtTanggal.Value = new System.DateTime(2020, 8, 7, 20, 46, 33, 522);
            this.dtTanggal.ValueChanged += new System.EventHandler(this.dtTanggal_ValueChanged);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel3.Location = new System.Drawing.Point(604, 21);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(75, 19);
            this.gunaLabel3.TabIndex = 41;
            this.gunaLabel3.Text = "Total Debit";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel4.Location = new System.Drawing.Point(604, 56);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(78, 19);
            this.gunaLabel4.TabIndex = 41;
            this.gunaLabel4.Text = "Total Kredit";
            // 
            // txtTotalDebit
            // 
            this.txtTotalDebit.BackColor = System.Drawing.Color.Transparent;
            this.txtTotalDebit.BaseColor = System.Drawing.Color.White;
            this.txtTotalDebit.BorderColor = System.Drawing.Color.Silver;
            this.txtTotalDebit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalDebit.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTotalDebit.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTotalDebit.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTotalDebit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTotalDebit.Location = new System.Drawing.Point(739, 18);
            this.txtTotalDebit.Name = "txtTotalDebit";
            this.txtTotalDebit.PasswordChar = '\0';
            this.txtTotalDebit.ReadOnly = true;
            this.txtTotalDebit.SelectedText = "";
            this.txtTotalDebit.Size = new System.Drawing.Size(187, 28);
            this.txtTotalDebit.TabIndex = 42;
            this.txtTotalDebit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalDebit.TextChanged += new System.EventHandler(this.txtTotalDebit_TextChanged);
            // 
            // txtTotalKredit
            // 
            this.txtTotalKredit.BackColor = System.Drawing.Color.Transparent;
            this.txtTotalKredit.BaseColor = System.Drawing.Color.White;
            this.txtTotalKredit.BorderColor = System.Drawing.Color.Silver;
            this.txtTotalKredit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalKredit.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTotalKredit.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTotalKredit.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTotalKredit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTotalKredit.Location = new System.Drawing.Point(739, 52);
            this.txtTotalKredit.Name = "txtTotalKredit";
            this.txtTotalKredit.PasswordChar = '\0';
            this.txtTotalKredit.ReadOnly = true;
            this.txtTotalKredit.SelectedText = "";
            this.txtTotalKredit.Size = new System.Drawing.Size(187, 28);
            this.txtTotalKredit.TabIndex = 42;
            this.txtTotalKredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalKredit.TextChanged += new System.EventHandler(this.txtTotalKredit_TextChanged);
            // 
            // btnHapus
            // 
            this.btnHapus.AnimationHoverSpeed = 0.07F;
            this.btnHapus.AnimationSpeed = 0.03F;
            this.btnHapus.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(101)))), ((int)(((byte)(199)))));
            this.btnHapus.BorderColor = System.Drawing.Color.Black;
            this.btnHapus.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnHapus.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnHapus.CheckedForeColor = System.Drawing.Color.White;
            this.btnHapus.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnHapus.CheckedImage")));
            this.btnHapus.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHapus.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHapus.FocusedColor = System.Drawing.Color.Empty;
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Image = global::AplikasiPembukuan.Properties.Resources.hapus3;
            this.btnHapus.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnHapus.ImageSize = new System.Drawing.Size(20, 20);
            this.btnHapus.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnHapus.Location = new System.Drawing.Point(294, 605);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(128)))), ((int)(((byte)(250)))));
            this.btnHapus.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHapus.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHapus.OnHoverImage = null;
            this.btnHapus.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(134)))), ((int)(((byte)(235)))));
            this.btnHapus.OnPressedColor = System.Drawing.Color.Black;
            this.btnHapus.Size = new System.Drawing.Size(128, 36);
            this.btnHapus.TabIndex = 31;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.AnimationHoverSpeed = 0.07F;
            this.btnTambah.AnimationSpeed = 0.03F;
            this.btnTambah.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(101)))), ((int)(((byte)(199)))));
            this.btnTambah.BorderColor = System.Drawing.Color.Black;
            this.btnTambah.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnTambah.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnTambah.CheckedForeColor = System.Drawing.Color.White;
            this.btnTambah.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnTambah.CheckedImage")));
            this.btnTambah.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnTambah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTambah.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTambah.FocusedColor = System.Drawing.Color.Empty;
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Image = global::AplikasiPembukuan.Properties.Resources.add;
            this.btnTambah.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTambah.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTambah.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnTambah.Location = new System.Drawing.Point(26, 605);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(128)))), ((int)(((byte)(250)))));
            this.btnTambah.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTambah.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTambah.OnHoverImage = null;
            this.btnTambah.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(134)))), ((int)(((byte)(235)))));
            this.btnTambah.OnPressedColor = System.Drawing.Color.Black;
            this.btnTambah.Size = new System.Drawing.Size(128, 36);
            this.btnTambah.TabIndex = 33;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.AnimationHoverSpeed = 0.07F;
            this.btnUbah.AnimationSpeed = 0.03F;
            this.btnUbah.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(101)))), ((int)(((byte)(199)))));
            this.btnUbah.BorderColor = System.Drawing.Color.Black;
            this.btnUbah.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnUbah.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnUbah.CheckedForeColor = System.Drawing.Color.White;
            this.btnUbah.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnUbah.CheckedImage")));
            this.btnUbah.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnUbah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUbah.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUbah.FocusedColor = System.Drawing.Color.Empty;
            this.btnUbah.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnUbah.ForeColor = System.Drawing.Color.White;
            this.btnUbah.Image = global::AplikasiPembukuan.Properties.Resources.edit3;
            this.btnUbah.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUbah.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUbah.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnUbah.Location = new System.Drawing.Point(160, 605);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(128)))), ((int)(((byte)(250)))));
            this.btnUbah.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUbah.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUbah.OnHoverImage = null;
            this.btnUbah.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(134)))), ((int)(((byte)(235)))));
            this.btnUbah.OnPressedColor = System.Drawing.Color.Black;
            this.btnUbah.Size = new System.Drawing.Size(128, 36);
            this.btnUbah.TabIndex = 32;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel5.Location = new System.Drawing.Point(701, 56);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(35, 19);
            this.gunaLabel5.TabIndex = 43;
            this.gunaLabel5.Text = ": Rp";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel6.Location = new System.Drawing.Point(701, 21);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(35, 19);
            this.gunaLabel6.TabIndex = 44;
            this.gunaLabel6.Text = ": Rp";
            // 
            // FrmPembukuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 664);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.txtTotalKredit);
            this.Controls.Add(this.txtTotalDebit);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.dtTanggal);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.txtKaryawan);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnUbah);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmPembukuan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Pembukuan";
            this.Shown += new System.EventHandler(this.FrmPembukuan_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox txtKaryawan;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaAdvenceButton btnHapus;
        private Guna.UI.WinForms.GunaAdvenceButton btnTambah;
        private Guna.UI.WinForms.GunaAdvenceButton btnUbah;
        private Guna.UI.WinForms.GunaDataGridView dgv;
        private Guna.UI.WinForms.GunaDateTimePicker dtTanggal;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox txtTotalDebit;
        private Guna.UI.WinForms.GunaTextBox txtTotalKredit;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tempat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hak;
        private System.Windows.Forms.DataGridViewTextBoxColumn Laba;
        private System.Windows.Forms.DataGridViewTextBoxColumn Keterangan;
    }
}

