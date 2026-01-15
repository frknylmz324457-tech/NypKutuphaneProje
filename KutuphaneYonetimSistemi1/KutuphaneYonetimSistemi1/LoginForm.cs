namespace KutuphaneYonetimSistemi1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string kadi = txtUsername.Text;
            string sifre = txtPassword.Text;

            KutuphaneYonetimSistemi1.BLL.UserManager yonetici = new KutuphaneYonetimSistemi1.BLL.UserManager();

            var girisYapan = yonetici.Login(kadi, sifre);

            if (girisYapan != null)
            {
                Program.CurrentUserRole = girisYapan.Role;
                Program.CurrentUserId = girisYapan.Id;
                MessageBox.Show("Giriþ Baþarýlý! Hoþgeldin ");

                // Rol kontrolü yapýyoruz:
                if (girisYapan.Role == "Admin")
                {
                    // Yönetici ise Ana Yönetim Formunu aç
                    MainForm mf = new MainForm(girisYapan.Role);
                    mf.Show();
                }
                else
                {
                    // Üye ise (Furkan gibi) Kullanýcý Panelini aç
                    UserDashboard ud = new UserDashboard();
                    ud.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanýcý adý veya þifre hatalý!");
            }

        }


    }
}
