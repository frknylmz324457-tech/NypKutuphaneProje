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
            label2 = new Label();
            txtSearch = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvBorrows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtMemberId
            // 
            txtMemberId.Location = new Point(538, 31);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.Size = new Size(100, 23);
            txtMemberId.TabIndex = 0;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(464, 81);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(209, 23);
            dtpDate.TabIndex = 2;
            // 
            // btnLend
            // 
            btnLend.BackColor = Color.LawnGreen;
            btnLend.Location = new Point(693, 14);
            btnLend.Name = "btnLend";
            btnLend.Size = new Size(84, 54);
            btnLend.TabIndex = 3;
            btnLend.Text = "Ödünç Ver";
            btnLend.UseVisualStyleBackColor = false;
            btnLend.Click += btnLend_Click;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.IndianRed;
            btnReturn.Location = new Point(693, 67);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(84, 54);
            btnReturn.TabIndex = 4;
            btnReturn.Text = "İade Al";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // dgvBorrows
            // 
            dgvBorrows.BackgroundColor = SystemColors.Info;
            dgvBorrows.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrows.Location = new Point(-4, 131);
            dgvBorrows.Name = "dgvBorrows";
            dgvBorrows.Size = new Size(806, 320);
            dgvBorrows.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(488, 34);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 6;
            label1.Text = "Üye ID:";
            label1.Click += label1_Click;
            // 
            // chkIadeModu
            // 
            chkIadeModu.AutoSize = true;
            chkIadeModu.BackColor = SystemColors.ActiveCaption;
            chkIadeModu.Location = new Point(12, 12);
            chkIadeModu.Name = "chkIadeModu";
            chkIadeModu.Size = new Size(141, 19);
            chkIadeModu.TabIndex = 8;
            chkIadeModu.Text = "İade Beklenen kitaplar";
            chkIadeModu.UseVisualStyleBackColor = false;
            chkIadeModu.CheckedChanged += chkIadeModu_CheckedChanged;
            chkIadeModu.Click += btnIadeBekleyenler_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 104);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 9;
            label2.Text = "Kitap ara:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(74, 101);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(160, 23);
            txtSearch.TabIndex = 10;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search_icon_png_9983;
            pictureBox1.Location = new Point(240, 95);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // BorrowForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(txtSearch);
            Controls.Add(label2);
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
            TextChanged += BorrowForm_TextChanged;
            ((System.ComponentModel.ISupportInitialize)dgvBorrows).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Label label2;
        private TextBox txtSearch;
        private PictureBox pictureBox1;
    }
}