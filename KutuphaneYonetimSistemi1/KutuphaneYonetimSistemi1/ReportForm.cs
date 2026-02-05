using System;
using System.Windows.Forms;
using KutuphaneYonetimSistemi1.BLL;

namespace KutuphaneYonetimSistemi1
{
    public partial class ReportForm : Form
    {
        BorrowManager bm = new BorrowManager();

        public ReportForm()
        {
            InitializeComponent();
            this.Load += ReportForm_Load;
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            ReportManager rm = new ReportManager();

            labelToplamKitap.Text = "Toplam Kitap: " + rm.GetTotalBookCount();
            labelIadeBekleyen.Text = "İade Bekleyen: " + rm.GetPendingReturnCount();
            labelToplamUye.Text = "Toplam Üye: " + rm.GetTotalMemberCount();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            dgvRapor.DataSource = bm.GetActiveBorrows();
            TabloyuSusle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvRapor.DataSource = bm.GetAllBorrows();
            TabloyuSusle();
        }

        void TabloyuSusle()
        {
            if (dgvRapor.Columns.Count > 0)
            {
                dgvRapor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvRapor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvRapor.RowHeadersVisible = false;
            }
        }

        private void labelToplamKitap_Click(object sender, EventArgs e)
        {

        }
    }
}
