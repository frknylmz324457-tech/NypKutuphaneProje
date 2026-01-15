using System;
using System.Data;
using System.Windows.Forms;
using KutuphaneYonetimSistemi1.DAL; 

namespace KutuphaneYonetimSistemi1
{
    public partial class TalepForm : Form
    {
        DbHelper db = new DbHelper();

        public TalepForm()
        {
            InitializeComponent();
        }

        private void TalepForm_Load(object sender, EventArgs e)
        {
            TalepleriListele();
        }

        void TalepleriListele()
        {
            string query = @"
                SELECT 
                    r.id AS TalepID,
                    u.username AS 'Kullanıcı',
                    b.title AS 'Kitap Adı',
                    r.request_date AS 'Tarih',
                    r.status AS 'Durum'
                FROM book_requests r
                JOIN users u ON r.user_id = u.id
                JOIN books b ON r.book_id = b.id
                WHERE r.status = 'Bekliyor'"; 

            dgvTalepler.DataSource = db.GetDataTable(query);

            dgvTalepler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvTalepler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void talebiOnaylaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTalepler.SelectedRows.Count > 0)
            {
                int talepID = Convert.ToInt32(dgvTalepler.SelectedRows[0].Cells["TalepID"].Value);

                string updateQuery = $"UPDATE book_requests SET status = 'Onaylandı' WHERE id = {talepID}";
                db.ExecuteQuery(updateQuery);

                MessageBox.Show("Talep onaylandı! Kitap kullanıcıya verildi.");

                TalepleriListele();

            }
            else
            {
                MessageBox.Show("Lütfen listeden bir talep seçin.");
            }
        }
    }
}