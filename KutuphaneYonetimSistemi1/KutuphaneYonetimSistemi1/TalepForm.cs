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
            r.user_id,
            r.book_id,
            u.username AS 'Kullanıcı',
            b.title AS 'Kitap Adı',
            r.request_date AS 'Tarih',
            r.status AS 'Durum'
        FROM book_requests r
        JOIN users u ON r.user_id = u.id
        JOIN books b ON r.book_id = b.id
        WHERE r.status = 'Bekliyor'";

            dgvTalepler.DataSource = db.GetDataTable(query);

            if (dgvTalepler.Columns.Contains("user_id")) dgvTalepler.Columns["user_id"].Visible = false;
            if (dgvTalepler.Columns.Contains("book_id")) dgvTalepler.Columns["book_id"].Visible = false;

            dgvTalepler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void talebiOnaylaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTalepler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen onaylamak için bir talep seçin.");
                return;
            }

            try
            {
                int talepId = Convert.ToInt32(dgvTalepler.SelectedRows[0].Cells["TalepID"].Value);
                int userId = Convert.ToInt32(dgvTalepler.SelectedRows[0].Cells["user_id"].Value);
                int kitapId = Convert.ToInt32(dgvTalepler.SelectedRows[0].Cells["book_id"].Value);

                string memberQuery = $"SELECT member_id FROM users WHERE id = {userId}";
                DataTable dtMember = db.GetDataTable(memberQuery);

                if (dtMember.Rows.Count == 0 || dtMember.Rows[0]["member_id"] == DBNull.Value)
                {
                    MessageBox.Show("Bu kullanıcıya ait member_id bulunamadı!");
                    return;
                }

                int memberId = Convert.ToInt32(dtMember.Rows[0]["member_id"]);


                var bm = new KutuphaneYonetimSistemi1.BLL.BorrowManager();

                var borrow = new KutuphaneYonetimSistemi1.Entities.Borrow();
                borrow.MemberId = memberId;
                borrow.BookId = kitapId;

                bm.LendBook(borrow);

                db.ExecuteQuery($"UPDATE book_requests SET status = 'Onaylandı' WHERE id = {talepId}");

                MessageBox.Show("Talep onaylandı. Kitap üyeye verildi.");

                TalepleriListele(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }


        private void dgvTalepler_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}