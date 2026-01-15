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
            dgvKitaplar = new DataGridView();
            btnTalepEt = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKitaplar).BeginInit();
            SuspendLayout();
            // 
            // dgvKitaplar
            // 
            dgvKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKitaplar.Location = new Point(12, 203);
            dgvKitaplar.Name = "dgvKitaplar";
            dgvKitaplar.Size = new Size(776, 210);
            dgvKitaplar.TabIndex = 0;
            // 
            // btnTalepEt
            // 
            btnTalepEt.Location = new Point(347, 102);
            btnTalepEt.Name = "btnTalepEt";
            btnTalepEt.Size = new Size(115, 64);
            btnTalepEt.TabIndex = 1;
            btnTalepEt.Text = "Talep et";
            btnTalepEt.UseVisualStyleBackColor = true;
            btnTalepEt.Click += btnTalepEt_Click;
            // 
            // UserDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTalepEt);
            Controls.Add(dgvKitaplar);
            Name = "UserDashboard";
            Text = "UserDashboard";
            FormClosed += UserDashboard_FormClosed;
            Load += UserDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKitaplar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvKitaplar;
        private Button btnTalepEt;
    }
}