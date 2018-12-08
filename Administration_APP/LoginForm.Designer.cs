namespace Administration_APP
{
    partial class LoginForm
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.UsernameText = new MetroFramework.Controls.MetroTextBox();
            this.PasswordText = new MetroFramework.Controls.MetroTextBox();
            this.mtLogin = new MetroFramework.Controls.MetroTile();
            this.errorLabel = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 77);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Username";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 128);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(64, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Password";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // UsernameText
            // 
            this.UsernameText.Location = new System.Drawing.Point(97, 77);
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.Size = new System.Drawing.Size(126, 23);
            this.UsernameText.TabIndex = 2;
            this.UsernameText.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(97, 128);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '*';
            this.PasswordText.Size = new System.Drawing.Size(126, 23);
            this.PasswordText.TabIndex = 3;
            this.PasswordText.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mtLogin
            // 
            this.mtLogin.BackColor = System.Drawing.Color.Transparent;
            this.mtLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.mtLogin.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.mtLogin.ForeColor = System.Drawing.Color.Black;
            this.mtLogin.Location = new System.Drawing.Point(109, 169);
            this.mtLogin.Name = "mtLogin";
            this.mtLogin.Size = new System.Drawing.Size(87, 33);
            this.mtLogin.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtLogin.TabIndex = 4;
            this.mtLogin.Text = "Login";
            this.mtLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtLogin.Click += new System.EventHandler(this.mtLogin_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.errorLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.errorLabel.Location = new System.Drawing.Point(97, 215);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(123, 25);
            this.errorLabel.TabIndex = 5;
            this.errorLabel.Text = "*Invalid Data";
            this.errorLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.errorLabel.Visible = false;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroStyleManager1.MetroStyleChanged += new System.EventHandler(this.LoginForm_Load);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 269);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.mtLogin);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.UsernameText);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "LoginForm";
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = " Login";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox UsernameText;
        private MetroFramework.Controls.MetroTextBox PasswordText;
        private MetroFramework.Controls.MetroTile mtLogin;
        private MetroFramework.Controls.MetroLabel errorLabel;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}