namespace KutuphaneYonetimSistemi1
{
    static class Program
    {
        public static int CurrentUserId = 0;
        public static int CurrentMemberId = 0;
        public static string CurrentUserRole;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }

}