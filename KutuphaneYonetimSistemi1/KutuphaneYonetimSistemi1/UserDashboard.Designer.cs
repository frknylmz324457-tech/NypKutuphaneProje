namespace KutuphaneYonetimSistemi1
{
    partial class UserDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashboard));
            dgvKitaplar = new DataGridView();
            btnTalepEt = new Button();
            btnAldiklarim = new Button();
            label1 = new Label();
            txtSearch = new TextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvKitaplar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvKitaplar
            // 
            dgvKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKitaplar.Location = new Point(2, 44);
            dgvKitaplar.Name = "dgvKitaplar";
            dgvKitaplar.Size = new Size(1058, 335);
            dgvKitaplar.TabIndex = 0;
            // 
            // btnTalepEt
            // 
            btnTalepEt.BackColor = SystemColors.ActiveCaption;
            btnTalepEt.Font = new Font("Segoe UI", 12F);
            btnTalepEt.Location = new Point(431, 388);
            btnTalepEt.Name = "btnTalepEt";
            btnTalepEt.Size = new Size(115, 58);
            btnTalepEt.TabIndex = 1;
            btnTalepEt.Text = "Talep et";
            btnTalepEt.UseVisualStyleBackColor = false;
            btnTalepEt.Click += btnTalepEt_Click;
            // 
            // btnAldiklarim
            // 
            btnAldiklarim.BackColor = SystemColors.ActiveCaption;
            btnAldiklarim.Location = new Point(2, 385);
            btnAldiklarim.Name = "btnAldiklarim";
            btnAldiklarim.Size = new Size(187, 61);
            btnAldiklarim.TabIndex = 2;
            btnAldiklarim.Text = "Üstümdeki Kitaplar";
            btnAldiklarim.UseVisualStyleBackColor = false;
            btnAldiklarim.Click += btnAldiklarim_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(154, 29);
            label1.TabIndex = 3;
            label1.Text = "Tüm Kitaplar";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(474, 14);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(431, 14);
            label2.Name = "label2";
            label2.Size = new Size(37, 27);
            label2.TabIndex = 5;
            label2.Text = "Ara:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.pngwing_com__2_;
            pictureBox2.Location = new Point(552, 388);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(68, 58);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(580, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 23);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // UserDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 466);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(btnAldiklarim);
            Controls.Add(btnTalepEt);
            Controls.Add(dgvKitaplar);
            Name = "UserDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserDashboard";
            FormClosed += UserDashboard_FormClosed;
            Load += UserDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKitaplar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvKitaplar;
        private Button btnTalepEt;
        private Button btnAldiklarim;
        private Label label1;
        private TextBox txtSearch;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}