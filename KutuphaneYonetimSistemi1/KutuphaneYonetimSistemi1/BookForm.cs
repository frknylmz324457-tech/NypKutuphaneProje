using KutuphaneYonetimSistemi1.BLL;
using KutuphaneYonetimSistemi1.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneYonetimSistemi1
{
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtISBN_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Book b = new Book();
            b.ISBN = txtISBN.Text;
            b.Title = txtTitle.Text;
            b.Author = txtAuthor.Text;
            b.Publisher = txtPublisher.Text;

            int.TryParse(txtPageCount.Text, out int sayfa);
            b.PageCount = sayfa;

            int.TryParse(txtYear.Text, out int yil);
            b.Year = yil;

            int.TryParse(txtStock.Text, out int stok);
            b.Stock = stok;

            BookManager bm = new BookManager();
            bm.AddBook(b);

            MessageBox.Show("Kitap Eklendi!");
            KitaplariListele();
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;


            DataGridViewRow row = dgvBooks.Rows[e.RowIndex];


            txtId.Text = row.Cells["id"].Value.ToString();
            txtISBN.Text = row.Cells["isbn"].Value.ToString();
            txtTitle.Text = row.Cells["title"].Value.ToString();
            txtAuthor.Text = row.Cells["author"].Value.ToString();
            txtPublisher.Text = row.Cells["publisher"].Value.ToString();

            txtPageCount.Text = row.Cells["page_count"].Value != DBNull.Value ? row.Cells["page_count"].Value.ToString() : "0";
            txtYear.Text = row.Cells["year"].Value != DBNull.Value ? row.Cells["year"].Value.ToString() : "0";
            txtStock.Text = row.Cells["stock"].Value != DBNull.Value ? row.Cells["stock"].Value.ToString() : "0";
        }


        private void KitaplariListele()
        {
            KutuphaneYonetimSistemi1.BLL.BookManager kitapMuduru = new KutuphaneYonetimSistemi1.BLL.BookManager();
            dgvBooks.DataSource = kitapMuduru.GetAllBooks();
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            if (Program.CurrentUserRole != "Admin")
            {
                MessageBox.Show("Bu ekrana erişim yetkiniz yok!");
                this.Close();
                return;
            }
            KitaplariListele();
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (dgvBooks.CurrentRow == null)
            {
                MessageBox.Show("Lütfen listeden güncellenecek kitabı seçin!");
                return;
            }

            Book b = new Book();


            b.Id = Convert.ToInt32(dgvBooks.CurrentRow.Cells[0].Value);


            b.ISBN = txtISBN.Text;
            b.Title = txtTitle.Text;
            b.Author = txtAuthor.Text;
            b.Publisher = txtPublisher.Text;


            int sayfa, yil, stok;

            int.TryParse(txtPageCount.Text, out sayfa);
            b.PageCount = sayfa;

            int.TryParse(txtYear.Text, out yil);
            b.Year = yil;

            int.TryParse(txtStock.Text, out stok);
            b.Stock = stok;


            BookManager bm = new BookManager();
            bm.UpdateBook(b);

            MessageBox.Show("Kitap bilgileri güncellendi!");
            KitaplariListele();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silinecek kitabı seçin!");
                return;
            }

            DialogResult cevap = MessageBox.Show("Bu kitabı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (cevap == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvBooks.CurrentRow.Cells[0].Value);

                BookManager bm = new BookManager();
                bm.DeleteBook(id);

                MessageBox.Show("Kitap silindi.");

                KitaplariListele();
            }
        }
    }
}
