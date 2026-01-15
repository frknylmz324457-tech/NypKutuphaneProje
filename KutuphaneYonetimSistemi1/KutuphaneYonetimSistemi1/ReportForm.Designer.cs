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
            ((System.ComponentModel.ISupportInitialize)dgvRapor).BeginInit();
            SuspendLayout();
            // 
            // dgvRapor
            // 
            dgvRapor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRapor.Location = new Point(12, 134);
            dgvRapor.Name = "dgvRapor";
            dgvRapor.Size = new Size(776, 292);
            dgvRapor.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(234, 43);
            button1.Name = "button1";
            button1.Size = new Size(128, 49);
            button1.TabIndex = 1;
            button1.Text = "Aktif Ödünçler";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(405, 43);
            button2.Name = "button2";
            button2.Size = new Size(128, 49);
            button2.TabIndex = 2;
            button2.Text = "Ödünç Kaydı";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvRapor);
            Name = "ReportForm";
            Text = "a";
            ((System.ComponentModel.ISupportInitialize)dgvRapor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvRapor;
        private Button button1;
        private Button button2;
    }
}