
namespace Eurotestament.AdminForm
{
    partial class Transaction
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
            this.dgvHis = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserNumCheck = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecipientNumCheck = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sum_transaction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sum_transaction_currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sum_enrollment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bank_recipient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_transaction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Com = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHis)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHis
            // 
            this.dgvHis.AllowUserToAddRows = false;
            this.dgvHis.AllowUserToDeleteRows = false;
            this.dgvHis.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.trans,
            this.UserNumCheck,
            this.RecipientNumCheck,
            this.Sum_transaction,
            this.Bank,
            this.Sum_transaction_currency,
            this.Sum_enrollment,
            this.bank_recipient,
            this.Column1,
            this.date_transaction,
            this.Com});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHis.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHis.Location = new System.Drawing.Point(35, 23);
            this.dgvHis.Name = "dgvHis";
            this.dgvHis.ReadOnly = true;
            this.dgvHis.Size = new System.Drawing.Size(1192, 450);
            this.dgvHis.TabIndex = 14;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // trans
            // 
            this.trans.HeaderText = "Ident";
            this.trans.Name = "trans";
            this.trans.ReadOnly = true;
            this.trans.Width = 50;
            // 
            // UserNumCheck
            // 
            this.UserNumCheck.HeaderText = "Счёт списания";
            this.UserNumCheck.Name = "UserNumCheck";
            this.UserNumCheck.ReadOnly = true;
            // 
            // RecipientNumCheck
            // 
            this.RecipientNumCheck.HeaderText = "Счёт зачисления";
            this.RecipientNumCheck.Name = "RecipientNumCheck";
            this.RecipientNumCheck.ReadOnly = true;
            // 
            // Sum_transaction
            // 
            this.Sum_transaction.HeaderText = "Сумма";
            this.Sum_transaction.Name = "Sum_transaction";
            this.Sum_transaction.ReadOnly = true;
            // 
            // Bank
            // 
            this.Bank.HeaderText = "Банк";
            this.Bank.Name = "Bank";
            this.Bank.ReadOnly = true;
            this.Bank.Width = 30;
            // 
            // Sum_transaction_currency
            // 
            this.Sum_transaction_currency.HeaderText = "Валюта отправителя";
            this.Sum_transaction_currency.Name = "Sum_transaction_currency";
            this.Sum_transaction_currency.ReadOnly = true;
            // 
            // Sum_enrollment
            // 
            this.Sum_enrollment.HeaderText = "Сумма получения";
            this.Sum_enrollment.Name = "Sum_enrollment";
            this.Sum_enrollment.ReadOnly = true;
            // 
            // bank_recipient
            // 
            this.bank_recipient.HeaderText = "Банк получаеля";
            this.bank_recipient.Name = "bank_recipient";
            this.bank_recipient.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Валюта получателя";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // date_transaction
            // 
            this.date_transaction.HeaderText = "Дата";
            this.date_transaction.Name = "date_transaction";
            this.date_transaction.ReadOnly = true;
            // 
            // Com
            // 
            this.Com.HeaderText = "Комиссия";
            this.Com.Name = "Com";
            this.Com.ReadOnly = true;
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1239, 450);
            this.Controls.Add(this.dgvHis);
            this.Name = "Transaction";
            this.Text = "Транзакции";
            this.Load += new System.EventHandler(this.Transaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvHis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn trans;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNumCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecipientNumCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sum_transaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bank;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sum_transaction_currency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sum_enrollment;
        private System.Windows.Forms.DataGridViewTextBoxColumn bank_recipient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_transaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Com;
    }
}