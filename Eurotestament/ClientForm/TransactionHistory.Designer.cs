
namespace Eurotestament.ClientForm
{
    partial class TransactionHistory
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
            this.rbGet = new System.Windows.Forms.RadioButton();
            this.rbTake = new System.Windows.Forms.RadioButton();
            this.txtBalance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.checksBox = new Eurotestament.DesignControls.ComBoxControl();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // rbGet
            // 
            this.rbGet.AutoSize = true;
            this.rbGet.Enabled = false;
            this.rbGet.ForeColor = System.Drawing.SystemColors.Window;
            this.rbGet.Location = new System.Drawing.Point(27, 66);
            this.rbGet.Name = "rbGet";
            this.rbGet.Size = new System.Drawing.Size(87, 17);
            this.rbGet.TabIndex = 4;
            this.rbGet.TabStop = true;
            this.rbGet.Text = "Пополнение";
            this.rbGet.UseVisualStyleBackColor = true;
            this.rbGet.CheckedChanged += new System.EventHandler(this.rbGet_CheckedChanged);
            // 
            // rbTake
            // 
            this.rbTake.AutoSize = true;
            this.rbTake.Enabled = false;
            this.rbTake.ForeColor = System.Drawing.SystemColors.Window;
            this.rbTake.Location = new System.Drawing.Point(153, 66);
            this.rbTake.Name = "rbTake";
            this.rbTake.Size = new System.Drawing.Size(74, 17);
            this.rbTake.TabIndex = 5;
            this.rbTake.TabStop = true;
            this.rbTake.Text = "Списание";
            this.rbTake.UseVisualStyleBackColor = true;
            this.rbTake.CheckedChanged += new System.EventHandler(this.rbTake_CheckedChanged);
            // 
            // txtBalance
            // 
            this.txtBalance.AutoSize = true;
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(144)))), ((int)(((byte)(95)))));
            this.txtBalance.Location = new System.Drawing.Point(325, 20);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(20, 22);
            this.txtBalance.TabIndex = 10;
            this.txtBalance.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(252, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Баланс:";
            // 
            // dgvHistory
            // 
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.dgvHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.sum,
            this.cur,
            this.date});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHistory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHistory.Location = new System.Drawing.Point(27, 126);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSpringGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHistory.Size = new System.Drawing.Size(738, 361);
            this.dgvHistory.TabIndex = 11;
            this.dgvHistory.Visible = false;
            // 
            // checksBox
            // 
            this.checksBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.checksBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.checksBox.BorderSize = 1;
            this.checksBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.checksBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checksBox.ForeColor = System.Drawing.Color.DimGray;
            this.checksBox.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.checksBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.checksBox.ListTextColor = System.Drawing.Color.DimGray;
            this.checksBox.Location = new System.Drawing.Point(27, 12);
            this.checksBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.checksBox.Name = "checksBox";
            this.checksBox.Padding = new System.Windows.Forms.Padding(1);
            this.checksBox.Size = new System.Drawing.Size(200, 30);
            this.checksBox.TabIndex = 0;
            this.checksBox.Texts = "Выберите счёт";
            this.checksBox.OnSelectedIndexChanged += new System.EventHandler(this.comBoxControl1_OnSelectedIndexChanged);
            // 
            // Num
            // 
            this.Num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Num.HeaderText = "Счёт";
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            // 
            // sum
            // 
            this.sum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sum.HeaderText = "Сумма";
            this.sum.Name = "sum";
            this.sum.ReadOnly = true;
            // 
            // cur
            // 
            this.cur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cur.HeaderText = "Валюта";
            this.cur.Name = "cur";
            this.cur.ReadOnly = true;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.HeaderText = "Дата";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // TransactionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(777, 499);
            this.Controls.Add(this.dgvHistory);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbTake);
            this.Controls.Add(this.rbGet);
            this.Controls.Add(this.checksBox);
            this.Name = "TransactionHistory";
            this.Text = "История";
            this.Load += new System.EventHandler(this.TransactionHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DesignControls.ComBoxControl checksBox;
        private System.Windows.Forms.RadioButton rbGet;
        private System.Windows.Forms.RadioButton rbTake;
        private System.Windows.Forms.Label txtBalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn sum;
        private System.Windows.Forms.DataGridViewTextBoxColumn cur;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}