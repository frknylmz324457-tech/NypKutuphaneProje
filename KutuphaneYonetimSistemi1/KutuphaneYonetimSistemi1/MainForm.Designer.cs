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
            taleplerToolStripMenuItem = new ToolStripMenuItem();
            menuRapor = new ToolStripMenuItem();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuKitap, menuUye, ödünçİşlemleriToolStripMenuItem, taleplerToolStripMenuItem, menuRapor, çıkışToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(156, 427);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // menuKitap
            // 
            menuKitap.AutoSize = false;
            menuKitap.BackColor = Color.Sienna;
            menuKitap.Name = "menuKitap";
            menuKitap.Size = new Size(150, 70);
            menuKitap.Text = "Kitap İşlemleri";
            menuKitap.Click += kitapİşlemleriToolStripMenuItem_Click;
            // 
            // menuUye
            // 
            menuUye.AutoSize = false;
            menuUye.BackColor = SystemColors.ActiveCaption;
            menuUye.Name = "menuUye";
            menuUye.Size = new Size(150, 70);
            menuUye.Text = "Üye İşlemleri";
            menuUye.Click += üyeİşlemleriToolStripMenuItem_Click;
            // 
            // ödünçİşlemleriToolStripMenuItem
            // 
            ödünçİşlemleriToolStripMenuItem.AutoSize = false;
            ödünçİşlemleriToolStripMenuItem.BackColor = Color.RosyBrown;
            ödünçİşlemleriToolStripMenuItem.Name = "ödünçİşlemleriToolStripMenuItem";
            ödünçİşlemleriToolStripMenuItem.Size = new Size(150, 70);
            ödünçİşlemleriToolStripMenuItem.Text = "Ödünç İşlemleri";
            ödünçİşlemleriToolStripMenuItem.Click += ödünçİşlemleriToolStripMenuItem_Click;
            // 
            // taleplerToolStripMenuItem
            // 
            taleplerToolStripMenuItem.AutoSize = false;
            taleplerToolStripMenuItem.BackColor = Color.LightSalmon;
            taleplerToolStripMenuItem.Name = "taleplerToolStripMenuItem";
            taleplerToolStripMenuItem.Size = new Size(150, 70);
            taleplerToolStripMenuItem.Text = "Talepler";
            taleplerToolStripMenuItem.Click += taleplerToolStripMenuItem_Click;
            // 
            // menuRapor
            // 
            menuRapor.AutoSize = false;
            menuRapor.BackColor = Color.Tan;
            menuRapor.Name = "menuRapor";
            menuRapor.Size = new Size(150, 70);
            menuRapor.Text = "Raporlar";
            menuRapor.Click += menuRapor_Click;
            // 
            // çıkışToolStripMenuItem
            // 
            çıkışToolStripMenuItem.AutoSize = false;
            çıkışToolStripMenuItem.BackColor = Color.IndianRed;
            çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.Size = new Size(150, 70);
            çıkışToolStripMenuItem.Text = "Çıkış";
            çıkışToolStripMenuItem.Click += çıkışToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(236, 18);
            label1.Name = "label1";
            label1.Size = new Size(102, 45);
            label1.TabIndex = 1;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 427);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
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
        private Label label1;
    }
}