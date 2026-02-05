using System;
using System.Data;
using System.Windows.Forms;
using KutuphaneYonetimSistemi1.DAL;

namespace KutuphaneYonetimSistemi1
{
    public partial class UserDashboard : Form
    {
        DbHelper db = new DbHelper();

        public UserDashboard()
        {
            InitializeComponent();
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            KitaplariYukle();

        }

        void KitaplariYukle()
        {
            string query = "SELECT id, title, author, publisher, stock FROM books WHERE stock > 0";
            dgvKitaplar.DataSource = db.GetDataTable(query);

            if (dgvKitaplar.Columns.Count > 0)
            {
                dgvKitaplar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvKitaplar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvKitaplar.RowHeadersVisible = false;
            }
        }

        private void btnTalepEt_Click(object sender, EventArgs e)
        {
 
            if (dgvKitaplar.SelectedRows.Count > 0)
            {
                int bookId = Convert.ToInt32(dgvKitaplar.SelectedRows[0].Cells["id"].Value);
                int userId = Program.CurrentUserId;
                string bugun = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                try
                {
                    string insertQuery = $"INSERT INTO book_requests (user_id, book_id, request_date, status) VALUES ({userId}, {bookId}, '{bugun}', 'Bekliyor')";
                    db.ExecuteQuery(insertQuery);
                    MessageBox.Show("Kitap talebiniz alındı!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen listeden bir kitap seçin.");
            }
        }

        private void btnAldiklarim_Click(object sender, EventArgs e)
        {
            MyBooksForm frm = new MyBooksForm();
            frm.ShowDialog();
        }

        private void UserDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}