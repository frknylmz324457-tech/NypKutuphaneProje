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
            ((System.ComponentModel.ISupportInitialize)dgvTalepler).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTalepler
            // 
            dgvTalepler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTalepler.ContextMenuStrip = contextMenuStrip1;
            dgvTalepler.Location = new Point(112, 232);
            dgvTalepler.Name = "dgvTalepler";
            dgvTalepler.Size = new Size(560, 206);
            dgvTalepler.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { talebiOnaylaToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 48);
            // 
            // talebiOnaylaToolStripMenuItem
            // 
            talebiOnaylaToolStripMenuItem.Name = "talebiOnaylaToolStripMenuItem";
            talebiOnaylaToolStripMenuItem.Size = new Size(180, 22);
            talebiOnaylaToolStripMenuItem.Text = "Talebi Onayla";
            talebiOnaylaToolStripMenuItem.Click += talebiOnaylaToolStripMenuItem_Click;
            // 
            // TalepForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 464);
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
    }
}