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


        private void BorrowForm_Load(object sender, EventArgs e)
        {
            if (Program.CurrentUserRole == "Admin" || Program.CurrentUserRole == "Staff")
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



        private void btnLend_Click(object sender, EventArgs e)
        {
            if (dgvBorrows.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen listeden bir kitap seçin.");
                return;
            }

            int bookId = Convert.ToInt32(dgvBorrows.SelectedRows[0].Cells["id"].Value);
            int memberId = 0;

            bool adminMi = Program.CurrentUserRole == "Admin";
            bool staffMi = Program.CurrentUserRole == "Staff";
            bool memberMi = Program.CurrentUserRole == "Member";

            if (memberMi)
            {
                memberId = Program.CurrentMemberId;

                if (memberId <= 0)
                {
                    MessageBox.Show("Üye bilgisi bulunamadı!");
                    return;
                }
            }
            else
            {
                
                if (string.IsNullOrEmpty(txtMemberId.Text) || !int.TryParse(txtMemberId.Text, out memberId))
                {
                    MessageBox.Show("Lütfen geçerli bir Üye ID girin.");
                    return;
                }
            }

            Borrow b = new Borrow();
            b.MemberId = memberId;
            b.BookId = bookId;

            try
            {
                bm.LendBook(b);
                MessageBox.Show("Kitap başarıyla verildi, iyi okumalar!");
                ModuGuncelle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }



        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (chkIadeModu.Checked && dgvBorrows.SelectedRows.Count > 0)
            {
                int islemId = Convert.ToInt32(dgvBorrows.SelectedRows[0].Cells["id"].Value);
                int kitapId = Convert.ToInt32(dgvBorrows.SelectedRows[0].Cells["book_id"].Value);

                bm.ReceiveBook(islemId, kitapId);
                MessageBox.Show("Kitap iade alındı, stok güncellendi! ✅");
                dgvBorrows.DataSource = bm.GetActiveBorrows();

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

            if (chkIadeModu.Checked)
            {
                if (Program.CurrentUserRole == "Admin" || Program.CurrentUserRole == "Staff")
                {
                    dgvBorrows.DataSource = bm.GetPendingReturns(); 
                }
                else
                {
                    dgvBorrows.DataSource = bm.GetMemberBorrows(Program.CurrentMemberId);
                }

                btnLend.Enabled = false;
                btnReturn.Enabled = true;
            }

            else
            {
                dgvBorrows.DataSource = bookMngr.GetBooksForBorrowing();

                btnLend.Enabled = true;
                btnReturn.Enabled = false;
            }

            if (dgvBorrows.Columns["title"] != null) dgvBorrows.Columns["title"].HeaderText = "Kitap Adı";
            if (dgvBorrows.Columns["author"] != null) dgvBorrows.Columns["author"].HeaderText = "Yazar";
            if (dgvBorrows.Columns["stock"] != null) dgvBorrows.Columns["stock"].HeaderText = "Stok";
            if (dgvBorrows.Columns["isbn"] != null) dgvBorrows.Columns["isbn"].HeaderText = "ISBN";
            if (dgvBorrows.Columns["publisher"] != null) dgvBorrows.Columns["publisher"].HeaderText = "Yayınevi";
            if (dgvBorrows.Columns["year"] != null) dgvBorrows.Columns["year"].HeaderText = "Yıl";
            if (dgvBorrows.Columns["page_count"] != null) dgvBorrows.Columns["page_count"].HeaderText = "Sayfa Sayısı";
            if (dgvBorrows.Columns["borrow_date"] != null) dgvBorrows.Columns["borrow_date"].HeaderText = "Alış Tarihi";
            if (dgvBorrows.Columns["first_name"] != null) dgvBorrows.Columns["first_name"].HeaderText = "Üye Adı";

            bool adminMi = true;

            if (dgvBorrows.Columns["id"] != null) dgvBorrows.Columns["id"].Visible = adminMi;
            if (dgvBorrows.Columns["book_id"] != null) dgvBorrows.Columns["book_id"].Visible = adminMi;
            if (dgvBorrows.Columns["member_id"] != null) dgvBorrows.Columns["member_id"].Visible = adminMi;

            if (chkIadeModu.Checked == false)
            {
                txtMemberId.Visible = true;
                if (label1 != null) label1.Visible = true;

                txtMemberId.BringToFront();
                if (label1 != null) label1.BringToFront();
            }
            else
            {
                txtMemberId.Visible = false;
                if (label1 != null) label1.Visible = false;
            }
        }



        private void BorrowForm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string aranacak = txtSearch.Text.Trim();

            if (chkIadeModu.Checked)
            {
               
                return;
            }

            if (string.IsNullOrEmpty(aranacak))
            {
              
                dgvBorrows.DataSource = bookMngr.GetBooksForBorrowing();
            }
            else
            {
                
                dgvBorrows.DataSource = bookMngr.SearchBooksForBorrowing(aranacak);
            }
        }
        private void btnIadeBekleyenler_Click(object sender, EventArgs e)
        {
            dgvBorrows.DataSource = bm.GetPendingReturns();

            if (dgvBorrows.Columns["Uye"] != null)
                dgvBorrows.Columns["Uye"].HeaderText = "Üye";

            if (dgvBorrows.Columns["Kitap"] != null)
                dgvBorrows.Columns["Kitap"].HeaderText = "Kitap Adı";

            if (dgvBorrows.Columns["AlisTarihi"] != null)
                dgvBorrows.Columns["AlisTarihi"].HeaderText = "Alış Tarihi";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}