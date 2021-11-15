
namespace Eurotestament
{
    partial class Transact
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.Label();
            this.check_box = new Eurotestament.DesignControls.ComBoxControl();
            this.TxtSum = new Eurotestament.DesignControls.TextBoxControl();
            this.TxtRecepientNum = new Eurotestament.DesignControls.TextBoxControl();
            this.but_transaction = new Eurotestament.DesignControls.ButtonControl();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(326, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Баланс:";
            // 
            // txtBalance
            // 
            this.txtBalance.AutoSize = true;
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(144)))), ((int)(((byte)(95)))));
            this.txtBalance.Location = new System.Drawing.Point(399, 98);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(20, 22);
            this.txtBalance.TabIndex = 8;
            this.txtBalance.Text = "0";
            // 
            // check_box
            // 
            this.check_box.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.check_box.BackColor = System.Drawing.Color.WhiteSmoke;
            this.check_box.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.check_box.BorderSize = 2;
            this.check_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.check_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.check_box.ForeColor = System.Drawing.Color.DimGray;
            this.check_box.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.check_box.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.check_box.ListTextColor = System.Drawing.Color.DimGray;
            this.check_box.Location = new System.Drawing.Point(60, 90);
            this.check_box.MinimumSize = new System.Drawing.Size(200, 30);
            this.check_box.Name = "check_box";
            this.check_box.Padding = new System.Windows.Forms.Padding(2);
            this.check_box.Size = new System.Drawing.Size(250, 30);
            this.check_box.TabIndex = 17;
            this.check_box.Texts = "Выберите счёт списания";
            this.check_box.OnSelectedIndexChanged += new System.EventHandler(this.check_box_SelectedIndexChanged);
            // 
            // TxtSum
            // 
            this.TxtSum.BackColor = System.Drawing.SystemColors.Window;
            this.TxtSum.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtSum.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtSum.BorderRadius = 8;
            this.TxtSum.BorderSize = 2;
            this.TxtSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtSum.Location = new System.Drawing.Point(60, 52);
            this.TxtSum.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSum.Multiline = false;
            this.TxtSum.Name = "TxtSum";
            this.TxtSum.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtSum.PasswordChar = false;
            this.TxtSum.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtSum.PlaceholderText = "Сумма";
            this.TxtSum.Size = new System.Drawing.Size(250, 31);
            this.TxtSum.TabIndex = 16;
            this.TxtSum.Texts = "";
            this.TxtSum.UnderlinedStyle = false;
            // 
            // TxtRecepientNum
            // 
            this.TxtRecepientNum.BackColor = System.Drawing.SystemColors.Window;
            this.TxtRecepientNum.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtRecepientNum.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtRecepientNum.BorderRadius = 8;
            this.TxtRecepientNum.BorderSize = 2;
            this.TxtRecepientNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRecepientNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtRecepientNum.Location = new System.Drawing.Point(60, 13);
            this.TxtRecepientNum.Margin = new System.Windows.Forms.Padding(4);
            this.TxtRecepientNum.Multiline = false;
            this.TxtRecepientNum.Name = "TxtRecepientNum";
            this.TxtRecepientNum.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtRecepientNum.PasswordChar = false;
            this.TxtRecepientNum.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtRecepientNum.PlaceholderText = "Счёт получателя";
            this.TxtRecepientNum.Size = new System.Drawing.Size(250, 31);
            this.TxtRecepientNum.TabIndex = 15;
            this.TxtRecepientNum.Texts = "";
            this.TxtRecepientNum.UnderlinedStyle = false;
            // 
            // but_transaction
            // 
            this.but_transaction.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.but_transaction.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.but_transaction.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.but_transaction.BorderRadius = 10;
            this.but_transaction.BorderSize = 0;
            this.but_transaction.FlatAppearance.BorderSize = 0;
            this.but_transaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_transaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_transaction.ForeColor = System.Drawing.Color.White;
            this.but_transaction.Location = new System.Drawing.Point(60, 138);
            this.but_transaction.Name = "but_transaction";
            this.but_transaction.Size = new System.Drawing.Size(150, 40);
            this.but_transaction.TabIndex = 18;
            this.but_transaction.Text = "Перевести";
            this.but_transaction.TextColor = System.Drawing.Color.White;
            this.but_transaction.UseVisualStyleBackColor = false;
            this.but_transaction.Click += new System.EventHandler(this.but_transaction_Click);
            // 
            // Transact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.but_transaction);
            this.Controls.Add(this.check_box);
            this.Controls.Add(this.TxtSum);
            this.Controls.Add(this.TxtRecepientNum);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.label4);
            this.Name = "Transact";
            this.Text = "Переводы";
            this.Load += new System.EventHandler(this.Transact_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtBalance;
        private DesignControls.TextBoxControl TxtRecepientNum;
        private DesignControls.TextBoxControl TxtSum;
        private DesignControls.ComBoxControl check_box;
        private DesignControls.ButtonControl but_transaction;
    }
}