
namespace Eurotestament.AdminForm
{
    partial class Settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaxTrans = new Eurotestament.DesignControls.TextBoxControl();
            this.txtMaxUsers = new Eurotestament.DesignControls.TextBoxControl();
            this.txtDay = new Eurotestament.DesignControls.TextBoxControl();
            this.butSave = new Eurotestament.DesignControls.ButtonControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(73, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Настройка симуляции";
            // 
            // txtMaxTrans
            // 
            this.txtMaxTrans.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaxTrans.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMaxTrans.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMaxTrans.BorderRadius = 0;
            this.txtMaxTrans.BorderSize = 2;
            this.txtMaxTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxTrans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaxTrans.Location = new System.Drawing.Point(65, 132);
            this.txtMaxTrans.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaxTrans.Multiline = false;
            this.txtMaxTrans.Name = "txtMaxTrans";
            this.txtMaxTrans.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMaxTrans.PasswordChar = false;
            this.txtMaxTrans.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaxTrans.PlaceholderText = "Транзакций в день";
            this.txtMaxTrans.Size = new System.Drawing.Size(228, 31);
            this.txtMaxTrans.TabIndex = 3;
            this.txtMaxTrans.Texts = "";
            this.txtMaxTrans.UnderlinedStyle = false;
            // 
            // txtMaxUsers
            // 
            this.txtMaxUsers.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaxUsers.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMaxUsers.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMaxUsers.BorderRadius = 0;
            this.txtMaxUsers.BorderSize = 2;
            this.txtMaxUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaxUsers.Location = new System.Drawing.Point(65, 93);
            this.txtMaxUsers.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaxUsers.Multiline = false;
            this.txtMaxUsers.Name = "txtMaxUsers";
            this.txtMaxUsers.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMaxUsers.PasswordChar = false;
            this.txtMaxUsers.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaxUsers.PlaceholderText = "Новых пользователей в день";
            this.txtMaxUsers.Size = new System.Drawing.Size(228, 31);
            this.txtMaxUsers.TabIndex = 2;
            this.txtMaxUsers.Texts = "";
            this.txtMaxUsers.UnderlinedStyle = false;
            // 
            // txtDay
            // 
            this.txtDay.BackColor = System.Drawing.SystemColors.Window;
            this.txtDay.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDay.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDay.BorderRadius = 0;
            this.txtDay.BorderSize = 2;
            this.txtDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDay.Location = new System.Drawing.Point(65, 54);
            this.txtDay.Margin = new System.Windows.Forms.Padding(4);
            this.txtDay.Multiline = false;
            this.txtDay.Name = "txtDay";
            this.txtDay.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDay.PasswordChar = false;
            this.txtDay.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDay.PlaceholderText = "Время 1 дня(мс)";
            this.txtDay.Size = new System.Drawing.Size(228, 31);
            this.txtDay.TabIndex = 1;
            this.txtDay.Texts = "";
            this.txtDay.UnderlinedStyle = false;
            // 
            // butSave
            // 
            this.butSave.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.butSave.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.butSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.butSave.BorderRadius = 20;
            this.butSave.BorderSize = 0;
            this.butSave.FlatAppearance.BorderSize = 0;
            this.butSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSave.ForeColor = System.Drawing.Color.White;
            this.butSave.Location = new System.Drawing.Point(99, 188);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(150, 40);
            this.butSave.TabIndex = 4;
            this.butSave.Text = "Сохранить";
            this.butSave.TextColor = System.Drawing.Color.White;
            this.butSave.UseVisualStyleBackColor = false;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(800, 653);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.txtMaxTrans);
            this.Controls.Add(this.txtMaxUsers);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.label1);
            this.Name = "Settings";
            this.Text = "Настройки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DesignControls.TextBoxControl txtDay;
        private DesignControls.TextBoxControl txtMaxUsers;
        private DesignControls.TextBoxControl txtMaxTrans;
        private DesignControls.ButtonControl butSave;
    }
}