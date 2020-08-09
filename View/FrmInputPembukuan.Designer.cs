namespace AplikasiPembukuan.View
{
    partial class FrmInputPembukuan
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
            this.txtKeterangan = new Guna.UI.WinForms.GunaTextBox();
            this.btnSimpan = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.lblHeader = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtNamaItem = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtNominalDana = new Guna.UI.WinForms.GunaTextBox();
            this.cmbJenisDana = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txtNominalLaba = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKeterangan
            // 
            this.txtKeterangan.BaseColor = System.Drawing.Color.White;
            this.txtKeterangan.BorderColor = System.Drawing.Color.Silver;
            this.txtKeterangan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKeterangan.FocusedBaseColor = System.Drawing.Color.White;
            this.txtKeterangan.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtKeterangan.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtKeterangan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtKeterangan.Location = new System.Drawing.Point(150, 258);
            this.txtKeterangan.Multiline = true;
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.PasswordChar = '\0';
            this.txtKeterangan.SelectedText = "";
            this.txtKeterangan.Size = new System.Drawing.Size(312, 88);
            this.txtKeterangan.TabIndex = 62;
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
            this.btnSimpan.Location = new System.Drawing.Point(150, 366);
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
            this.gunaPanel1.Size = new System.Drawing.Size(496, 29);
            this.gunaPanel1.TabIndex = 60;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(451, 0);
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
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel4.Location = new System.Drawing.Point(29, 258);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(93, 19);
            this.gunaLabel4.TabIndex = 57;
            this.gunaLabel4.Text = "Keterangan *)";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel1.Location = new System.Drawing.Point(29, 48);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(77, 19);
            this.gunaLabel1.TabIndex = 55;
            this.gunaLabel1.Text = "Nama Item";
            // 
            // txtNamaItem
            // 
            this.txtNamaItem.BaseColor = System.Drawing.Color.White;
            this.txtNamaItem.BorderColor = System.Drawing.Color.Silver;
            this.txtNamaItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNamaItem.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNamaItem.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNamaItem.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNamaItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNamaItem.Location = new System.Drawing.Point(150, 48);
            this.txtNamaItem.Multiline = true;
            this.txtNamaItem.Name = "txtNamaItem";
            this.txtNamaItem.PasswordChar = '\0';
            this.txtNamaItem.SelectedText = "";
            this.txtNamaItem.Size = new System.Drawing.Size(312, 76);
            this.txtNamaItem.TabIndex = 61;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel3.Location = new System.Drawing.Point(29, 178);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(96, 19);
            this.gunaLabel3.TabIndex = 56;
            this.gunaLabel3.Text = "Nominal Dana";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel2.Location = new System.Drawing.Point(29, 139);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(74, 19);
            this.gunaLabel2.TabIndex = 59;
            this.gunaLabel2.Text = "Jenis Dana";
            // 
            // txtNominalDana
            // 
            this.txtNominalDana.BaseColor = System.Drawing.Color.White;
            this.txtNominalDana.BorderColor = System.Drawing.Color.Silver;
            this.txtNominalDana.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNominalDana.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNominalDana.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNominalDana.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNominalDana.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNominalDana.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNominalDana.Location = new System.Drawing.Point(150, 174);
            this.txtNominalDana.Name = "txtNominalDana";
            this.txtNominalDana.PasswordChar = '\0';
            this.txtNominalDana.SelectedText = "";
            this.txtNominalDana.Size = new System.Drawing.Size(191, 30);
            this.txtNominalDana.TabIndex = 63;
            //this.txtNominalDana.TextChanged += new System.EventHandler(this.txtNominalDana_TextChanged);
            this.txtNominalDana.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNominalDana_KeyPress);
            // 
            // cmbJenisDana
            // 
            this.cmbJenisDana.BackColor = System.Drawing.Color.Transparent;
            this.cmbJenisDana.BaseColor = System.Drawing.Color.White;
            this.cmbJenisDana.BorderColor = System.Drawing.Color.Silver;
            this.cmbJenisDana.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbJenisDana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJenisDana.FocusedColor = System.Drawing.Color.Empty;
            this.cmbJenisDana.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbJenisDana.ForeColor = System.Drawing.Color.Black;
            this.cmbJenisDana.FormattingEnabled = true;
            this.cmbJenisDana.Items.AddRange(new object[] {
            "DEBIT",
            "KREDIT",
            "SALDO"});
            this.cmbJenisDana.Location = new System.Drawing.Point(150, 136);
            this.cmbJenisDana.Name = "cmbJenisDana";
            this.cmbJenisDana.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbJenisDana.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbJenisDana.Size = new System.Drawing.Size(144, 26);
            this.cmbJenisDana.TabIndex = 74;
            this.cmbJenisDana.SelectedIndexChanged += new System.EventHandler(this.cmbJenisDana_SelectedIndexChanged);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel5.Location = new System.Drawing.Point(29, 220);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(107, 19);
            this.gunaLabel5.TabIndex = 56;
            this.gunaLabel5.Text = "Nominal Laba *)";
            // 
            // txtNominalLaba
            // 
            this.txtNominalLaba.BaseColor = System.Drawing.Color.White;
            this.txtNominalLaba.BorderColor = System.Drawing.Color.Silver;
            this.txtNominalLaba.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNominalLaba.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNominalLaba.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNominalLaba.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNominalLaba.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNominalLaba.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNominalLaba.Location = new System.Drawing.Point(150, 216);
            this.txtNominalLaba.Name = "txtNominalLaba";
            this.txtNominalLaba.PasswordChar = '\0';
            this.txtNominalLaba.SelectedText = "";
            this.txtNominalLaba.Size = new System.Drawing.Size(191, 30);
            this.txtNominalLaba.TabIndex = 63;
            //this.txtNominalLaba.TextChanged += new System.EventHandler(this.txtNominalLaba_TextChanged);
            this.txtNominalLaba.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNominalLaba_KeyPress);
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.gunaLabel6.ForeColor = System.Drawing.Color.Red;
            this.gunaLabel6.Location = new System.Drawing.Point(29, 413);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(142, 19);
            this.gunaLabel6.TabIndex = 57;
            this.gunaLabel6.Text = "*) Boleh dikosongkan";
            // 
            // FrmInputPembukuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 441);
            this.Controls.Add(this.cmbJenisDana);
            this.Controls.Add(this.txtKeterangan);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txtNamaItem);
            this.Controls.Add(this.txtNominalLaba);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.txtNominalDana);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmInputPembukuan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInputPembukuan";
            this.Shown += new System.EventHandler(this.FrmInputPembukuan_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmInputPembukuan_KeyPress);
            this.gunaPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaTextBox txtKeterangan;
        private Guna.UI.WinForms.GunaButton btnSimpan;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaLabel lblHeader;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txtNamaItem;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txtNominalDana;
        private Guna.UI.WinForms.GunaComboBox cmbJenisDana;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaTextBox txtNominalLaba;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
    }
}