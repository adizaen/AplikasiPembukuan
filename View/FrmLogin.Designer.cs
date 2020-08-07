namespace AplikasiPembukuan.View
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.btnBatal = new Guna.UI.WinForms.GunaButton();
            this.btnLogin = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtPassword = new Guna.UI.WinForms.GunaTextBox();
            this.txtUsername = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel3.Location = new System.Drawing.Point(59, 140);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(67, 19);
            this.gunaLabel3.TabIndex = 10;
            this.gunaLabel3.Text = "Password";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel2.Location = new System.Drawing.Point(59, 95);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(71, 19);
            this.gunaLabel2.TabIndex = 11;
            this.gunaLabel2.Text = "Username";
            // 
            // btnBatal
            // 
            this.btnBatal.AnimationHoverSpeed = 0.07F;
            this.btnBatal.AnimationSpeed = 0.03F;
            this.btnBatal.BaseColor = System.Drawing.Color.Transparent;
            this.btnBatal.BorderColor = System.Drawing.Color.Black;
            this.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBatal.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBatal.FocusedColor = System.Drawing.Color.Empty;
            this.btnBatal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBatal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(45)))));
            this.btnBatal.Image = null;
            this.btnBatal.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBatal.Location = new System.Drawing.Point(265, 224);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnBatal.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnBatal.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnBatal.OnHoverImage = null;
            this.btnBatal.OnPressedColor = System.Drawing.Color.Transparent;
            this.btnBatal.Size = new System.Drawing.Size(47, 27);
            this.btnBatal.TabIndex = 9;
            this.btnBatal.Text = "Batal";
            this.btnBatal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLogin
            // 
            this.btnLogin.AnimationHoverSpeed = 0.07F;
            this.btnLogin.AnimationSpeed = 0.03F;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(45)))));
            this.btnLogin.BorderColor = System.Drawing.Color.Black;
            this.btnLogin.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnLogin.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnLogin.CheckedForeColor = System.Drawing.Color.White;
            this.btnLogin.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.CheckedImage")));
            this.btnLogin.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogin.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Image = null;
            this.btnLogin.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLogin.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnLogin.Location = new System.Drawing.Point(149, 175);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogin.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogin.OnHoverImage = null;
            this.btnLogin.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnLogin.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(45)))));
            this.btnLogin.Radius = 3;
            this.btnLogin.Size = new System.Drawing.Size(282, 36);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BaseColor = System.Drawing.Color.White;
            this.txtPassword.BorderColor = System.Drawing.Color.Silver;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(149, 131);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Radius = 3;
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(282, 36);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.BaseColor = System.Drawing.Color.White;
            this.txtUsername.BorderColor = System.Drawing.Color.Silver;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUsername.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtUsername.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.Location = new System.Drawing.Point(149, 87);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.Radius = 3;
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(282, 36);
            this.txtUsername.TabIndex = 7;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(45)))));
            this.gunaLabel1.Location = new System.Drawing.Point(1, 22);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(541, 40);
            this.gunaLabel1.TabIndex = 5;
            this.gunaLabel1.Text = "Selamat Datang";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 273);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.gunaLabel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaButton btnBatal;
        private Guna.UI.WinForms.GunaAdvenceButton btnLogin;
        private Guna.UI.WinForms.GunaTextBox txtPassword;
        private Guna.UI.WinForms.GunaTextBox txtUsername;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}