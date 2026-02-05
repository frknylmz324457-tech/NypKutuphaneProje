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

               
                Program.CurrentMemberId = girisYapan.Id;

                MessageBox.Show("Giriş Başarılı! Hoşgeldin");




                if (girisYapan.Role == "Admin" || girisYapan.Role == "Staff")
                {
                    MainForm mf = new MainForm(girisYapan.Role);
                    mf.Show();
                }
                else
                {
                  
                    UserDashboard ud = new UserDashboard();
                    ud.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }




}
