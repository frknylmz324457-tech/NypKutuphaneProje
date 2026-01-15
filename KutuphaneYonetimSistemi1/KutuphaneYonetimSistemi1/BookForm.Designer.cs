namespace KutuphaneYonetimSistemi1
{
    partial class BookForm
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
            dgvBooks = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            groupBox1 = new GroupBox();
            txtStock = new TextBox();
            txtYear = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label6 = new Label();
            txtPageCount = new TextBox();
            txtId = new TextBox();
            txtAuthor = new TextBox();
            txtPublisher = new TextBox();
            txtTitle = new TextBox();
            txtISBN = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvBooks
            // 
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(12, 360);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.Size = new Size(1025, 175);
            dgvBooks.TabIndex = 0;
            dgvBooks.CellClick += dgvBooks_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 1;
            label1.Text = "ISBN:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 78);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 2;
            label2.Text = "Kitap Adı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 169);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 3;
            label4.Text = "Yayınevi:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 209);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 4;
            label5.Text = "Sayfa Sayısı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 126);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 5;
            label3.Text = "Yazar:";
            label3.Click += label3_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(222, 21);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 34);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(222, 101);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 34);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(222, 61);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 34);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtStock);
            groupBox1.Controls.Add(txtYear);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtPageCount);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(txtAuthor);
            groupBox1.Controls.Add(txtPublisher);
            groupBox1.Controls.Add(txtTitle);
            groupBox1.Controls.Add(txtISBN);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(194, 342);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kitap Bilgileri";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(82, 277);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 13;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(82, 242);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(100, 23);
            txtYear.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 250);
            label7.Name = "label7";
            label7.Size = new Size(23, 15);
            label7.TabIndex = 10;
            label7.Text = "Yıl:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 280);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 11;
            label8.Text = "Stok:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 313);
            label6.Name = "label6";
            label6.Size = new Size(20, 15);
            label6.TabIndex = 10;
            label6.Text = "Id:";
            // 
            // txtPageCount
            // 
            txtPageCount.Location = new Point(82, 206);
            txtPageCount.Name = "txtPageCount";
            txtPageCount.Size = new Size(100, 23);
            txtPageCount.TabIndex = 9;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(82, 313);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 11;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(82, 123);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(100, 23);
            txtAuthor.TabIndex = 8;
            // 
            // txtPublisher
            // 
            txtPublisher.Location = new Point(82, 169);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.Size = new Size(100, 23);
            txtPublisher.TabIndex = 10;
            txtPublisher.TextChanged += textBox5_TextChanged;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(82, 75);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(100, 23);
            txtTitle.TabIndex = 7;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(82, 31);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(100, 23);
            txtISBN.TabIndex = 6;
            txtISBN.TextChanged += txtISBN_TextChanged;
            // 
            // BookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 547);
            Controls.Add(groupBox1);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvBooks);
            Name = "BookForm";
            Text = "BookForm";
            Load += BookForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBooks;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label3;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private GroupBox groupBox1;
        private TextBox txtISBN;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private TextBox txtPageCount;
        private TextBox txtPublisher;
        private Label label6;
        private TextBox txtId;
        private TextBox txtStock;
        private TextBox txtYear;
        private Label label7;
        private Label label8;
    }
}