using System;
using System.Data;
using System.Windows.Forms;
using KutuphaneYonetimSistemi1.DAL; // DbHelper neredeyse orası

namespace KutuphaneYonetimSistemi1
{
    public partial class UserDashboard : Form
    {
        DbHelper db = new DbHelper();

        public UserDashboard()
        {
            InitializeComponent();
        }

        // FORM YÜKLENİNCE ÇALIŞACAK KISIM
        private void UserDashboard_Load(object sender, EventArgs e)
        {
            KitaplariYukle();
        }

        // KİTAPLARI TABLOYA ÇEKME METODU
        void KitaplariYukle()
        {
            // Sadece stokta olan (stock > 0) kitapları getir
            string query = "SELECT id, title, author, publisher, stock FROM books WHERE stock > 0";
            dgvKitaplar.DataSource = db.GetDataTable(query);

            // Tabloyu Güzelleştirme
            if (dgvKitaplar.Columns.Count > 0)
            {
                dgvKitaplar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvKitaplar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvKitaplar.RowHeadersVisible = false; // Sol baştaki boş gri alanı gizler
            }
        }

        // BUTONA BASINCA ÇALIŞACAK KISIM (TALEP ETME)
        private void btnTalepEt_Click(object sender, EventArgs e)
        {
            // Eğer bir satır seçiliyse
            if (dgvKitaplar.SelectedRows.Count > 0)
            {
                // Seçili kitabın ID'sini al
                int bookId = Convert.ToInt32(dgvKitaplar.SelectedRows[0].Cells["id"].Value);

                // Giriş yapan üyenin ID'sini al (Program.cs'e kaydetmiştik)
                int userId = Program.CurrentUserId;

                string bugun = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                try
                {
                    // Talebi veritabanına ekle
                    string insertQuery = $"INSERT INTO book_requests (user_id, book_id, request_date, status) VALUES ({userId}, {bookId}, '{bugun}', 'Bekliyor')";

                    // Komutu çalıştır (Senin DbHelper yapına göre GetDataTable kullanıyoruz)
                    db.GetDataTable(insertQuery);

                    MessageBox.Show("Kitap talebiniz başarıyla alındı! Yönetici onaylayınca teslim alabilirsiniz.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen listeden talep etmek istediğiniz kitabı seçin.");
            }
        }

        // ÇARPIYA BASINCA PROGRAM KAPANSIN
        private void UserDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}