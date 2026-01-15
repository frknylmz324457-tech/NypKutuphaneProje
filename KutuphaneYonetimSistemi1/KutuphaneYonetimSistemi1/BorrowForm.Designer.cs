namespace KutuphaneYonetimSistemi1
{
    partial class BorrowForm
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
            txtMemberId = new TextBox();
            dtpDate = new DateTimePicker();
            btnLend = new Button();
            btnReturn = new Button();
            dgvBorrows = new DataGridView();
            label1 = new Label();
            chkIadeModu = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvBorrows).BeginInit();
            SuspendLayout();
            // 
            // txtMemberId
            // 
            txtMemberId.Location = new Point(85, 46);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.Size = new Size(100, 23);
            txtMemberId.TabIndex = 0;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(206, 46);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 2;
            // 
            // btnLend
            // 
            btnLend.Location = new Point(430, 33);
            btnLend.Name = "btnLend";
            btnLend.Size = new Size(75, 23);
            btnLend.TabIndex = 3;
            btnLend.Text = "Kitap al";
            btnLend.UseVisualStyleBackColor = true;
            btnLend.Click += btnLend_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(430, 62);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(75, 23);
            btnReturn.TabIndex = 4;
            btnReturn.Text = "İade et";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // dgvBorrows
            // 
            dgvBorrows.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrows.Location = new Point(12, 131);
            dgvBorrows.Name = "dgvBorrows";
            dgvBorrows.Size = new Size(776, 320);
            dgvBorrows.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 50);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 6;
            label1.Text = "Üye ID:";
            // 
            // chkIadeModu
            // 
            chkIadeModu.AutoSize = true;
            chkIadeModu.BackColor = SystemColors.ActiveCaption;
            chkIadeModu.Location = new Point(577, 50);
            chkIadeModu.Name = "chkIadeModu";
            chkIadeModu.Size = new Size(163, 19);
            chkIadeModu.TabIndex = 8;
            chkIadeModu.Text = "Teslim etmediğim kitaplar";
            chkIadeModu.UseVisualStyleBackColor = false;
            chkIadeModu.CheckedChanged += chkIadeModu_CheckedChanged;
            // 
            // BorrowForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chkIadeModu);
            Controls.Add(label1);
            Controls.Add(dgvBorrows);
            Controls.Add(btnReturn);
            Controls.Add(btnLend);
            Controls.Add(dtpDate);
            Controls.Add(txtMemberId);
            Name = "BorrowForm";
            Text = "BorrowForm";
            Load += BorrowForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBorrows).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMemberId;
        private DateTimePicker dtpDate;
        private Button btnLend;
        private Button btnReturn;
        private DataGridView dgvBorrows;
        private Label label1;
        private CheckBox chkIadeModu;
    }
}