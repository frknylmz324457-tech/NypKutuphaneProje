namespace KutuphaneYonetimSistemi1
{
    partial class TalepForm
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
            components = new System.ComponentModel.Container();
            dgvTalepler = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            talebiOnaylaToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTalepler).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTalepler
            // 
            dgvTalepler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTalepler.ContextMenuStrip = contextMenuStrip1;
            dgvTalepler.Location = new Point(12, 116);
            dgvTalepler.Name = "dgvTalepler";
            dgvTalepler.Size = new Size(815, 336);
            dgvTalepler.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { talebiOnaylaToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(146, 26);
            // 
            // talebiOnaylaToolStripMenuItem
            // 
            talebiOnaylaToolStripMenuItem.Name = "talebiOnaylaToolStripMenuItem";
            talebiOnaylaToolStripMenuItem.Size = new Size(145, 22);
            talebiOnaylaToolStripMenuItem.Text = "Talebi Onayla";
            talebiOnaylaToolStripMenuItem.Click += talebiOnaylaToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(185, 24);
            label1.Name = "label1";
            label1.Size = new Size(454, 65);
            label1.TabIndex = 1;
            label1.Text = "Onay Bekleyen Kitaplar!";
            // 
            // TalepForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 464);
            Controls.Add(label1);
            Controls.Add(dgvTalepler);
            Name = "TalepForm";
            Text = "TalepForm";
            Load += TalepForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTalepler).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTalepler;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem talebiOnaylaToolStripMenuItem;
        private Label label1;
    }
}