namespace KutuphaneYonetimSistemi1
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            menuKitap = new ToolStripMenuItem();
            menuUye = new ToolStripMenuItem();
            ödünçİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
            menuRapor = new ToolStripMenuItem();
            taleplerToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuKitap, menuUye, ödünçİşlemleriToolStripMenuItem, taleplerToolStripMenuItem, menuRapor, çıkışToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuKitap
            // 
            menuKitap.Name = "menuKitap";
            menuKitap.Size = new Size(93, 20);
            menuKitap.Text = "Kitap İşlemleri";
            menuKitap.Click += kitapİşlemleriToolStripMenuItem_Click;
            // 
            // menuUye
            // 
            menuUye.Name = "menuUye";
            menuUye.Size = new Size(86, 20);
            menuUye.Text = "Üye İşlemleri";
            menuUye.Click += üyeİşlemleriToolStripMenuItem_Click;
            // 
            // ödünçİşlemleriToolStripMenuItem
            // 
            ödünçİşlemleriToolStripMenuItem.Name = "ödünçİşlemleriToolStripMenuItem";
            ödünçİşlemleriToolStripMenuItem.Size = new Size(102, 20);
            ödünçİşlemleriToolStripMenuItem.Text = "Ödünç İşlemleri";
            ödünçİşlemleriToolStripMenuItem.Click += ödünçİşlemleriToolStripMenuItem_Click;
            // 
            // çıkışToolStripMenuItem
            // 
            çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.Size = new Size(44, 20);
            çıkışToolStripMenuItem.Text = "Çıkış";
            çıkışToolStripMenuItem.Click += çıkışToolStripMenuItem_Click;
            // 
            // menuRapor
            // 
            menuRapor.Name = "menuRapor";
            menuRapor.Size = new Size(63, 20);
            menuRapor.Text = "Raporlar";
            menuRapor.Click += menuRapor_Click;
            // 
            // taleplerToolStripMenuItem
            // 
            taleplerToolStripMenuItem.Name = "taleplerToolStripMenuItem";
            taleplerToolStripMenuItem.Size = new Size(60, 20);
            taleplerToolStripMenuItem.Text = "Talepler";
            taleplerToolStripMenuItem.Click += taleplerToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuKitap;
        private ToolStripMenuItem menuUye;
        private ToolStripMenuItem ödünçİşlemleriToolStripMenuItem;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private ToolStripMenuItem menuRapor;
        private ToolStripMenuItem taleplerToolStripMenuItem;
    }
}