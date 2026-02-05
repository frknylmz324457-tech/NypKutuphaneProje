using System.Data;
using KutuphaneYonetimSistemi1.Entities;

namespace KutuphaneYonetimSistemi1.DAL
{
    public class MemberDal
    {
        private DbHelper db = new DbHelper();

        public void Add(Member m)
        {
            string query = $@"
        INSERT INTO members (first_name, last_name, phone, email, registration_date)
        VALUES ('{m.FirstName}', '{m.LastName}', '{m.Phone}', '{m.Email}', '{m.RegisterDate:yyyy-MM-dd HH:mm:ss}')
    ";
            db.ExecuteQuery(query);
        }


        public void Update(Member m)
        {
            string query = $@"
                UPDATE members SET
                    first_name = '{m.FirstName}',
                    last_name = '{m.LastName}',
                    phone = '{m.Phone}',
                    email = '{m.Email}'
                WHERE id = {m.Id}
            ";
            db.ExecuteQuery(query);
        }

        public void Delete(int id)
        {
            string query = $"DELETE FROM members WHERE id = {id}";
            db.ExecuteQuery(query);
        }

        public DataTable GetAll()
        {
            return db.GetDataTable("SELECT * FROM members");
        }
    }
}
