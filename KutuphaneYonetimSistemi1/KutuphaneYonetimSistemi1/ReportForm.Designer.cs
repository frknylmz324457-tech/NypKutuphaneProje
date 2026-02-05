namespace KutuphaneYonetimSistemi1
{
    partial class ReportForm
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
            dgvRapor = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            labelToplamKitap = new Label();
            labelToplamUye = new Label();
            labelIadeBekleyen = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvRapor).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // dgvRapor
            // 
            dgvRapor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRapor.GridColor = SystemColors.InactiveCaption;
            dgvRapor.Location = new Point(-1, 213);
            dgvRapor.Name = "dgvRapor";
            dgvRapor.Size = new Size(801, 238);
            dgvRapor.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(387, 24);
            button1.Name = "button1";
            button1.Size = new Size(157, 93);
            button1.TabIndex = 1;
            button1.Text = "Aktif Ödünçler";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(604, 24);
            button2.Name = "button2";
            button2.Size = new Size(157, 93);
            button2.TabIndex = 2;
            button2.Text = "Ödünç Kaydı";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // labelToplamKitap
            // 
            labelToplamKitap.AutoSize = true;
            labelToplamKitap.Font = new Font("Segoe UI", 14F);
            labelToplamKitap.Location = new Point(57, 29);
            labelToplamKitap.Name = "labelToplamKitap";
            labelToplamKitap.Size = new Size(125, 25);
            labelToplamKitap.TabIndex = 3;
            labelToplamKitap.Text = "Toplam Kitap:";
            labelToplamKitap.Click += labelToplamKitap_Click;
            // 
            // labelToplamUye
            // 
            labelToplamUye.AutoSize = true;
            labelToplamUye.BackColor = SystemColors.ButtonHighlight;
            labelToplamUye.Font = new Font("Segoe UI", 14F);
            labelToplamUye.Location = new Point(57, 127);
            labelToplamUye.Name = "labelToplamUye";
            labelToplamUye.Size = new Size(114, 25);
            labelToplamUye.TabIndex = 4;
            labelToplamUye.Text = "Toplam Üye:";
            // 
            // labelIadeBekleyen
            // 
            labelIadeBekleyen.AutoSize = true;
            labelIadeBekleyen.Font = new Font("Segoe UI", 14F);
            labelIadeBekleyen.Location = new Point(57, 76);
            labelIadeBekleyen.Name = "labelIadeBekleyen";
            labelIadeBekleyen.Size = new Size(204, 25);
            labelIadeBekleyen.TabIndex = 5;
            labelIadeBekleyen.Text = "İade Beklenen Kitaplar:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(labelIadeBekleyen);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(labelToplamKitap);
            panel1.Controls.Add(labelToplamUye);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(324, 177);
            panel1.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.pngwing_com__3_;
            pictureBox2.Location = new Point(3, 24);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pngwing_com__4_;
            pictureBox1.Location = new Point(3, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._1;
            pictureBox3.Location = new Point(3, 127);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvRapor);
            Name = "ReportForm";
            Text = "a";
            ((System.ComponentModel.ISupportInitialize)dgvRapor).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvRapor;
        private Button button1;
        private Button button2;
        private Label labelToplamKitap;
        private Label labelToplamUye;
        private Label labelIadeBekleyen;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}