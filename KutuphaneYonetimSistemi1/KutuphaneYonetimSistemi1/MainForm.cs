using KutuphaneYonetimSistemi1.DAL;
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
    public partial class MainForm : Form
    {
        DbHelper db = new DbHelper();
        string gelenRol = "";
        public MainForm(string rol)
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            string role = Program.CurrentUserRole;


            menuKitap.Visible = false;
            menuUye.Visible = false;
            menuRapor.Visible = false;
            ödünçİşlemleriToolStripMenuItem.Visible = false;
            taleplerToolStripMenuItem.Visible = false;
            label1.Text = "Hoşgeldin " + role + " Furkan ";
            if (role == "Staff")
            {
  
                menuUye.Visible = true;
                ödünçİşlemleriToolStripMenuItem.Visible = true;
                taleplerToolStripMenuItem.Visible = true;

            }
            else if (role == "Admin")
            {
                menuKitap.Visible = true;
                menuUye.Visible = true;
                menuRapor.Visible = true;
                ödünçİşlemleriToolStripMenuItem.Visible = true;
                taleplerToolStripMenuItem.Visible = true;
            }
        }














        private void kitapİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookForm kitapEkrani = new BookForm();
            kitapEkrani.Show();
        }

        private void üyeİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberForm mForm = new MemberForm();
            mForm.ShowDialog();
        }

        private void ödünçİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuRapor_Click(object sender, EventArgs e)
        {
            ReportForm raporEkrani = new ReportForm();
            raporEkrani.ShowDialog();
        }

        private void taleplerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TalepForm talepEkrani = new TalepForm();
            talepEkrani.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
