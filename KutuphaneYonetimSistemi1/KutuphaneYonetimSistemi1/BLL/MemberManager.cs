using System;
using System.Data;
using KutuphaneYonetimSistemi1.DAL;
using KutuphaneYonetimSistemi1.Entities;

namespace KutuphaneYonetimSistemi1.BLL
{
    public class MemberManager
    {
        DbHelper db = new DbHelper();

        public DataTable GetAllMembers()
        {
            return db.GetDataTable("SELECT * FROM members");
        }

        public void AddMember(Member m)
        {
            string tarih = m.RegisterDate.ToString("yyyy-MM-dd HH:mm:ss");

            string query = $"INSERT INTO members (first_name, last_name, phone, email, registration_date) " +
                           $"VALUES ('{m.FirstName}', '{m.LastName}', '{m.Phone}', '{m.Email}', '{tarih}')";

            db.ExecuteQuery(query);
        }

        public void UpdateMember(Member m)
        {
            string query = $"UPDATE members SET " +
                           $"first_name='{m.FirstName}', " +
                           $"last_name='{m.LastName}', " +
                           $"phone='{m.Phone}', " +
                           $"email='{m.Email}' " +
                           $"WHERE id={m.Id}";

            db.ExecuteQuery(query);
        }

        public void DeleteMember(int id)
        {
            string query = $"DELETE FROM members WHERE id={id}";
            db.ExecuteQuery(query);
        }
    }
}
