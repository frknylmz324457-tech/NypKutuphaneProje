using System;
using System.Windows.Forms;
// ReportManager neredeyse orayı ekle (BLL veya aynı yer)
// using KutuphaneYonetimSistemi1.BLL; 

namespace KutuphaneYonetimSistemi1
{
    public partial class ReportForm : Form
    {
        ReportManager rm = new ReportManager();

        public ReportForm()
        {
            InitializeComponent();
        }

        // Form Yüklenince (Otomatik Çalışır)
        private void ReportForm_Load(object sender, EventArgs e)
        {
            // İlk açılışta bekleyenleri göstersin
            dgvRapor.DataSource = rm.GetPendingReturns();
            TabloyuSusle();
        }

        // BUTON 1: İADE BEKLEYENLER
        private void button1_Click(object sender, EventArgs e)
        {
            dgvRapor.DataSource = rm.GetPendingReturns();
            TabloyuSusle();
        }

        // BUTON 2: TÜM GEÇMİŞ
        private void button2_Click(object sender, EventArgs e)
        {
            dgvRapor.DataSource = rm.GetAllTransactionHistory();
            TabloyuSusle();
        }

        // BUTON 3: (Boşta ise şimdilik bir şey yapmasın veya çıkış olsun)
        private void button3_Click(object sender, EventArgs e)
        {
            // İstersen buraya Close(); yazarak kapatma butonu yapabilirsin.
        }

        // Tabloyu Güzelleştirme Metodu
        void TabloyuSusle()
        {
            if (dgvRapor.Columns.Count > 0)
            {
                dgvRapor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvRapor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvRapor.RowHeadersVisible = false;
            }
        }
    }
}