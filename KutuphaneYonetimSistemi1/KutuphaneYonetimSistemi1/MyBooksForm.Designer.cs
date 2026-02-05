namespace KutuphaneYonetimSistemi1
{
    partial class MyBooksForm
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
            dgvKitaplarim = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvKitaplarim).BeginInit();
            SuspendLayout();
            // 
            // dgvKitaplarim
            // 
            dgvKitaplarim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKitaplarim.Location = new Point(0, 0);
            dgvKitaplarim.Name = "dgvKitaplarim";
            dgvKitaplarim.Size = new Size(803, 453);
            dgvKitaplarim.TabIndex = 0;
            // 
            // MyBooksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvKitaplarim);
            Name = "MyBooksForm";
            Text = "MyBooksForm";
            Load += MyBooksForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvKitaplarim).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvKitaplarim;
    }
}