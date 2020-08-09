namespace AplikasiPembukuan.View
{
    partial class FrmDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDatabase));
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.lblTglBackup = new Guna.UI.WinForms.GunaLabel();
            this.btnBackup = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.lblLokasi = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::AplikasiPembukuan.Properties.Resources.backup;
            this.gunaPictureBox1.Location = new System.Drawing.Point(37, 27);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(124, 130);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(185, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "BACKUP DATABASE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel1.Location = new System.Drawing.Point(186, 63);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(120, 19);
            this.gunaLabel1.TabIndex = 5;
            this.gunaLabel1.Text = "Terakhir di backup";
            // 
            // lblTglBackup
            // 
            this.lblTglBackup.AutoSize = true;
            this.lblTglBackup.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTglBackup.Location = new System.Drawing.Point(328, 63);
            this.lblTglBackup.Name = "lblTglBackup";
            this.lblTglBackup.Size = new System.Drawing.Size(107, 19);
            this.lblTglBackup.TabIndex = 5;
            this.lblTglBackup.Text = "8 Agustus 2020";
            // 
            // btnBackup
            // 
            this.btnBackup.AnimationHoverSpeed = 0.07F;
            this.btnBackup.AnimationSpeed = 0.03F;
            this.btnBackup.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(101)))), ((int)(((byte)(199)))));
            this.btnBackup.BorderColor = System.Drawing.Color.Black;
            this.btnBackup.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnBackup.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnBackup.CheckedForeColor = System.Drawing.Color.White;
            this.btnBackup.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnBackup.CheckedImage")));
            this.btnBackup.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackup.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBackup.FocusedColor = System.Drawing.Color.Empty;
            this.btnBackup.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBackup.ForeColor = System.Drawing.Color.White;
            this.btnBackup.Image = null;
            this.btnBackup.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBackup.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBackup.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBackup.Location = new System.Drawing.Point(190, 121);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(128)))), ((int)(((byte)(250)))));
            this.btnBackup.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBackup.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBackup.OnHoverImage = null;
            this.btnBackup.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(134)))), ((int)(((byte)(235)))));
            this.btnBackup.OnPressedColor = System.Drawing.Color.Black;
            this.btnBackup.Size = new System.Drawing.Size(128, 36);
            this.btnBackup.TabIndex = 34;
            this.btnBackup.Text = "Backup";
            this.btnBackup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel3.Location = new System.Drawing.Point(186, 87);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(71, 19);
            this.gunaLabel3.TabIndex = 5;
            this.gunaLabel3.Text = "Lokasi File";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel4.Location = new System.Drawing.Point(310, 63);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(12, 19);
            this.gunaLabel4.TabIndex = 5;
            this.gunaLabel4.Text = ":";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel5.Location = new System.Drawing.Point(310, 87);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(12, 19);
            this.gunaLabel5.TabIndex = 5;
            this.gunaLabel5.Text = ":";
            // 
            // lblLokasi
            // 
            this.lblLokasi.AutoSize = true;
            this.lblLokasi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLokasi.Location = new System.Drawing.Point(328, 87);
            this.lblLokasi.Name = "lblLokasi";
            this.lblLokasi.Size = new System.Drawing.Size(138, 19);
            this.lblLokasi.TabIndex = 5;
            this.lblLokasi.Text = "C:/BackupDB/sql1.sql";
            // 
            // FrmDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 664);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.lblLokasi);
            this.Controls.Add(this.lblTglBackup);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gunaPictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database";
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        internal System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel lblTglBackup;
        private Guna.UI.WinForms.GunaAdvenceButton btnBackup;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel lblLokasi;
    }
}