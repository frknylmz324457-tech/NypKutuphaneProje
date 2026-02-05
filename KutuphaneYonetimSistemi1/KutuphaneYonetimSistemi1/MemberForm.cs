using System;
using System.Windows.Forms;
using KutuphaneYonetimSistemi1.BLL;
using KutuphaneYonetimSistemi1.Entities;

namespace KutuphaneYonetimSistemi1
{
    public partial class MemberForm : Form
    {
        MemberManager memberManager = new MemberManager();

        public MemberForm()
        {
            InitializeComponent();
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            if (Program.CurrentUserRole != "Admin")
            {
                MessageBox.Show("Bu ekrana erişim yetkiniz yok!");
                this.Close();
                return;
            }
            UyeleriListele();
        }

        void UyeleriListele()
        {
            dgvMembers.DataSource = memberManager.GetAllMembers();
            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Member m = new Member();
                m.FirstName = txtFirstName.Text;
                m.LastName = txtLastName.Text;
                m.Phone = txtPhone.Text;
                m.Email = txtEmail.Text;
                m.RegisterDate = DateTime.Now;

                memberManager.AddMember(m);

                MessageBox.Show("Üye eklendi!");
                UyeleriListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvMembers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellenecek üyeyi seçin!");
                return;
            }

            try
            {
                Member m = new Member();
                m.Id = Convert.ToInt32(dgvMembers.SelectedRows[0].Cells["id"].Value);
                m.FirstName = txtFirstName.Text;
                m.LastName = txtLastName.Text;
                m.Phone = txtPhone.Text;
                m.Email = txtEmail.Text;

                memberManager.UpdateMember(m);

                MessageBox.Show("Üye güncellendi!");
                UyeleriListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMembers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek üyeyi seçin!");
                return;
            }

            int id = Convert.ToInt32(dgvMembers.SelectedRows[0].Cells["id"].Value);

            DialogResult cevap = MessageBox.Show(
                "Bu üyeyi silmek istediğinize emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (cevap == DialogResult.Yes)
            {
                try
                {
                    memberManager.DeleteMember(id);
                    MessageBox.Show("Üye silindi!");
                    UyeleriListele();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void dgvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvMembers.Rows[e.RowIndex];

            txtFirstName.Text = row.Cells["first_name"].Value.ToString();
            txtLastName.Text = row.Cells["last_name"].Value.ToString();
            txtPhone.Text = row.Cells["phone"].Value.ToString();
            txtEmail.Text = row.Cells["email"].Value.ToString();
        }
    }
}
