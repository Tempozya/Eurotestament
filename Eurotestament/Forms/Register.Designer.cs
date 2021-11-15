
namespace Eurotestament
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonRegister = new Eurotestament.DesignControls.ButtonControl();
            this.passField = new Eurotestament.DesignControls.TextBoxControl();
            this.surnameField = new Eurotestament.DesignControls.TextBoxControl();
            this.phoneField = new Eurotestament.DesignControls.TextBoxControl();
            this.nameField = new Eurotestament.DesignControls.TextBoxControl();
            this.loginField = new Eurotestament.DesignControls.TextBoxControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(39)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 73);
            this.panel1.TabIndex = 6;
            // 
            // ButtonRegister
            // 
            this.ButtonRegister.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ButtonRegister.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.ButtonRegister.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonRegister.BorderRadius = 20;
            this.ButtonRegister.BorderSize = 0;
            this.ButtonRegister.FlatAppearance.BorderSize = 0;
            this.ButtonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonRegister.ForeColor = System.Drawing.Color.White;
            this.ButtonRegister.Location = new System.Drawing.Point(58, 297);
            this.ButtonRegister.Name = "ButtonRegister";
            this.ButtonRegister.Size = new System.Drawing.Size(181, 40);
            this.ButtonRegister.TabIndex = 17;
            this.ButtonRegister.Text = "Регистрация";
            this.ButtonRegister.TextColor = System.Drawing.Color.White;
            this.ButtonRegister.UseVisualStyleBackColor = false;
            this.ButtonRegister.Click += new System.EventHandler(this.ButtonRegister_Click);
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
            this.passField.Location = new System.Drawing.Point(28, 130);
            this.passField.Margin = new System.Windows.Forms.Padding(4);
            this.passField.Multiline = false;
            this.passField.Name = "passField";
            this.passField.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.passField.PasswordChar = true;
            this.passField.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.passField.PlaceholderText = "Пароль";
            this.passField.Size = new System.Drawing.Size(250, 31);
            this.passField.TabIndex = 16;
            this.passField.Texts = "";
            this.passField.UnderlinedStyle = false;
            // 
            // surnameField
            // 
            this.surnameField.BackColor = System.Drawing.SystemColors.Window;
            this.surnameField.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.surnameField.BorderFocusColor = System.Drawing.Color.SpringGreen;
            this.surnameField.BorderRadius = 8;
            this.surnameField.BorderSize = 2;
            this.surnameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.surnameField.Location = new System.Drawing.Point(28, 208);
            this.surnameField.Margin = new System.Windows.Forms.Padding(4);
            this.surnameField.Multiline = false;
            this.surnameField.Name = "surnameField";
            this.surnameField.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.surnameField.PasswordChar = false;
            this.surnameField.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.surnameField.PlaceholderText = "Фамилия";
            this.surnameField.Size = new System.Drawing.Size(250, 31);
            this.surnameField.TabIndex = 15;
            this.surnameField.Texts = "";
            this.surnameField.UnderlinedStyle = false;
            // 
            // phoneField
            // 
            this.phoneField.BackColor = System.Drawing.SystemColors.Window;
            this.phoneField.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.phoneField.BorderFocusColor = System.Drawing.Color.SpringGreen;
            this.phoneField.BorderRadius = 8;
            this.phoneField.BorderSize = 2;
            this.phoneField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.phoneField.Location = new System.Drawing.Point(28, 247);
            this.phoneField.Margin = new System.Windows.Forms.Padding(4);
            this.phoneField.Multiline = false;
            this.phoneField.Name = "phoneField";
            this.phoneField.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.phoneField.PasswordChar = false;
            this.phoneField.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.phoneField.PlaceholderText = "Телефон";
            this.phoneField.Size = new System.Drawing.Size(250, 31);
            this.phoneField.TabIndex = 14;
            this.phoneField.Texts = "";
            this.phoneField.UnderlinedStyle = false;
            // 
            // nameField
            // 
            this.nameField.BackColor = System.Drawing.SystemColors.Window;
            this.nameField.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.nameField.BorderFocusColor = System.Drawing.Color.SpringGreen;
            this.nameField.BorderRadius = 8;
            this.nameField.BorderSize = 2;
            this.nameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameField.Location = new System.Drawing.Point(28, 169);
            this.nameField.Margin = new System.Windows.Forms.Padding(4);
            this.nameField.Multiline = false;
            this.nameField.Name = "nameField";
            this.nameField.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.nameField.PasswordChar = false;
            this.nameField.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.nameField.PlaceholderText = "Имя";
            this.nameField.Size = new System.Drawing.Size(250, 31);
            this.nameField.TabIndex = 13;
            this.nameField.Texts = "";
            this.nameField.UnderlinedStyle = false;
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
            this.loginField.Location = new System.Drawing.Point(28, 91);
            this.loginField.Margin = new System.Windows.Forms.Padding(4);
            this.loginField.Multiline = false;
            this.loginField.Name = "loginField";
            this.loginField.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.loginField.PasswordChar = false;
            this.loginField.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.loginField.PlaceholderText = "Логин";
            this.loginField.Size = new System.Drawing.Size(250, 31);
            this.loginField.TabIndex = 12;
            this.loginField.Texts = "";
            this.loginField.UnderlinedStyle = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(307, 356);
            this.Controls.Add(this.ButtonRegister);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.surnameField);
            this.Controls.Add(this.phoneField);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private DesignControls.TextBoxControl loginField;
        private DesignControls.TextBoxControl nameField;
        private DesignControls.TextBoxControl phoneField;
        private DesignControls.TextBoxControl surnameField;
        private DesignControls.TextBoxControl passField;
        private DesignControls.ButtonControl ButtonRegister;
    }
}