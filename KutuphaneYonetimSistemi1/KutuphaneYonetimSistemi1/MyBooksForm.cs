using System;
using System.Data;
using System.Windows.Forms;
using KutuphaneYonetimSistemi1.DAL; 

namespace KutuphaneYonetimSistemi1
{
    public partial class MyBooksForm : Form
    {

        DbHelper db = new DbHelper();

        public MyBooksForm()
        {
            InitializeComponent();
        }
        void Listele()
        {


            try
            {

                int memberId = Program.CurrentMemberId;



                string query = $@"
        SELECT 
            b.title AS 'Kitap Adı',
            br.borrow_date AS 'Alış Tarihi',
            br.return_date AS 'İade Tarihi',
            br.is_returned AS 'İade Edildi mi'
        FROM borrows br
        JOIN books b ON br.book_id = b.id
        WHERE br.member_id = {memberId}
        ORDER BY br.borrow_date DESC";

                dgvKitaplarim.DataSource = db.GetDataTable(query);

                if (dgvKitaplarim.Columns.Count > 0)
                {
                    dgvKitaplarim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvKitaplarim.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvKitaplarim.RowHeadersVisible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

        }

        private void MyBooksForm_Load_1(object sender, EventArgs e)
        {
            Listele();
        }
    }
}