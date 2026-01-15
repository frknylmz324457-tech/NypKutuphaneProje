using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using KutuphaneYonetimSistemi1.DAL; // DbHelper buradaysa

namespace KutuphaneYonetimSistemi1
{
    public partial class MemberForm : Form
    {
        DbHelper db = new DbHelper();

        public MemberForm()
        {
            InitializeComponent();
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            UyeleriListele();
        }

        // Üyeleri dgvMembers tablosuna doldur
        void UyeleriListele()
        {
            string query = "SELECT * FROM members";
            dgvMembers.DataSource = db.GetDataTable(query);

            // Tabloyu güzelleştir
            if (dgvMembers.Columns.Count > 0)
            {
                dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }

        // Gridde bir satıra tıklayınca kutulara dolsun (TextBox isimlerini kontrol et!)
        private void dgvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Başlık satırına tıklanmadıysa
            {
                // TextBox isimlerin farklıysa buraları düzeltmen gerekir (txtAd, txtSoyad vs.)
                // Örneğin: txtAd.Text = dgvMembers.Rows[e.RowIndex].Cells["first_name"].Value.ToString();

                // Eğer TextBox isimlerini hatırlamıyorsan bu kısmı yorum satırı yapabilirsin.
            }
        }

        // EKLE BUTONU
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // TextBox isimlerini kendi formuna göre düzelt: txtAd, txtSoyad, txtEmail, txtTel
            try
            {
                // Örnek: string ad = txtAd.Text;
                // Şimdilik sadece metodun iskeletini veriyorum, formundaki textbox isimlerine göre doldurmalısın.
                // string query = $"INSERT INTO members (first_name, last_name, email, phone) VALUES ('{txtAd.Text}', '{txtSoyad.Text}', '{txtEmail.Text}', '{txtTel.Text}')";
                // db.ExecuteQuery(query); // veya db.GetDataTable(query);

                MessageBox.Show("Üye Ekleme kodu için TextBox isimlerini kontrol etmelisin.");
                UyeleriListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        // SİL BUTONU
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMembers.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvMembers.SelectedRows[0].Cells["id"].Value);
                string query = "DELETE FROM members WHERE id = " + id;
                db.GetDataTable(query); // Silme işlemi

                MessageBox.Show("Üye silindi.");
                UyeleriListele();
            }
            else
            {
                MessageBox.Show("Lütfen silinecek üyeyi seçin.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        { 

        }
    }
}