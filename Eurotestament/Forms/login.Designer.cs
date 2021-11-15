
namespace Eurotestament
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.loginField = new Eurotestament.DesignControls.TextBoxControl();
            this.passField = new Eurotestament.DesignControls.TextBoxControl();
            this.ButtonLogin = new Eurotestament.DesignControls.ButtonControl();
            this.ButtonRegistr = new Eurotestament.DesignControls.ButtonControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(39)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            // 
            // loginField
            // 
            this.loginField.BackColor = System.Drawing.SystemColors.Window;
            this.loginField.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.loginField.BorderFocusColor = System.Drawing.Color.SpringGreen;
            this.loginField.BorderRadius = 8;
            this.loginField.BorderSize = 2;
            this.loginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginField.Location = new System.Drawing.Point(40, 121);
            this.loginField.Margin = new System.Windows.Forms.Padding(4);
            this.loginField.Multiline = false;
            this.loginField.Name = "loginField";
            this.loginField.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.loginField.PasswordChar = false;
            this.loginField.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.loginField.PlaceholderText = "Логин";
            this.loginField.Size = new System.Drawing.Size(250, 31);
            this.loginField.TabIndex = 7;
            this.loginField.Texts = "";
            this.loginField.UnderlinedStyle = false;
            // 
            // passField
            // 
            this.passField.BackColor = System.Drawing.SystemColors.Window;
            this.passField.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.passField.BorderFocusColor = System.Drawing.Color.SpringGreen;
            this.passField.BorderRadius = 8;
            this.passField.BorderSize = 2;
            this.passField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passField.Location = new System.Drawing.Point(40, 160);
            this.passField.Margin = new System.Windows.Forms.Padding(4);
            this.passField.Multiline = false;
            this.passField.Name = "passField";
            this.passField.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.passField.PasswordChar = true;
            this.passField.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.passField.PlaceholderText = "Пароль";
            this.passField.Size = new System.Drawing.Size(250, 31);
            this.passField.TabIndex = 8;
            this.passField.Texts = "";
            this.passField.UnderlinedStyle = false;
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ButtonLogin.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.ButtonLogin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonLogin.BorderRadius = 20;
            this.ButtonLogin.BorderSize = 0;
            this.ButtonLogin.FlatAppearance.BorderSize = 0;
            this.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonLogin.ForeColor = System.Drawing.Color.White;
            this.ButtonLogin.Location = new System.Drawing.Point(12, 225);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(150, 40);
            this.ButtonLogin.TabIndex = 9;
            this.ButtonLogin.Text = "Вход";
            this.ButtonLogin.TextColor = System.Drawing.Color.White;
            this.ButtonLogin.UseVisualStyleBackColor = false;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // ButtonRegistr
            // 
            this.ButtonRegistr.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ButtonRegistr.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.ButtonRegistr.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonRegistr.BorderRadius = 20;
            this.ButtonRegistr.BorderSize = 0;
            this.ButtonRegistr.FlatAppearance.BorderSize = 0;
            this.ButtonRegistr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRegistr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonRegistr.ForeColor = System.Drawing.Color.White;
            this.ButtonRegistr.Location = new System.Drawing.Point(168, 225);
            this.ButtonRegistr.Name = "ButtonRegistr";
            this.ButtonRegistr.Size = new System.Drawing.Size(150, 40);
            this.ButtonRegistr.TabIndex = 10;
            this.ButtonRegistr.Text = "Регистрация";
            this.ButtonRegistr.TextColor = System.Drawing.Color.White;
            this.ButtonRegistr.UseVisualStyleBackColor = false;
            this.ButtonRegistr.Click += new System.EventHandler(this.ButtonRegistr_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(325, 291);
            this.Controls.Add(this.ButtonRegistr);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EuroTestament";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Login_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private DesignControls.TextBoxControl loginField;
        private DesignControls.TextBoxControl passField;
        private DesignControls.ButtonControl ButtonLogin;
        private DesignControls.ButtonControl ButtonRegistr;
    }
}