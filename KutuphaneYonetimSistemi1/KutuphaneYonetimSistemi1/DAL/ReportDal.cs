using System;
using System.Data;

namespace KutuphaneYonetimSistemi1.DAL
{
    public class ReportDal
    {
        private DbHelper db = new DbHelper();

        public int GetTotalBookCount()
        {
            string query = "SELECT IFNULL(SUM(stock), 0) FROM books";
            return Convert.ToInt32(db.ExecuteScalar(query));
        }


        public int GetPendingReturnCount()
        {
            string query = "SELECT COUNT(*) FROM borrows WHERE is_returned = 0";
            return Convert.ToInt32(db.ExecuteScalar(query));
        }

        public int GetTotalMemberCount()
        {
            string query = "SELECT COUNT(*) FROM members";
            return Convert.ToInt32(db.ExecuteScalar(query));
        }
    }
}
