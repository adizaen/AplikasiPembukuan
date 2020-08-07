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
            this.dgv = new Guna.UI.WinForms.GunaDataGridView();
            this.dtTanggal = new Guna.UI.WinForms.GunaDateTimePicker();
            this.cmbBulan = new Guna.UI.WinForms.GunaComboBox();
            this.cmbTahun = new Guna.UI.WinForms.GunaComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoTanggal = new Guna.UI.WinForms.GunaRadioButton();
            this.rdoBulan = new Guna.UI.WinForms.GunaRadioButton();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tempat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Laba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Keterangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnUbah = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnTampilkan = new Guna.UI.WinForms.GunaAdvenceButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv.Location = new System.Drawing.Point(28, 111);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 30;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(900, 490);
            this.dgv.TabIndex = 30;
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
            // dtTanggal
            // 
            this.dtTanggal.BaseColor = System.Drawing.Color.White;
            this.dtTanggal.BorderColor = System.Drawing.Color.Silver;
            this.dtTanggal.CustomFormat = null;
            this.dtTanggal.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtTanggal.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtTanggal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtTanggal.ForeColor = System.Drawing.Color.Black;
            this.dtTanggal.Location = new System.Drawing.Point(105, 32);
            this.dtTanggal.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtTanggal.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtTanggal.Name = "dtTanggal";
            this.dtTanggal.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtTanggal.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtTanggal.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtTanggal.OnPressedColor = System.Drawing.Color.Black;
            this.dtTanggal.Size = new System.Drawing.Size(184, 30);
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
            this.cmbBulan.Font = new System.Drawing.Font("Segoe UI", 10F);
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
            this.cmbBulan.Location = new System.Drawing.Point(452, 33);
            this.cmbBulan.Name = "cmbBulan";
            this.cmbBulan.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbBulan.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbBulan.Size = new System.Drawing.Size(184, 26);
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
            this.cmbTahun.Font = new System.Drawing.Font("Segoe UI", 10F);
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
            this.cmbTahun.Location = new System.Drawing.Point(642, 33);
            this.cmbTahun.Name = "cmbTahun";
            this.cmbTahun.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbTahun.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbTahun.Size = new System.Drawing.Size(87, 26);
            this.cmbTahun.TabIndex = 37;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTampilkan);
            this.groupBox1.Controls.Add(this.rdoBulan);
            this.groupBox1.Controls.Add(this.rdoTanggal);
            this.groupBox1.Controls.Add(this.dtTanggal);
            this.groupBox1.Controls.Add(this.cmbBulan);
            this.groupBox1.Controls.Add(this.cmbTahun);
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(900, 80);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter Berdasarkan";
            // 
            // rdoTanggal
            // 
            this.rdoTanggal.BaseColor = System.Drawing.SystemColors.Control;
            this.rdoTanggal.CheckedOffColor = System.Drawing.Color.Gray;
            this.rdoTanggal.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rdoTanggal.FillColor = System.Drawing.Color.White;
            this.rdoTanggal.Location = new System.Drawing.Point(21, 37);
            this.rdoTanggal.Name = "rdoTanggal";
            this.rdoTanggal.Size = new System.Drawing.Size(71, 20);
            this.rdoTanggal.TabIndex = 39;
            this.rdoTanggal.Text = "Tanggal";
            // 
            // rdoBulan
            // 
            this.rdoBulan.BaseColor = System.Drawing.SystemColors.Control;
            this.rdoBulan.CheckedOffColor = System.Drawing.Color.Gray;
            this.rdoBulan.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rdoBulan.FillColor = System.Drawing.Color.White;
            this.rdoBulan.Location = new System.Drawing.Point(334, 37);
            this.rdoBulan.Name = "rdoBulan";
            this.rdoBulan.Size = new System.Drawing.Size(100, 20);
            this.rdoBulan.TabIndex = 39;
            this.rdoBulan.Text = "Bulan / Tahun";
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.No.HeaderText = "No";
            this.No.MinimumWidth = 80;
            this.No.Name = "No";
            this.No.Width = 80;
            // 
            // Kode
            // 
            this.Kode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Kode.HeaderText = "Tanggal";
            this.Kode.MinimumWidth = 100;
            this.Kode.Name = "Kode";
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
            this.Tempat.Width = 200;
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
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(101)))), ((int)(((byte)(199)))));
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.CheckedImage")));
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = global::AplikasiPembukuan.Properties.Resources.excel2;
            this.gunaAdvenceButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(28, 616);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(128)))), ((int)(((byte)(250)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(134)))), ((int)(((byte)(235)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(137, 36);
            this.gunaAdvenceButton1.TabIndex = 41;
            this.gunaAdvenceButton1.Text = "Export to Excel";
            this.gunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnUbah.Image = global::AplikasiPembukuan.Properties.Resources.pdf;
            this.btnUbah.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUbah.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUbah.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnUbah.Location = new System.Drawing.Point(175, 616);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(128)))), ((int)(((byte)(250)))));
            this.btnUbah.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUbah.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUbah.OnHoverImage = null;
            this.btnUbah.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(134)))), ((int)(((byte)(235)))));
            this.btnUbah.OnPressedColor = System.Drawing.Color.Black;
            this.btnUbah.Size = new System.Drawing.Size(137, 36);
            this.btnUbah.TabIndex = 40;
            this.btnUbah.Text = "Export to PDF";
            this.btnUbah.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnTampilkan.Location = new System.Drawing.Point(748, 28);
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
            // 
            // FrmLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 664);
            this.Controls.Add(this.gunaAdvenceButton1);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmLaporan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laporan";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaDataGridView dgv;
        private Guna.UI.WinForms.GunaDateTimePicker dtTanggal;
        private Guna.UI.WinForms.GunaComboBox cmbBulan;
        private Guna.UI.WinForms.GunaComboBox cmbTahun;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI.WinForms.GunaRadioButton rdoBulan;
        private Guna.UI.WinForms.GunaRadioButton rdoTanggal;
        private Guna.UI.WinForms.GunaAdvenceButton btnTampilkan;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private Guna.UI.WinForms.GunaAdvenceButton btnUbah;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tempat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hak;
        private System.Windows.Forms.DataGridViewTextBoxColumn Laba;
        private System.Windows.Forms.DataGridViewTextBoxColumn Keterangan;
    }
}