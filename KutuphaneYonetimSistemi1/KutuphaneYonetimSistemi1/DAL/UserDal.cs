using System.Data;

namespace KutuphaneYonetimSistemi1.DAL
{
    public class UserDal
    {
        private DbHelper db = new DbHelper();

        public DataTable GetByUsernameAndPassword(string username, string password)
        {
            string query = $@"
        SELECT id, username, role, member_id
        FROM users
        WHERE username = '{username}' AND password = '{password}'
        LIMIT 1
    ";

            return db.GetDataTable(query);
        }

    }
}
