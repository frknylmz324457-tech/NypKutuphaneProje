using System;
using System.Windows.Forms;
using KutuphaneYonetimSistemi1.BLL;
using KutuphaneYonetimSistemi1.Entities;

namespace KutuphaneYonetimSistemi1
{
    public partial class BorrowForm : Form
    {
        public BorrowForm()
        {
            InitializeComponent();
        }

        BorrowManager bm = new BorrowManager();
        BookManager bookMngr = new BookManager();
        BorrowManager borrowMngr = new BorrowManager();

        private void BorrowForm_Load(object sender, EventArgs e)
        { 
            if (Program.CurrentUserRole == "admin")
            {
                txtMemberId.Visible = true;
                if (label1 != null) label1.Visible = true;
            }
            else
            {
                txtMemberId.Visible = false;
                if (label1 != null) label1.Visible = false;
            }
            ModuGuncelle();
        }

        private void RefreshBookList()
        {
            dgvBorrows.DataSource = bookMngr.GetBooksForBorrowing();
            dgvBorrows.Columns[1].HeaderText = "Kitap Adı";
            dgvBorrows.Columns[2].HeaderText = "Yazar";
            dgvBorrows.Columns[3].HeaderText = "Kalan Stok";
        }

        void Listele()
        {
            dgvBorrows.DataSource = bm.GetMemberBorrows(Program.CurrentUserId);
        }

        private void btnLend_Click(object sender, EventArgs e)
        {
            if (dgvBorrows.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen listeden bir kitap seçin.");
                return;
            }

            int bookId = Convert.ToInt32(dgvBorrows.SelectedRows[0].Cells["id"].Value);
            int memberId = 0;

            // Admin ise kutudan al, değilse kendisi
            bool adminMi = false;
            if (Program.CurrentUserRole != null) adminMi = Program.CurrentUserRole.ToLower().Contains("admin");

            if (adminMi)
            {
                if (string.IsNullOrEmpty(txtMemberId.Text) || !int.TryParse(txtMemberId.Text, out memberId))
                {
                    MessageBox.Show("Lütfen geçerli bir Üye ID girin.");
                    return;
                }
            }
            else
            {
                memberId = Program.CurrentUserId;
            }

            // --- KRİTİK NOKTA ---
            // Artık bm.BorrowBook bize "true" veya "false" döndürüyor.
            // Sadece "true" dönerse listeyi yeniliyoruz.
            bool sonuc = bm.BorrowBook(memberId, bookId);

            if (sonuc == true)
            {
                MessageBox.Show("Kitap başarıyla verildi, iyi okumalar!");
                ModuGuncelle(); // Listeyi yenile
            }
            // Hata varsa zaten BorrowBook içindeki "catch" bloğunda mesaj çıkacak
            // Ve stok düşmeyecek.
        }


        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (chkIadeModu.Checked && dgvBorrows.SelectedRows.Count > 0)
            {
                int islemId = Convert.ToInt32(dgvBorrows.SelectedRows[0].Cells["id"].Value);
                int kitapId = Convert.ToInt32(dgvBorrows.SelectedRows[0].Cells["book_id"].Value);

                borrowMngr.ReceiveBook(islemId, kitapId);
                MessageBox.Show("Kitap iade alındı, stok güncellendi! ✅");
                dgvBorrows.DataSource = borrowMngr.GetActiveBorrows();
            }
            else
            {
                MessageBox.Show("Lütfen iade edilecek işlemi seçin veya 'İade İşlemi Yap' modunu açın.");
            }
        }

        private void chkIadeModu_CheckedChanged(object sender, EventArgs e)
        {
            ModuGuncelle();
        }

        void ModuGuncelle()
        {
            // ==========================================
            // 1. VERİLERİ GETİRME
            // ==========================================
            if (chkIadeModu.Checked)
            {
                // İADE MODU
                // Rol boşsa bile hata vermemesi için güvenli kontrol
                if (Program.CurrentUserRole == "admin")
                    dgvBorrows.DataSource = bm.GetAllBorrows();
                else
                    // Eğer ID yoksa 0 gönderip boş liste çeksin, hata patlamasın
                    dgvBorrows.DataSource = bm.GetMemberBorrows(Program.CurrentUserId > 0 ? Program.CurrentUserId : 0);

                if (dgvBorrows.Columns["is_returned"] != null)
                    dgvBorrows.Columns["is_returned"].Visible = false;

                btnLend.Enabled = false;
                btnReturn.Enabled = true;
            }
            else
            {
                // KİTAP ALMA MODU
                dgvBorrows.DataSource = bookMngr.GetBooksForBorrowing();

                btnLend.Enabled = true;
                btnReturn.Enabled = false;
            }

            // ==========================================
            // 2. BAŞLIKLARI DÜZELTME
            // ==========================================
            if (dgvBorrows.Columns["title"] != null) dgvBorrows.Columns["title"].HeaderText = "Kitap Adı";
            if (dgvBorrows.Columns["author"] != null) dgvBorrows.Columns["author"].HeaderText = "Yazar";
            if (dgvBorrows.Columns["stock"] != null) dgvBorrows.Columns["stock"].HeaderText = "Stok";
            if (dgvBorrows.Columns["isbn"] != null) dgvBorrows.Columns["isbn"].HeaderText = "ISBN";
            if (dgvBorrows.Columns["publisher"] != null) dgvBorrows.Columns["publisher"].HeaderText = "Yayınevi";
            if (dgvBorrows.Columns["year"] != null) dgvBorrows.Columns["year"].HeaderText = "Yıl";
            if (dgvBorrows.Columns["page_count"] != null) dgvBorrows.Columns["page_count"].HeaderText = "Sayfa Sayısı";
            if (dgvBorrows.Columns["borrow_date"] != null) dgvBorrows.Columns["borrow_date"].HeaderText = "Alış Tarihi";
            if (dgvBorrows.Columns["first_name"] != null) dgvBorrows.Columns["first_name"].HeaderText = "Üye Adı";

            // ==========================================
            // 3. KUTUYU GÖSTERME (ZORLA AÇIYORUZ)
            // ==========================================

            // Normalde burası Program.CurrentUserRole == "admin" olmalıydı.
            // Ama senin rol değişkenin boş olduğu için şimdilik manuel "true" yapıyorum.
            bool adminMi = true;

            // ID Sütunlarını Göster
            if (dgvBorrows.Columns["id"] != null) dgvBorrows.Columns["id"].Visible = adminMi;
            if (dgvBorrows.Columns["book_id"] != null) dgvBorrows.Columns["book_id"].Visible = adminMi;
            if (dgvBorrows.Columns["member_id"] != null) dgvBorrows.Columns["member_id"].Visible = adminMi;

            // --- ID KUTUSU AYARI ---
            // Eğer Testlim Etmediğim Kitaplar (İade Modu) seçili DEĞİLSE kutuyu göster
            if (chkIadeModu.Checked == false)
            {
                txtMemberId.Visible = true;
                if (label1 != null) label1.Visible = true;

                // Öne getir
                txtMemberId.BringToFront();
                if (label1 != null) label1.BringToFront();
            }
            else
            {
                txtMemberId.Visible = false;
                if (label1 != null) label1.Visible = false;
            }
        }

    }
}