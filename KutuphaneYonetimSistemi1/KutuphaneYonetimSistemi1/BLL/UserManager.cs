using System;
using System.Data;
using KutuphaneYonetimSistemi1.DAL;
using KutuphaneYonetimSistemi1.Entities;

namespace KutuphaneYonetimSistemi1.BLL
{
   
    public class UserManager
    {
        DbHelper db = new DbHelper();

        
        public User Login(string username, string password)
        {
            string query = $"SELECT * FROM users WHERE username = '{username}' AND password = '{password}'";
            DataTable dt = db.GetDataTable(query);

            if (dt.Rows.Count > 0)
            {
                
                User u = new User();
                
                u.Id = Convert.ToInt32(dt.Rows[0]["id"]);
                u.Username = dt.Rows[0]["username"].ToString();
                u.Role = dt.Rows[0]["role"].ToString();
                return u;
            }
            else
            {

                return null;
            }
        }
    }
}