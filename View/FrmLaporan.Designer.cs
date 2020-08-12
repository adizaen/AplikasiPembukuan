namespace AplikasiPembukuan.View
{
    partial class FrmLaporan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLaporan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvHarian = new Guna.UI.WinForms.GunaDataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tempat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Laba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Keterangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtTanggal = new Guna.UI.WinForms.GunaDateTimePicker();
            this.cmbBulan = new Guna.UI.WinForms.GunaComboBox();
            this.cmbTahun = new Guna.UI.WinForms.GunaComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.rdoBulan = new Guna.UI.WinForms.GunaRadioButton();
            this.rdoPeriodeTanggal = new Guna.UI.WinForms.GunaRadioButton();
            this.rdoTanggal = new Guna.UI.WinForms.GunaRadioButton();
            this.dtTanggalAkhir = new Guna.UI.WinForms.GunaDateTimePicker();
            this.dtTanggalMulai = new Guna.UI.WinForms.GunaDateTimePicker();
            this.btnTampilkan = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnExcel = new Guna.UI.WinForms.GunaAdvenceButton();
            this.dgvBulanan = new Guna.UI.WinForms.GunaDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesanDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHarian)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBulanan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHarian
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvHarian.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHarian.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHarian.BackgroundColor = System.Drawing.Color.White;
            this.dgvHarian.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHarian.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHarian.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHarian.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHarian.ColumnHeadersHeight = 30;
            this.dgvHarian.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Kode,
            this.Nama,
            this.Gender,
            this.Tempat,
            this.Hak,
            this.Laba,
            this.Keterangan});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHarian.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHarian.EnableHeadersVisualStyles = false;
            this.dgvHarian.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHarian.Location = new System.Drawing.Point(28, 177);
            this.dgvHarian.Name = "dgvHarian";
            this.dgvHarian.RowHeadersVisible = false;
            this.dgvHarian.RowTemplate.Height = 30;
            this.dgvHarian.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHarian.Size = new System.Drawing.Size(900, 208);
            this.dgvHarian.TabIndex = 30;
            this.dgvHarian.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvHarian.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHarian.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvHarian.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvHarian.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvHarian.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvHarian.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvHarian.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHarian.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvHarian.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHarian.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHarian.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvHarian.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvHarian.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvHarian.ThemeStyle.ReadOnly = false;
            this.dgvHarian.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHarian.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHarian.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHarian.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvHarian.ThemeStyle.RowsStyle.Height = 30;
            this.dgvHarian.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHarian.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.No.HeaderText = "No";
            this.No.MinimumWidth = 70;
            this.No.Name = "No";
            this.No.Width = 70;
            // 
            // Kode
            // 
            this.Kode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Kode.HeaderText = "Tanggal";
            this.Kode.MinimumWidth = 150;
            this.Kode.Name = "Kode";
            this.Kode.Width = 150;
            // 
            // Nama
            // 
            this.Nama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nama.HeaderText = "Nama Item";
            this.Nama.MinimumWidth = 220;
            this.Nama.Name = "Nama";
            this.Nama.Width = 220;
            // 
            // Gender
            // 
            this.Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Gender.HeaderText = "Debit";
            this.Gender.MinimumWidth = 100;
            this.Gender.Name = "Gender";
            // 
            // Tempat
            // 
            this.Tempat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Tempat.HeaderText = "Kredit";
            this.Tempat.MinimumWidth = 100;
            this.Tempat.Name = "Tempat";
            // 
            // Hak
            // 
            this.Hak.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Hak.HeaderText = "Saldo";
            this.Hak.MinimumWidth = 100;
            this.Hak.Name = "Hak";
            // 
            // Laba
            // 
            this.Laba.HeaderText = "Laba";
            this.Laba.MinimumWidth = 100;
            this.Laba.Name = "Laba";
            // 
            // Keterangan
            // 
            this.Keterangan.HeaderText = "Keterangan";
            this.Keterangan.MinimumWidth = 200;
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
            this.dtTanggal.Location = new System.Drawing.Point(143, 23);
            this.dtTanggal.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtTanggal.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtTanggal.Name = "dtTanggal";
            this.dtTanggal.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtTanggal.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtTanggal.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtTanggal.OnPressedColor = System.Drawing.Color.Black;
            this.dtTanggal.Size = new System.Drawing.Size(277, 30);
            this.dtTanggal.TabIndex = 38;
            this.dtTanggal.Text = "07 August 2020";
            this.dtTanggal.Value = new System.DateTime(2020, 8, 7, 20, 46, 33, 522);
            // 
            // cmbBulan
            // 
            this.cmbBulan.BackColor = System.Drawing.Color.Transparent;
            this.cmbBulan.BaseColor = System.Drawing.Color.White;
            this.cmbBulan.BorderColor = System.Drawing.Color.Silver;
            this.cmbBulan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBulan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBulan.FocusedColor = System.Drawing.Color.Empty;
            this.cmbBulan.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbBulan.ForeColor = System.Drawing.Color.Black;
            this.cmbBulan.FormattingEnabled = true;
            this.cmbBulan.Items.AddRange(new object[] {
            "Januari",
            "Februari",
            "Maret",
            "April",
            "Mei",
            "Juni",
            "Juli",
            "Agustus",
            "September",
            "Oktober",
            "November",
            "Desember"});
            this.cmbBulan.Location = new System.Drawing.Point(143, 59);
            this.cmbBulan.Name = "cmbBulan";
            this.cmbBulan.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbBulan.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbBulan.Size = new System.Drawing.Size(184, 28);
            this.cmbBulan.TabIndex = 37;
            // 
            // cmbTahun
            // 
            this.cmbTahun.BackColor = System.Drawing.Color.Transparent;
            this.cmbTahun.BaseColor = System.Drawing.Color.White;
            this.cmbTahun.BorderColor = System.Drawing.Color.Silver;
            this.cmbTahun.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTahun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTahun.FocusedColor = System.Drawing.Color.Empty;
            this.cmbTahun.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbTahun.ForeColor = System.Drawing.Color.Black;
            this.cmbTahun.FormattingEnabled = true;
            this.cmbTahun.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035"});
            this.cmbTahun.Location = new System.Drawing.Point(333, 59);
            this.cmbTahun.Name = "cmbTahun";
            this.cmbTahun.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbTahun.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbTahun.Size = new System.Drawing.Size(87, 28);
            this.cmbTahun.TabIndex = 37;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gunaLabel1);
            this.groupBox1.Controls.Add(this.rdoBulan);
            this.groupBox1.Controls.Add(this.rdoPeriodeTanggal);
            this.groupBox1.Controls.Add(this.rdoTanggal);
            this.groupBox1.Controls.Add(this.dtTanggalAkhir);
            this.groupBox1.Controls.Add(this.dtTanggalMulai);
            this.groupBox1.Controls.Add(this.dtTanggal);
            this.groupBox1.Controls.Add(this.cmbBulan);
            this.groupBox1.Controls.Add(this.cmbTahun);
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(900, 105);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel1.Location = new System.Drawing.Point(810, 30);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(28, 19);
            this.gunaLabel1.TabIndex = 41;
            this.gunaLabel1.Text = "s/d";
            // 
            // rdoBulan
            // 
            this.rdoBulan.BaseColor = System.Drawing.SystemColors.Control;
            this.rdoBulan.CheckedOffColor = System.Drawing.Color.Gray;
            this.rdoBulan.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rdoBulan.FillColor = System.Drawing.Color.White;
            this.rdoBulan.Location = new System.Drawing.Point(21, 61);
            this.rdoBulan.Name = "rdoBulan";
            this.rdoBulan.Size = new System.Drawing.Size(100, 20);
            this.rdoBulan.TabIndex = 39;
            this.rdoBulan.Text = "Bulan / Tahun";
            this.rdoBulan.CheckedChanged += new System.EventHandler(this.rdoBulan_CheckedChanged);
            // 
            // rdoPeriodeTanggal
            // 
            this.rdoPeriodeTanggal.BaseColor = System.Drawing.SystemColors.Control;
            this.rdoPeriodeTanggal.CheckedOffColor = System.Drawing.Color.Gray;
            this.rdoPeriodeTanggal.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rdoPeriodeTanggal.FillColor = System.Drawing.Color.White;
            this.rdoPeriodeTanggal.Location = new System.Drawing.Point(518, 28);
            this.rdoPeriodeTanggal.Name = "rdoPeriodeTanggal";
            this.rdoPeriodeTanggal.Size = new System.Drawing.Size(69, 20);
            this.rdoPeriodeTanggal.TabIndex = 39;
            this.rdoPeriodeTanggal.Text = "Periode";
            this.rdoPeriodeTanggal.CheckedChanged += new System.EventHandler(this.rdoPeriodeTanggal_CheckedChanged);
            // 
            // rdoTanggal
            // 
            this.rdoTanggal.BaseColor = System.Drawing.SystemColors.Control;
            this.rdoTanggal.CheckedOffColor = System.Drawing.Color.Gray;
            this.rdoTanggal.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rdoTanggal.FillColor = System.Drawing.Color.White;
            this.rdoTanggal.Location = new System.Drawing.Point(21, 28);
            this.rdoTanggal.Name = "rdoTanggal";
            this.rdoTanggal.Size = new System.Drawing.Size(71, 20);
            this.rdoTanggal.TabIndex = 39;
            this.rdoTanggal.Text = "Tanggal";
            this.rdoTanggal.CheckedChanged += new System.EventHandler(this.rdoTanggal_CheckedChanged);
            // 
            // dtTanggalAkhir
            // 
            this.dtTanggalAkhir.BaseColor = System.Drawing.Color.White;
            this.dtTanggalAkhir.BorderColor = System.Drawing.Color.Silver;
            this.dtTanggalAkhir.CustomFormat = null;
            this.dtTanggalAkhir.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtTanggalAkhir.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtTanggalAkhir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtTanggalAkhir.ForeColor = System.Drawing.Color.Black;
            this.dtTanggalAkhir.Location = new System.Drawing.Point(620, 59);
            this.dtTanggalAkhir.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtTanggalAkhir.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtTanggalAkhir.Name = "dtTanggalAkhir";
            this.dtTanggalAkhir.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtTanggalAkhir.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtTanggalAkhir.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtTanggalAkhir.OnPressedColor = System.Drawing.Color.Black;
            this.dtTanggalAkhir.Size = new System.Drawing.Size(184, 30);
            this.dtTanggalAkhir.TabIndex = 38;
            this.dtTanggalAkhir.Text = "07 August 2020";
            this.dtTanggalAkhir.Value = new System.DateTime(2020, 8, 7, 20, 46, 33, 522);
            // 
            // dtTanggalMulai
            // 
            this.dtTanggalMulai.BaseColor = System.Drawing.Color.White;
            this.dtTanggalMulai.BorderColor = System.Drawing.Color.Silver;
            this.dtTanggalMulai.CustomFormat = null;
            this.dtTanggalMulai.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtTanggalMulai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtTanggalMulai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtTanggalMulai.ForeColor = System.Drawing.Color.Black;
            this.dtTanggalMulai.Location = new System.Drawing.Point(620, 23);
            this.dtTanggalMulai.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtTanggalMulai.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtTanggalMulai.Name = "dtTanggalMulai";
            this.dtTanggalMulai.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtTanggalMulai.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtTanggalMulai.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtTanggalMulai.OnPressedColor = System.Drawing.Color.Black;
            this.dtTanggalMulai.Size = new System.Drawing.Size(184, 30);
            this.dtTanggalMulai.TabIndex = 38;
            this.dtTanggalMulai.Text = "07 August 2020";
            this.dtTanggalMulai.Value = new System.DateTime(2020, 8, 7, 20, 46, 33, 522);
            // 
            // btnTampilkan
            // 
            this.btnTampilkan.AnimationHoverSpeed = 0.07F;
            this.btnTampilkan.AnimationSpeed = 0.03F;
            this.btnTampilkan.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(101)))), ((int)(((byte)(199)))));
            this.btnTampilkan.BorderColor = System.Drawing.Color.Black;
            this.btnTampilkan.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnTampilkan.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnTampilkan.CheckedForeColor = System.Drawing.Color.White;
            this.btnTampilkan.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnTampilkan.CheckedImage")));
            this.btnTampilkan.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnTampilkan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTampilkan.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTampilkan.FocusedColor = System.Drawing.Color.Empty;
            this.btnTampilkan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTampilkan.ForeColor = System.Drawing.Color.White;
            this.btnTampilkan.Image = global::AplikasiPembukuan.Properties.Resources.search2;
            this.btnTampilkan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTampilkan.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTampilkan.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnTampilkan.Location = new System.Drawing.Point(28, 128);
            this.btnTampilkan.Name = "btnTampilkan";
            this.btnTampilkan.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(128)))), ((int)(((byte)(250)))));
            this.btnTampilkan.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTampilkan.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTampilkan.OnHoverImage = null;
            this.btnTampilkan.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(134)))), ((int)(((byte)(235)))));
            this.btnTampilkan.OnPressedColor = System.Drawing.Color.Black;
            this.btnTampilkan.Size = new System.Drawing.Size(128, 36);
            this.btnTampilkan.TabIndex = 40;
            this.btnTampilkan.Text = "Tampilkan";
            this.btnTampilkan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTampilkan.Click += new System.EventHandler(this.btnTampilkan_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.AnimationHoverSpeed = 0.07F;
            this.btnExcel.AnimationSpeed = 0.03F;
            this.btnExcel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(101)))), ((int)(((byte)(199)))));
            this.btnExcel.BorderColor = System.Drawing.Color.Black;
            this.btnExcel.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnExcel.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnExcel.CheckedForeColor = System.Drawing.Color.White;
            this.btnExcel.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnExcel.CheckedImage")));
            this.btnExcel.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExcel.FocusedColor = System.Drawing.Color.Empty;
            this.btnExcel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnExcel.ForeColor = System.Drawing.Color.White;
            this.btnExcel.Image = global::AplikasiPembukuan.Properties.Resources.excel2;
            this.btnExcel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExcel.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExcel.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnExcel.Location = new System.Drawing.Point(28, 610);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(128)))), ((int)(((byte)(250)))));
            this.btnExcel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExcel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExcel.OnHoverImage = null;
            this.btnExcel.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(134)))), ((int)(((byte)(235)))));
            this.btnExcel.OnPressedColor = System.Drawing.Color.Black;
            this.btnExcel.Size = new System.Drawing.Size(137, 36);
            this.btnExcel.TabIndex = 41;
            this.btnExcel.Text = "Export to Excel";
            this.btnExcel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // dgvBulanan
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvBulanan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBulanan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBulanan.BackgroundColor = System.Drawing.Color.White;
            this.dgvBulanan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBulanan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBulanan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBulanan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBulanan.ColumnHeadersHeight = 30;
            this.dgvBulanan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBulanan.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBulanan.EnableHeadersVisualStyles = false;
            this.dgvBulanan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBulanan.Location = new System.Drawing.Point(28, 423);
            this.dgvBulanan.Name = "dgvBulanan";
            this.dgvBulanan.RowHeadersVisible = false;
            this.dgvBulanan.RowTemplate.Height = 30;
            this.dgvBulanan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBulanan.Size = new System.Drawing.Size(900, 121);
            this.dgvBulanan.TabIndex = 42;
            this.dgvBulanan.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvBulanan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBulanan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBulanan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBulanan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBulanan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBulanan.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvBulanan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBulanan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvBulanan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBulanan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBulanan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBulanan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBulanan.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvBulanan.ThemeStyle.ReadOnly = false;
            this.dgvBulanan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBulanan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBulanan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBulanan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvBulanan.ThemeStyle.RowsStyle.Height = 30;
            this.dgvBulanan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBulanan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.HeaderText = "No";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 70;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.HeaderText = "Bulan";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 190;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 190;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn4.HeaderText = "Total Debit";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 160;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 160;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn5.HeaderText = "Total Kredit";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 160;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 160;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn6.HeaderText = "Saldo Akhir";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 160;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 160;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Total Laba";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 160;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // FrmLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 664);
            this.Controls.Add(this.dgvBulanan);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnTampilkan);
            this.Controls.Add(this.dgvHarian);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmLaporan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laporan";
            this.Shown += new System.EventHandler(this.FrmLaporan_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHarian)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBulanan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaDataGridView dgvHarian;
        private Guna.UI.WinForms.GunaDateTimePicker dtTanggal;
        private Guna.UI.WinForms.GunaComboBox cmbBulan;
        private Guna.UI.WinForms.GunaComboBox cmbTahun;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI.WinForms.GunaRadioButton rdoBulan;
        private Guna.UI.WinForms.GunaRadioButton rdoTanggal;
        private Guna.UI.WinForms.GunaAdvenceButton btnTampilkan;
        private Guna.UI.WinForms.GunaAdvenceButton btnExcel;
        private Guna.UI.WinForms.GunaDataGridView dgvBulanan;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tempat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hak;
        private System.Windows.Forms.DataGridViewTextBoxColumn Laba;
        private System.Windows.Forms.DataGridViewTextBoxColumn Keterangan;
        private System.Windows.Forms.SaveFileDialog pesanDialog;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaRadioButton rdoPeriodeTanggal;
        private Guna.UI.WinForms.GunaDateTimePicker dtTanggalAkhir;
        private Guna.UI.WinForms.GunaDateTimePicker dtTanggalMulai;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}