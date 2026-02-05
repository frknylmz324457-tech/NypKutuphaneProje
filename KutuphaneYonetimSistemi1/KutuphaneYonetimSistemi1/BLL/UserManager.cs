using KutuphaneYonetimSistemi1.DAL;
using KutuphaneYonetimSistemi1.Entities;

namespace KutuphaneYonetimSistemi1.BLL
{
    public class UserManager
    {
        private UserDal _userDal = new UserDal();

        public User? Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new System.Exception("Kullanıcı adı boş olamaz!");

            if (string.IsNullOrWhiteSpace(password))
                throw new System.Exception("Şifre boş olamaz!");

            var dt = _userDal.GetByUsernameAndPassword(username, password);

            if (dt.Rows.Count == 0)
                return null;

            var row = dt.Rows[0];

            User u = new User();
            u.Id = Convert.ToInt32(row["id"]);
            u.Username = row["username"].ToString()!;
            u.Role = row["role"].ToString()!;

            if (row["member_id"] != DBNull.Value)
                u.MemberId = Convert.ToInt32(row["member_id"]);
            else
                u.MemberId = null;

            return u;

        }
    }
}
