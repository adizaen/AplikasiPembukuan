namespace AplikasiPembukuan.View
{
    partial class FrmKaryawan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKaryawan));
            this.txtCari = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.dgv = new Guna.UI.WinForms.GunaDataGridView();
            this.cmbKategori = new Guna.UI.WinForms.GunaComboBox();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tempat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCari = new Guna.UI.WinForms.GunaButton();
            this.btnHapus = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnTambah = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnUbah = new Guna.UI.WinForms.GunaAdvenceButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCari
            // 
            this.txtCari.BackColor = System.Drawing.Color.Transparent;
            this.txtCari.BaseColor = System.Drawing.Color.White;
            this.txtCari.BorderColor = System.Drawing.Color.Silver;
            this.txtCari.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCari.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCari.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCari.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCari.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCari.Location = new System.Drawing.Point(106, 45);
            this.txtCari.Name = "txtCari";
            this.txtCari.PasswordChar = '\0';
            this.txtCari.SelectedText = "";
            this.txtCari.Size = new System.Drawing.Size(318, 28);
            this.txtCari.TabIndex = 27;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel2.Location = new System.Drawing.Point(25, 47);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(62, 19);
            this.gunaLabel2.TabIndex = 25;
            this.gunaLabel2.Text = "Keyword";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel1.Location = new System.Drawing.Point(25, 16);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(60, 19);
            this.gunaLabel1.TabIndex = 26;
            this.gunaLabel1.Text = "Kategori";
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
            this.Hak});
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
            this.dgv.Location = new System.Drawing.Point(28, 86);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 30;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(900, 513);
            this.dgv.TabIndex = 20;
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
            // cmbKategori
            // 
            this.cmbKategori.BackColor = System.Drawing.Color.Transparent;
            this.cmbKategori.BaseColor = System.Drawing.Color.White;
            this.cmbKategori.BorderColor = System.Drawing.Color.Silver;
            this.cmbKategori.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.FocusedColor = System.Drawing.Color.Empty;
            this.cmbKategori.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbKategori.ForeColor = System.Drawing.Color.Black;
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Items.AddRange(new object[] {
            "Nama Karyawan",
            "Kode Karyawan"});
            this.cmbKategori.Location = new System.Drawing.Point(106, 13);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbKategori.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbKategori.Size = new System.Drawing.Size(184, 26);
            this.cmbKategori.TabIndex = 28;
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
            this.Kode.HeaderText = "Kode";
            this.Kode.MinimumWidth = 150;
            this.Kode.Name = "Kode";
            this.Kode.Width = 150;
            // 
            // Nama
            // 
            this.Nama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nama.HeaderText = "Nama Lengkap";
            this.Nama.MinimumWidth = 290;
            this.Nama.Name = "Nama";
            this.Nama.Width = 290;
            // 
            // Gender
            // 
            this.Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 80;
            this.Gender.Name = "Gender";
            this.Gender.Width = 80;
            // 
            // Tempat
            // 
            this.Tempat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Tempat.HeaderText = "Telepon";
            this.Tempat.MinimumWidth = 200;
            this.Tempat.Name = "Tempat";
            this.Tempat.Width = 200;
            // 
            // Hak
            // 
            this.Hak.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Hak.HeaderText = "Hak Akses";
            this.Hak.MinimumWidth = 100;
            this.Hak.Name = "Hak";
            // 
            // btnCari
            // 
            this.btnCari.AnimationHoverSpeed = 0.07F;
            this.btnCari.AnimationSpeed = 0.03F;
            this.btnCari.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnCari.BorderColor = System.Drawing.Color.Black;
            this.btnCari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCari.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCari.FocusedColor = System.Drawing.Color.Empty;
            this.btnCari.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCari.ForeColor = System.Drawing.Color.White;
            this.btnCari.Image = global::AplikasiPembukuan.Properties.Resources.search2;
            this.btnCari.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCari.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCari.Location = new System.Drawing.Point(420, 45);
            this.btnCari.Margin = new System.Windows.Forms.Padding(0);
            this.btnCari.Name = "btnCari";
            this.btnCari.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCari.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCari.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCari.OnHoverImage = null;
            this.btnCari.OnPressedColor = System.Drawing.Color.Black;
            this.btnCari.Size = new System.Drawing.Size(49, 28);
            this.btnCari.TabIndex = 29;
            this.btnCari.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnHapus.Location = new System.Drawing.Point(296, 615);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(128)))), ((int)(((byte)(250)))));
            this.btnHapus.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHapus.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHapus.OnHoverImage = null;
            this.btnHapus.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(134)))), ((int)(((byte)(235)))));
            this.btnHapus.OnPressedColor = System.Drawing.Color.Black;
            this.btnHapus.Size = new System.Drawing.Size(128, 36);
            this.btnHapus.TabIndex = 22;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnTambah.Location = new System.Drawing.Point(28, 615);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(128)))), ((int)(((byte)(250)))));
            this.btnTambah.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTambah.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTambah.OnHoverImage = null;
            this.btnTambah.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(134)))), ((int)(((byte)(235)))));
            this.btnTambah.OnPressedColor = System.Drawing.Color.Black;
            this.btnTambah.Size = new System.Drawing.Size(128, 36);
            this.btnTambah.TabIndex = 24;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnUbah.Location = new System.Drawing.Point(162, 615);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(128)))), ((int)(((byte)(250)))));
            this.btnUbah.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUbah.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUbah.OnHoverImage = null;
            this.btnUbah.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(134)))), ((int)(((byte)(235)))));
            this.btnUbah.OnPressedColor = System.Drawing.Color.Black;
            this.btnUbah.Size = new System.Drawing.Size(128, 36);
            this.btnUbah.TabIndex = 23;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmKaryawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 664);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.cmbKategori);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmKaryawan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Karyawan";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnCari;
        private Guna.UI.WinForms.GunaAdvenceButton btnHapus;
        private Guna.UI.WinForms.GunaAdvenceButton btnTambah;
        private Guna.UI.WinForms.GunaAdvenceButton btnUbah;
        private Guna.UI.WinForms.GunaTextBox txtCari;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaDataGridView dgv;
        private Guna.UI.WinForms.GunaComboBox cmbKategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tempat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hak;
    }
}